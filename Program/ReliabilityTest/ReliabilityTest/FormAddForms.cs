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
    public partial class FormAddForms : Form
    {
        private OleDbConnection dataConnection;
        public FormAddForms(OleDbConnection dataConnection)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillComboCreatorID();
        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void FillComboCreatorID()
        {
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT userID, userFirstName, userLastName " +
                                          "FROM tblUsers " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    str = dataReader.GetInt32(0).ToString() + " - " + dataReader.GetString(1) + " " + dataReader.GetString(2);
                    comboUsers.Items.Add(str);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill users combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForms.tblForms' table. You can move, or remove it, as needed.
            this.tblFormsTableAdapter.Fill(this.dataSetForms.tblForms);

        }

        private void AddButton(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string[] arr = comboUsers.Text.Split(' ');
                string str = string.Format
                                    ("INSERT INTO tblForms " +
                                     "(formName, formDate, formCreatorID) " +
                                     " VALUES (  \"{0}\", \"{1}\", {2})",
                                     formName.Text, FormDate.Text, arr[0]);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblForms ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblForms failed \n" + err.Message, "Error",
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
                                     "FROM     tblForms " +
                                     "ORDER BY formID";
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
    }
}
