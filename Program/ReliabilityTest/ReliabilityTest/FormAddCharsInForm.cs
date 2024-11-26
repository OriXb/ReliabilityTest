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
    public partial class FormAddCharsInForm : Form
    {
        private OleDbConnection dataConnection;

        public FormAddCharsInForm(OleDbConnection dataConnection)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillComboChars();
            FillComboForms();
        }

        private void FormAddCharsInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCharsInForm.tblCharsInForm' table. You can move, or remove it, as needed.
            this.tblCharsInFormTableAdapter.Fill(this.dataSetCharsInForm.tblCharsInForm);

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
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void FillComboChars()
        {
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT charName " +
                                          "FROM tblCharacters " +
                                          "ORDER BY charName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    str = dataReader.GetString(0);
                    comboChars.Items.Add(str);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill chars combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string[] arr = comboFormID.Text.Split(' ');
                string str = string.Format
                                    ("INSERT INTO tblCharsInForm " +
                                     "(cifFormID, cifCharName) " +
                                     " VALUES ( {0}, \"{1}\")",
                                       int.Parse(arr[0]), comboChars.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblCharsInForm ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblCharsInForm failed \n" + err.Message, "Error",
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
                                     "FROM     tblCharsInForm " +
                                     "ORDER BY cifFormID";
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
