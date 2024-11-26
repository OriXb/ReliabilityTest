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
    public partial class FormSearchQuestionsForChar : Form
    {
        private OleDbConnection dataConnection;

        public FormSearchQuestionsForChar(OleDbConnection dataConnection)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.dataConnection = dataConnection;
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
                                     "FROM     tblQuestionsForChar WHERE " +
                                           "qfcCharName        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "qfcCharOrder        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "qfcFromValue        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "qfcToValue   LIKE \"%" + searchStr.Text + "%\" \n" +
                                     "ORDER BY qfcCharName";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridCharacters.DataSource = tbl;
                dataGridCharacters.AllowUserToAddRows = false;
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
                                     "FROM     tblQuestionsForChar " +
                                     "ORDER BY qfcCharName";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridCharacters.DataSource = tbl;
                dataGridCharacters.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormSearchQuestionsForChar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQuestionsForChar.tblQuestionsForChar' table. You can move, or remove it, as needed.
            this.tblQuestionsForCharTableAdapter.Fill(this.dataSetQuestionsForChar.tblQuestionsForChar);

        }
    }
}
