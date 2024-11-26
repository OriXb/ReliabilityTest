using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ReliabilityTest
{
    public partial class FormTestExaminationProcess : Form
    {
        private OleDbConnection dataConnection;
        private string formID;
        private int numberOfQuestions;
        private int index = 1;
        private string testNumber;
        private int testSpeed;
        private int tempTimerTime;
        private float score = 0;
        private float fakeCount = 0;

        Timer timer1 = new Timer();
        

        public FormTestExaminationProcess(OleDbConnection dataConnection, string userID, string userFirstName, string userLastName, string pictureUser, string formID, string testNumber, int testSpeed)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            idUser.Text = userID;
            firstNameUser.Text = userFirstName;
            lastNameUser.Text = userLastName;
            pictureBox.ImageLocation = pictureUser;
            this.formID = formID;
            numberOfQuestions = NumberOfQuestions();
            this.testNumber = testNumber;
            this.testSpeed = testSpeed;

            List<string> charData = TestChars();
            charsShow.Text = "תכונות נבדקות: ";
            foreach (string s in charData)
            {
                charsShow.Text = charsShow.Text + s + ", ";
            }
            charsShow.Text = charsShow.Text.Substring(0, charsShow.Text.Length - 2);

            timer1.Interval = 1000; // set the interval to 1 second
            timer1.Enabled = false; // start the timer disabled
            timer1.Tick += new EventHandler(timer1_Tick); // set the event handler for the timer's Tick event    
            WindowState = FormWindowState.Maximized;

            Test();
        }

        private List<string> TestChars()
        {
            try
            {
                List<string> arr = new List<string>();
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   cifCharName " +
                                          "FROM     tblCharsInForm   " +
                                          "WHERE    cifFormID = " + formID + " " +
                                          "ORDER BY cifCharName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arr.Add(dataReader.GetString(0));
                }
                dataReader.Close();
                return arr;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsForChar failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;

        }

        public void Test()
        {
            try
            {

                questionIndex.Text = index + "/" + numberOfQuestions;
                tempTimerTime = testSpeed;
                StartTimer();
                ClearButtons();
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qifQuestionID " +
                                          "FROM     tblQuestionsInForm   " +
                                          "WHERE  qifFormID = " + formID + " " +
                                          " AND qifOrderNum = " + index;
                OleDbDataReader dataReader = datacommand.ExecuteReader();

                dataReader.Read();

                string[] data = getQuesText(dataReader.GetInt32(0).ToString());
                ques.Text = index + " - " + data[0];

                AddButtons(Convert.ToInt32(data[1]));
                
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsInForm failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartTimer()
        {
            timerShow.Text = "זמן שנותר לענות: " + tempTimerTime.ToString();
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tempTimerTime--;
            timerShow.Text = "זמן שנותר לענות: " + tempTimerTime.ToString();

            if (tempTimerTime == 0)
            {
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    string str = string.Format
                                        ("INSERT INTO tblAnswersInTest " +
                                         "(aitTestID, aitOrderNum, aitAnswer) " +
                                         " VALUES ( {0}, {1}, {2})",
                                           testNumber, index, -1);
                    datacommand.CommandText = str;
                    datacommand.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Insert into tblAnswersInTest failed \n" + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //////
                if (index >= numberOfQuestions)
                {
                    nextQuesButton.Visible = false;
                    ClearButtons();
                    ques.Visible = false;
                    Answer.Visible = false;
                    timerShow.Visible = false;
                    timer1.Enabled = false;
                    label1.Visible = false;

                    finish1.Visible = true;
                    finish2.Visible = true;
                    finishScore.Visible = true;
                    finishScore.Text = GetScore();
                    return;
                }
                index++;
                Test();
            }
        }
        private string GetAnswerInTest(string testID, string quesOrderNum)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   aitOrderNum, aitAnswer " +
                                          "FROM     tblAnswersInTest   " +
                                          "WHERE    aitTestID = " + testID + " " +
                                          "ORDER BY aitOrderNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(quesOrderNum))
                    {
                        return dataReader.GetInt32(1).ToString();
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblAnswersInTest failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private string GetScore()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qifOrderNum, qifQuestionID " +
                                          "FROM     tblQuestionsInForm   " +
                                          "WHERE    qifFormID = " + formID + " " +
                                          "ORDER BY qifOrderNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string AnswerInQues = GetAnswerInTest(testNumber, dataReader.GetInt32(0).ToString());
                    GetQustForCharInfo(dataReader.GetInt32(1).ToString(), AnswerInQues);
                }
                dataReader.Close();
                return (Convert.ToInt32(score / (numberOfQuestions-fakeCount) * 100)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsInForm failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void GetQustForCharInfo(string CharOrder, string Answer)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qfcFromValue, qfcToValue, qfcCharName " +
                                          "FROM     tblQuestionsForChar   " +
                                          "WHERE    qfcCharOrder = " + CharOrder + " ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                
                    if (dataReader.GetInt32(0) <= Convert.ToInt32(Answer) && Convert.ToInt32(Answer) <= dataReader.GetInt32(1) && CheckForNotFake(dataReader.GetString(2), formID))
                    { score++; }
                    if(!CheckForNotFake(dataReader.GetString(2), formID)) { fakeCount++; }
                
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsForChar failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckForNotFake(string character, string formID)
        {
            try
            {
                string[] arr = new string[3];
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   cifCharName " +
                                          "FROM     tblCharsInForm   " +
                                          "WHERE    cifFormID = " + formID + " " +
                                          "ORDER BY cifCharName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (character.Equals(dataReader.GetString(0)))
                    { return true; }
                }
                dataReader.Close();

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsForChar failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }
        private void ClearButtons()
        {
            foreach (RadioButton button in Answer.Controls)
            {
                button.Visible = false;
                button.Checked = false;
            }
            radioButton11.Checked = true;
        }
        private void AddButtons(int num)
        {
            if (num >= 1)
            { radioButton1.Visible = true; }
            if (num >= 2)
            { radioButton2.Visible = true; }
            if (num >= 3)
            { radioButton3.Visible = true; }
            if (num >= 4)
            { radioButton4.Visible = true; }
            if (num >= 5)
            { radioButton5.Visible = true; }
            if (num >= 6)
            { radioButton6.Visible = true; }
            if (num >= 7)
            { radioButton7.Visible = true; }
            if (num >= 8)
            { radioButton8.Visible = true; }
            if (num >= 9)
            { radioButton9.Visible = true; }
            if (num >= 10)
            { radioButton10.Visible = true; }
        }
        private int NumberOfQuestions()
        {
            try
            {

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT MAX(qifOrderNum) FROM tblQuestionsInForm WHERE qifFormID = " + formID + " ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    return dataReader.GetInt32(0);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("tblQuestionsInForm failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public string[] getQuesText(string quesID)
        {
            try
            {
                string[] arr = new string[2];
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   quesText, quesAnswers " +
                                          "FROM     tblQuestions   " +
                                          "WHERE    quesID = " + quesID + " ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                
                arr[0] = dataReader.GetString(0);
                arr[1] = dataReader.GetInt32(1).ToString();
                dataReader.Close();

                return arr;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblForms failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void nextQuestionClick(object sender, EventArgs e)
        {
            nextQuesProcess();
        }

        private void nextQuesProcess()
        {
            SaveAnswer();
            if (index >= numberOfQuestions)
            {
                nextQuesButton.Visible = false;
                ClearButtons();
                ques.Visible = false;
                Answer.Visible = false;
                timerShow.Visible = false;
                timer1.Enabled = false;
                label1.Visible = false;

                finish1.Visible = true;
                finish2.Visible = true;
                finishScore.Visible = true;
                finishScore.Text = GetScore();
                return;
            }
            index++;
            Test();
        }
        private void SaveAnswer()
        {
            string ans = "-1";
            foreach (RadioButton button in Answer.Controls)
            {
                if (button.Checked)
                {
                    ans = button.Text;
                    break;
                }
            }
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblAnswersInTest " +
                                     "(aitTestID, aitOrderNum, aitAnswer) " +
                                     " VALUES ( {0}, {1}, {2})",
                                       testNumber, index, ans);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblAnswersInTest failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }

    }
}
