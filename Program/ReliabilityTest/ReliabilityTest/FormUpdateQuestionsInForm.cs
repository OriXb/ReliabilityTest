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
    public partial class FormUpdateQuestionsInForm : Form
    {

        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateQuestionsInForm(OleDbConnection dataConnection, bool isManager)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            RefreshDataGridView();
            FillComboQuestions();
        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
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
        private string SearchForQuestion(int num)
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
                    if(num.Equals(dataReader.GetInt32(0)))
                    {
                        return (dataReader.GetInt32(0) + " - " + dataReader.GetString(1));
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill questions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "error";
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
                    if (dataReader.GetInt32(0).ToString().Equals(testFormID))
                    {
                        return dataReader.GetInt32(0).ToString() + " - " + dataReader.GetString(1);
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

        private void FormUpdateQuestionsInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQuestionsInForm.tblQuestionsInForm' table. You can move, or remove it, as needed.
            this.tblQuestionsInFormTableAdapter.Fill(this.dataSetQuestionsInForm.tblQuestionsInForm);

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
                comboFormID.Text = GetFormName(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                orderNum.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                comboQuestions.Text = SearchForQuestion(int.Parse(dataGridView.SelectedRows[0].Cells[2].Value.ToString()));

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
                string[] arr = comboQuestions.Text.Split(' ');
                string[] arr2 = comboFormID.Text.Split(' ');

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblQuestionsInForm  \n" +
                                          "SET    qifQuestionID   =  \"" + arr[0] + "\"  \n" +
                                          "WHERE  qifFormID = " + arr2[0] +
                                          "AND qifOrderNum = " + orderNum.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView.CurrentCell = dataGridView[0, lastRow];
                MessageBox.Show("Update tblQuestionsInForm ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblQuestionsInForm failed \n" + err.Message, "Error",
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
                                     "ORDER BY qifFormID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView.DataSource = tbl;
                dataGridView.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblUsers table failed \n" + err.Message, "Error",
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
