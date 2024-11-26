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
    public partial class FormRptTest : Form
    {
        private OleDbConnection dataConnection;
        private string saveColor = "";

        private string testID;
        private string firstName;
        private string lastName;
        private string QuesOrderNum;
        private string QuesText;
        private string QuesFromValue;
        private string QuesToValue;
        private string QuesAnswers;
        private string Answer;
        private float Score = 0;
        private float fakeCount = 0;
        private void FormRptTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTests.tblTests' table. You can move, or remove it, as needed.
            this.tblTestsTableAdapter.Fill(this.dataSetTests.tblTests);
        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        public FormRptTest(OleDbConnection dataConnection, bool isManager)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void ShowReportButton(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Score = 0;
            fakeCount = 0;
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   testFormID, testUserID " +
                                          "FROM     tblTests   " +
                                          "WHERE    testID = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " " +
                                          "ORDER BY testFormID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();

                testID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                while (dataReader.Read())
                {
                    string[] userData = GetUserInfo(dataReader.GetInt32(1).ToString());
                    firstName = userData[0];
                    lastName = userData[1];
                    List<string> charData = TestChars(dataReader.GetInt32(0).ToString());
                    label2.Text = "תכונות נבדקות: "; 
                    foreach(string s in charData)
                    {
                        label2.Text = label2.Text + s + ", ";
                    }
                    label2.Text = label2.Text.Substring(0,label2.Text.Length - 2);

                    FormInfo(dataReader.GetInt32(0).ToString());
                    
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblForms failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<string> TestChars(string formID)
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

        private string[] GetUserInfo(string userID)
        {
            try
            {
                string[] arr = new string[2];
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userID = " + userID + " " +
                                          "ORDER BY userFirstName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arr[0] = dataReader.GetString(0);
                    arr[1] = dataReader.GetString(1);
                }
                dataReader.Close();
                return arr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private void FormInfo(string formID)
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qifOrderNum, qifQuestionID " +
                                          "FROM     tblQuestionsInForm   " +
                                          "WHERE    qifFormID = " + formID + " " +
                                          "ORDER BY qifOrderNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    QuesOrderNum = dataReader.GetInt32(0).ToString();
                    string[] quesData = GetQuesData(dataReader.GetInt32(1).ToString());
                    QuesText = quesData[0];
                    QuesAnswers = quesData[1];
                    Answer = GetAnswerInTest(testID, QuesOrderNum);
                    string[] qustForCharData = GetQustForCharInfo(dataReader.GetInt32(1).ToString(), Answer, formID);
                    QuesFromValue = qustForCharData[0];
                    QuesToValue = qustForCharData[1];
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
                int finalScore = Convert.ToInt32(Score/(counter-fakeCount)*100);
                scoreShow.Text = "ציונך הוא " + finalScore.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsInForm failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private string[] GetQuesData(string quesID)
        {
            string[] arr = new string[2];
            try
            {
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
                MessageBox.Show("Select tblQuestions failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
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
                    { return true;}
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

        private string[] GetQustForCharInfo(string CharOrder, string Answer, string formID)
        {
            try
            {
                string[] arr = new string[3];
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qfcFromValue, qfcToValue, qfcCharName " +
                                          "FROM     tblQuestionsForChar   " +
                                          "WHERE    qfcCharOrder = " + CharOrder + " " +
                                          "ORDER BY qfcFromValue";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arr[0] = dataReader.GetInt32(0).ToString();
                    arr[1] = dataReader.GetInt32(1).ToString();
                    if(dataReader.GetInt32(0) <= Convert.ToInt32(Answer) && Convert.ToInt32(Answer) <= dataReader.GetInt32(1) && CheckForNotFake(dataReader.GetString(2), formID))
                    { Score++; }
                    if (!CheckForNotFake(dataReader.GetString(2), formID)) { fakeCount++; }

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

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[10];
                if (counter == 1)
                {
                    arr[0] = testID;
                    arr[1] = firstName;
                    arr[2] = lastName;
                }
                arr[3] = QuesOrderNum;
                arr[4] = QuesText;
                arr[5] = QuesFromValue;
                arr[6] = QuesToValue;
                arr[7] = Answer;
                arr[8] = QuesAnswers;

                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectColorButton(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor.BackColor = cd.Color;
            saveColor = buttonColor.BackColor.ToArgb().ToString();
        }

        private void ClearReportButton(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            scoreShow.Text = "";
            label2.Text = "";
        }

    }
}
