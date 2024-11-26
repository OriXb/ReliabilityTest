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
    public partial class FormUpdateAnswersInTest : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;

        private string answerText;
        public FormUpdateAnswersInTest(OleDbConnection dataConnection, bool isManager)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            RefreshDataGridView();
        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void FormUpdateAnswersInTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnswersInTest.tblAnswersInTest' table. You can move, or remove it, as needed.
            this.tblAnswersInTestTableAdapter.Fill(this.dataSetAnswersInTest.tblAnswersInTest);

        }
        private void FillComboAnswers()
        {
            try
            {
                string[] arr = orderNum.Text.Split('-');
                comboAnswers.Items.Clear();
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT quesText, quesAnswers " +
                                          "FROM tblQuestions " +
                                          "ORDER BY quesText";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetString(0).Equals(arr[1].Substring(1)))
                    {
                        for (int i = 1; i <= dataReader.GetInt32(1); i++)
                        {
                            comboAnswers.Items.Add(i);
                        }
                        break;
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
                        answerText = str;
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
        private string GetTestForm(string testFormID)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT testID, testFormID " +
                                          "FROM tblTests " +
                                          "ORDER BY testID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(testFormID))
                    {
                        return dataReader.GetInt32(1).ToString();
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("get form test failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Error";
        }
        private string GetFormName(string FormID)
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
                    if (dataReader.GetInt32(0).ToString().Equals(FormID))
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
        private string QuestionText(string questionOrderNum)
        {
            try
            {
                string str;
                string[] arr = testID.Text.Split(' ');
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT testID, testFormID " +
                                          "FROM tblTests " +
                                          "ORDER BY testID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(arr[0]))
                    {
                        str = questionOrderNum + " - " + GetQuestionID(GetTestForm(dataReader.GetInt32(0).ToString()), questionOrderNum);
                        answerText = GetQuestionID(dataReader.GetInt32(0).ToString(), questionOrderNum);
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
        private string GetQuestionID(string testForm, string questionOrderNum)
        {
            string error = "error";
            try
            {
                string questionText;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT qifFormID, qifOrderNum, qifQuestionID " +
                                          "FROM tblQuestionsInForm " +
                                          "ORDER BY qifOrderNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                string str = "No Question Exist";
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(testForm) && dataReader.GetInt32(1).ToString().Equals(questionOrderNum))
                    {
                        questionText = GetQuestionText(dataReader.GetInt32(2).ToString());
                        str = questionText;
                    }
                }
                dataReader.Close();
                answerText = str;
                return str;
            }
            catch (Exception err)
            {
                MessageBox.Show("Get order num failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return error;
        }

        private void firstButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void prevButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void nextButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void lastButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow = dataGridView.Rows.Count - 1;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
        private void FillSelectedRow()
        {
            try
            {
                testID.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString() + " - " + GetFormName(GetTestForm(dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
                orderNum.Text = QuestionText(dataGridView.SelectedRows[0].Cells[1].Value.ToString());
                comboAnswers.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                FillComboAnswers();

                dataGridView.CurrentCell = dataGridView[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            try
            {
                string[] arr = testID.Text.Split(' ');
                string[] arr2 = orderNum.Text.Split(' ');

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblAnswersInTest   \n" +
                                          "SET    aitAnswer   =  \"" + comboAnswers.Text + "\"  \n" +
                                          "WHERE  aitOrderNum = " + arr2[0] +
                                          "AND aitTestID = " + arr[0];
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView.CurrentCell = dataGridView[0, lastRow];
                MessageBox.Show("Update tblAnswersInTest ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblAnswersInTest failed \n" + err.Message, "Error",
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
                dataGridView.DataSource = tbl;
                dataGridView.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblAnswersInTest table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

       
    }
}
