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
    public partial class FormSearchQuestions : Form
    {
        private OleDbConnection dataConnection;

        public FormSearchQuestions(OleDbConnection dataConnection)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.dataConnection = dataConnection;
        }

        private void FormSearchQuestions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQuestions.tblQuestions' table. You can move, or remove it, as needed.
            this.tblQuestionsTableAdapter.Fill(this.dataSetQuestions.tblQuestions);

        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblQuestions WHERE " +
                                           "quesID        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "quesText  LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "quesAnswers   LIKE \"%" + searchStr.Text + "%\" \n" +
                                     "ORDER BY quesID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridQuestions.DataSource = tbl;
                dataGridQuestions.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Search failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblQuestions " +
                                     "ORDER BY quesID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridQuestions.DataSource = tbl;
                dataGridQuestions.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}
