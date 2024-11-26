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
    public partial class FormUpdateUsers : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;

        public FormUpdateUsers(OleDbConnection dataConnection, bool isManager)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            FillCityCombo();
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
        private void FillCityCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cityUser.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void browseClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox.ImageLocation = pictureFileName;
            pictureUser.Text = pictureFileName;
        }

        private void FormUpdateUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }

        private void firstButtonClick(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridViewUsers.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void prevButtonClick(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridViewUsers.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void nextButtonClick(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridViewUsers.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void lastButtonClick(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows[lastRow].Selected = false;
            lastRow = dataGridViewUsers.Rows.Count - 1;
            dataGridViewUsers.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
        private void FillSelectedRow()
        {
            try
            {
                idUser.Text = dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString();
                firstNameUser.Text = dataGridViewUsers.SelectedRows[0].Cells[1].Value.ToString();
                lastNameUser.Text = dataGridViewUsers.SelectedRows[0].Cells[2].Value.ToString();
                birthDateUser.Text = dataGridViewUsers.SelectedRows[0].Cells[3].Value.ToString();
                addressUser.Text = dataGridViewUsers.SelectedRows[0].Cells[4].Value.ToString();
                cityUser.Text = dataGridViewUsers.SelectedRows[0].Cells[5].Value.ToString();
                phoneUser.Text = dataGridViewUsers.SelectedRows[0].Cells[6].Value.ToString();
                mailUser.Text = dataGridViewUsers.SelectedRows[0].Cells[7].Value.ToString();
                passwordUser.Text = dataGridViewUsers.SelectedRows[0].Cells[8].Value.ToString();
                isUserManager.Checked = dataGridViewUsers.SelectedRows[0].Cells[9].Value.ToString() == "True";
                pictureUser.Text = dataGridViewUsers.SelectedRows[0].Cells[10].Value.ToString();
                pictureBox.ImageLocation = pictureUser.Text;
                dataGridViewUsers.CurrentCell = dataGridViewUsers[0, lastRow];
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
            if (lastRow == dataGridViewUsers.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblUsers  \n" +
                                          "SET    userFirstName   =  \"" + firstNameUser.Text + "\" , \n" +
                                                  "userLastName   =  \"" + lastNameUser.Text + "\" , \n" +
                                                  "userBirthDate  =  \"" + birthDateUser.Text + "\" , \n" +
                                                  "userAddress    =  \"" + addressUser.Text + "\" , \n" +
                                                  "userCity       =  \"" + cityUser.Text + "\" , \n" +
                                                  "userPhone      =  \"" + phoneUser.Text + "\" , \n" +
                                                  "userMail       =  \"" + mailUser.Text + "\" , \n" +
                                                  "userPassword   =  \"" + passwordUser.Text + "\" , \n" +
                                                  "userIsAdmin    =    " + isUserManager.Checked + " , \n" +
                                                  "userPicture    =  \"" + pictureUser.Text + "\"  \n" +
                                          "WHERE  userID = " + idUser.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridViewUsers.CurrentCell = dataGridViewUsers[0, lastRow];
                MessageBox.Show("Update tblUsers ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblUsers failed \n" + err.Message, "Error",
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
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridViewUsers.DataSource = tbl;
                dataGridViewUsers.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblUsers table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridViewUsers.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }
    }
}
