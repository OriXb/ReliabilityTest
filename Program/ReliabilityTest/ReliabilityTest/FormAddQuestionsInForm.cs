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
    public partial class FormAddQuestionsInForm : Form
    {
        private OleDbConnection dataConnection;
        public FormAddQuestionsInForm(OleDbConnection dataConnection)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillComboQuestions();
            FillComboForms();

        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void FormAddQuestionsInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQuestionsInForm.tblQuestionsInForm' table. You can move, or remove it, as needed.
            this.tblQuestionsInFormTableAdapter.Fill(this.dataSetQuestionsInForm.tblQuestionsInForm);

        }
        private void FillComboForms()
        {
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT formID, formName " +
                                          "FROM tblForms " +
                                          "ORDER BY formID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    str = dataReader.GetInt32(0).ToString() + " - " + dataReader.GetString(1);
                    comboFormID.Items.Add(str);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill forms combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillComboQuestions()
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
                    str = dataReader.GetInt32(0).ToString() + " - " + dataReader.GetString(1);
                    comboQuestions.Items.Add(str);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill questions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddButton(object sender, EventArgs e)
        {
            try
            {
                string[] arr = comboFormID.Text.Split(' ');
                string[] arr2 = comboQuestions.Text.Split(' ');
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT qifFormID, qifQuestionID " +
                                          "FROM tblQuestionsInForm " +
                                          "ORDER BY qifFormID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).ToString().Equals(arr[0]) && dataReader.GetInt32(1).ToString().Equals(arr2[0]))
                    {
                        MessageBox.Show("You cant enter the same question more then 1 to a form.");
                        return;
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill questions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string[] arr = comboQuestions.Text.Split(' ');
                string[] arr2 = comboFormID.Text.Split(' ');

                string str = string.Format
                                    ("INSERT INTO tblQuestionsInForm " +
                                     "(qifFormID, qifOrderNum, qifQuestionID) " +
                                     " VALUES ( {0}, {1}, {2})",
                                       arr2[0], orderNum.Text, arr[0]);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblQuestionsInForm ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblQuestionsInForm failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT qifFormID, qifOrderNum " +
                                          "FROM tblQuestionsInForm " +
                                          "ORDER BY qifFormID";
                string[] arr = comboFormID.SelectedItem.ToString().Split(' ');
                int biggestOrderNum = 0;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (arr[0].Equals(dataReader.GetInt32(0).ToString()))
                    {
                        if (biggestOrderNum < dataReader.GetInt32(1))
                        {
                            biggestOrderNum = dataReader.GetInt32(1);
                        }
                    }
                }
                orderNum.Text = (biggestOrderNum + 1).ToString();
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill questions combobox failed \n" + err.Message, "Error",
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
                                     "FROM     tblQuestionsInForm " +
                                     "ORDER BY qifOrderNum";
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

        private void FormIDClosed(object sender, EventArgs e)
        {
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT qifFormID, qifOrderNum " +
                                          "FROM tblQuestionsInForm " +
                                          "ORDER BY qifFormID";
                string[] arr = comboFormID.SelectedItem.ToString().Split(' ');
                int biggestOrderNum = 0;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if(arr[0].Equals(dataReader.GetInt32(0).ToString()))
                    {
                        if(biggestOrderNum < dataReader.GetInt32(1))
                        {
                            biggestOrderNum = dataReader.GetInt32(1);
                        }
                    }
                }
                orderNum.Text = (biggestOrderNum + 1).ToString();
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill questions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
