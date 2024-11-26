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
    public partial class FormTestCreate : Form
    {
        private OleDbConnection dataConnection;
        private string ID;

        public FormTestCreate(OleDbConnection dataConnection, string ID)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.ID = ID;

            creatorID.Text = ID;
            FillCharacters();
            FillQuesCount();
        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void FillQuesCount()
        {
            for(int i = 10; i < 21; i++)
            {
                quesCount.Items.Add(i.ToString());
            }
        }
        private void FillCharacters()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT charName " +
                                          "FROM tblCharacters " +
                                          "ORDER BY charName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    charactersList.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateClick(object sender, EventArgs e)
        {

            int count = 0;
            foreach(var character in charactersList.CheckedItems)
            {
                count++;
            }
            if(count < 1 || count > 3)
            {
                MessageBox.Show("Sorry, you need to select between 1 to 3 characters, you selected- " + count);
                return;
            }
            foreach(var character in charactersList.CheckedItems)
            {
                if(QuestionsForCharNumber(character.ToString()) < int.Parse(quesCount.Text))
                {
                    MessageBox.Show("Sorry, not enough questions for the character: " + character.ToString() + ", only "+ QuestionsForCharNumber(character.ToString()) + " questions.");
                    return;
                }
            }
            createButton.Text = "...יוצר";
            AddForm();
            AddCharsInForm(FormNumber());
            AddRandomQuestions(FormNumber());
            createButton.Text = "צור טופס בחינה";
            MessageBox.Show("!יצירת הטופס הושלמה בהצלחה \n" , "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private int QuestionsForCharNumber(string charName)
        {
            try
            {

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT qfcCharName " +
                                          "FROM tblQuestionsForChar " +
                                          "ORDER BY qfcCharName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();

                int count = 0;
                while (dataReader.Read())
                {
                    if (dataReader.GetString(0).Equals(charName))
                    {
                        count++;
                    }
                }
                dataReader.Close();
                return count;
            }
            catch (Exception err)
            {
                MessageBox.Show("QuestionsForCharNumber failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }
        private void AddForm()
        {
            try
            {
                DateTime now = DateTime.Now;

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblForms " +
                                     "(formName, formDate, formCreatorID) " +
                                     " VALUES (  \"{0}\", \"{1}\", {2})",
                                     formName.Text, now.Date, ID);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblForms failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int FormNumber()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT formID " +
                                          "FROM tblForms " +
                                          "ORDER BY formID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();

                int maxNum = 0;
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0) > maxNum)
                    {
                        maxNum = dataReader.GetInt32(0);
                    }
                }
                dataReader.Close();
                return maxNum;
            }
            catch (Exception err)
            {
                MessageBox.Show("Get form number failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }
        private void AddCharsInForm(int formNum)
        {
            foreach(var character in charactersList.CheckedItems)
            {
                try
                {

                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    string str = string.Format
                                        ("INSERT INTO tblCharsInForm " +
                                         "(cifFormID, cifCharName) " +
                                         " VALUES (  {0}, \"{1}\")",
                                         formNum, character.ToString());
                    datacommand.CommandText = str;
                    datacommand.ExecuteNonQuery();

                }
                catch (Exception err)
                {
                    MessageBox.Show("Insert into tblCharsInForm failed \n" + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddRandomQuestions(int FormID)
        {
            List<int> QuesList = new List<int>();
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT quesID " +
                                          "FROM tblQuestions " +
                                          "ORDER BY quesID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();

                while (dataReader.Read())
                {
                    QuesList.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Get questions for list failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //

            int charCount = 0;
            foreach (var character in charactersList.CheckedItems)
            {
                charCount++;
            }

            //


                Dictionary<string, int> charList = new Dictionary<string, int>();
                foreach (var character in charactersList.CheckedItems)
                {
                    charList.Add(character.ToString(), 0);
                }
                charList.Add("fake", 0);
                int fakeQuestionNumber = (int.Parse(quesCount.Text) * charactersList.CheckedItems.Count) / 10;
                List<int> newTestQues = new List<int>();

                while (newTestQues.Count != int.Parse(quesCount.Text) * charactersList.CheckedItems.Count + fakeQuestionNumber)  // כמות השאלות ועוד עשר אחוז שאלות דמה
                {

                    Random rnd = new Random(); int randNum = rnd.Next(1,QuesList.Count);
                    int tempNum = QuesList[randNum];
                    if(tempNum != -1)
                    {
                        bool isDone = false;
                        foreach(var item in charList)
                        {
                            if(item.Value < int.Parse(quesCount.Text) && charCheck(tempNum, item.Key))
                            {
                                isDone = true;
                                charList[item.Key]++;
                                QuesList[randNum] = -1;
                                newTestQues.Add(tempNum);
                                break;
                            }
                        }
                        if (!isDone && charList["fake"] < fakeQuestionNumber)
                        {
                            charList["fake"]++;
                            QuesList[randNum] = -1;
                            newTestQues.Add(tempNum);
                            continue;
                        }
                    }
                }


                int count = 1;
                foreach(int Q in newTestQues)
                {
                    try
                    {
                        OleDbCommand datacommand = new OleDbCommand();
                        datacommand.Connection = dataConnection;
                        string str = string.Format
                                            ("INSERT INTO tblQuestionsInForm " +
                                             "(qifFormID, qifOrderNum, qifQuestionID) " +
                                             " VALUES (  {0}, {1}, {2})",
                                             FormID, count, Q);
                        datacommand.CommandText = str;
                        datacommand.ExecuteNonQuery();
                        count++;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Insert into tblQuestionsInForms failed \n" + err.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        }
        private bool charCheck(int tempNum,string charName)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT qfcCharOrder, qfcCharName " +
                                          "FROM tblQuestionsForChar " +
                                          "ORDER BY qfcCharOrder";
                OleDbDataReader dataReader = datacommand.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0) == tempNum)
                    {
                        if(charName.Equals(dataReader.GetString(1)))
                        {
                            dataReader.Close();
                            return true;
                        }
                        dataReader.Close();
                        return false;
                    }
                }
                dataReader.Close();
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("charCheck failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}
