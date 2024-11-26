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
    public partial class FormSearchForms : Form
    {
        private OleDbConnection dataConnection;

        public FormSearchForms(OleDbConnection dataConnection)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.dataConnection = dataConnection;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblForms WHERE " +
                                           "formID        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "formDate        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "formCreatorID        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "formName   LIKE \"%" + searchStr.Text + "%\" \n" +
                                     "ORDER BY formID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridForms.DataSource = tbl;
                dataGridForms.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Search failed \n" + err.Message, "Error",
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
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblForms " +
                                     "ORDER BY formID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridForms.DataSource = tbl;
                dataGridForms.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormSearchForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForms.tblForms' table. You can move, or remove it, as needed.
            this.tblFormsTableAdapter.Fill(this.dataSetForms.tblForms);

        }
    }
}
