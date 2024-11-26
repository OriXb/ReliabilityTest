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
    public partial class FormSearchUsers : Form
    {
        private OleDbConnection dataConnection;

        public FormSearchUsers(OleDbConnection dataConnection)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.dataConnection = dataConnection;
        }

        private void FormSearchUsers_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

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
                                     "FROM     tblUsers WHERE " +
                                           "userID        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "userFirstName  LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "userLastName  LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "userAddress   LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "userCity      LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "userPhone     LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "userMail      LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "userPicture   LIKE \"%" + searchStr.Text + "%\" \n" +
                                     "ORDER BY userID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridUsers.DataSource = tbl;
                dataGridUsers.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("SearchTblUsers failed \n" + err.Message, "Error",
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
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridUsers.DataSource = tbl;
                dataGridUsers.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
    
}
