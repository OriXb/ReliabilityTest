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
    public partial class FormAddAnswersInTest : Form
    {
        private OleDbConnection dataConnection;
        public FormAddAnswersInTest(OleDbConnection dataConnection)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillComboTests();
        }

        private void FormAddAnswersInTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnswersInTest.tblAnswersInTest' table. You can move, or remove it, as needed.
            this.tblAnswersInTestTableAdapter.Fill(this.dataSetAnswersInTest.tblAnswersInTest);

        }
        private void FillComboTests()
        {
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT testID, testFormID " +
                                          "FROM tblTests " +
                                          "ORDER BY testID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    str = dataReader.GetInt32(0).ToString() + " - " + GetFormName(dataReader.GetInt32(1).ToString());
                    comboTests.Items.Add(str);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill tests combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFormName(string testFormID)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT formID, formName " +
                                          "FROM tblForms " +
                                          "ORDER BY formID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if(dataReader.GetInt32(0).ToString().Equals(testFormID))
                    {
                        return dataReader.GetString(1);
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("get form name failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Error";
        }
        private void FillComboAnswers()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT quesText, quesAnswers " +
                                          "FROM tblQuestions " +
                                          "ORDER BY quesText";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                string[] arr = comboOrderNum.Text.Split('-');
                while (dataReader.Read())
                {
                    if (dataReader.GetString(0).Equals(arr[1].Substring(1)))
                    {
                        for (int i = 1; i <= dataReader.GetInt32(1); i++)
                        {
                            comboAnswers.Items.Add(i);
                        }
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill answers combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FillComboQuestions()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT testID, testFormID " +
                                          "FROM tblTests " +
                                          "ORDER BY testID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                string[] arr = comboTests.Text.Split(' ');
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(arr[0]))
                    {
                        string[] arr2 = GetQuestionOrderNum(dataReader.GetInt32(1).ToString());
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            comboOrderNum.Items.Add(arr2[i]);
                        }
                        
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill questions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
            private string[] GetQuestionOrderNum(string testForm)
        {
            string[] error = new string[0];
            try
            {
                string questionText;
                int count = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT qifFormID, qifOrderNum, qifQuestionID " +
                                          "FROM tblQuestionsInForm " +
                                          "ORDER BY qifOrderNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(testForm))
                    {
                        count++;
                    }
                }
                dataReader.Close();
                string[] arr = new string[count];
                count = 0;
                dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(testForm))
                    {
                        questionText = GetQuestionText(dataReader.GetInt32(2).ToString());
                        arr[count] = dataReader.GetInt32(1).ToString() + " - " + questionText;
                        count++;
                    }
                }
                dataReader.Close();
                return arr;
            }
            catch (Exception err)
            {
                MessageBox.Show("Get order num failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return error;
        }
        private string GetQuestionText(string questionID)
        {
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT quesID, quesText " +
                                          "FROM tblQuestions " +
                                          "ORDER BY quesID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(questionID))
                    {
                        str = dataReader.GetString(1);
                        return str;
                    }

                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Get QuestionText failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Error";
        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void AddButton(object sender, EventArgs e)
        {
            try
            {
                string[] arr = comboTests.Text.Split(' ');
                string[] arr2 = comboOrderNum.Text.Split(' ');

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT aitTestID, aitOrderNum " +
                                          "FROM tblAnswersInTest " +
                                          "ORDER BY aitTestID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(arr[0]) && dataReader.GetInt32(1).ToString().Equals(arr2[0]))
                    {
                        MessageBox.Show("This question already have an answer.");
                        return;
                    }

                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblAnswersInTest failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string[] arr = comboOrderNum.Text.Split(' ');
                string[] arr2 = comboTests.Text.Split(' ');
                string str = string.Format
                                    ("INSERT INTO tblAnswersInTest " +
                                     "(aitTestID, aitOrderNum, aitAnswer) " +
                                     " VALUES ( {0}, {1}, {2})",
                                       arr2[0], arr[0], comboAnswers.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblAnswersInTest ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblAnswersInTest failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblAnswersInTest " +
                                     "ORDER BY aitTestID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuestionsClick(object sender, EventArgs e)
        {
            comboAnswers.Text = "";
            comboOrderNum.Items.Clear();
            if (comboTests.Text != "")
            {            
                FillComboQuestions();
            }

        }

        private void AnswersClick(object sender, EventArgs e)
        {
            comboAnswers.Items.Clear();
            if (comboOrderNum.Text != "")
            {    
                FillComboAnswers();
            }
        }

        private void TestsClick(object sender, EventArgs e)
        {
            comboAnswers.Text = "";
            comboOrderNum.Text = "";
        }
    }
}
