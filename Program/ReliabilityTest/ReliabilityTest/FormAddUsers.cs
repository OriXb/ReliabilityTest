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
   
    public partial class FormAddUsers : Form
    {
        private OleDbConnection dataConnection;

        public FormAddUsers(OleDbConnection dataConnection)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCityCombo();


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
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void browseClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog2.ShowDialog();
            string pictureFileName = openFileDialog2.FileName;
            pictureBox.ImageLocation = pictureFileName;
            pictureUser.Text = pictureFileName;
        }

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }
        static bool IsIdValid(string str)
        {
            int[] arr = new int[9];
            int k = 8;
            int sum = 0;
            int num;
            if (str.Length > 9 || !int.TryParse(str, out num))
                return false;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                arr[k] = str[i] - '0';
                k--;
            }
            for (int i = 1; i < 9; i = i + 2)
            {
                arr[i] = arr[i] * 2;
                arr[i] = arr[i] / 10 + arr[i] % 10;
                sum = sum + arr[i] + arr[i - 1];
            }

            int bikoret = sum / 10 * 10;
            if (bikoret < sum)
                bikoret = bikoret + 10;
            bikoret = bikoret - sum;
            return arr[8] == bikoret;
        }
        private void AddButton(object sender, EventArgs e)
        {
            try
            {
                if (!IsIdValid(idUser.Text))
                {
                    MessageBox.Show("User ID is not valid");
                    return;
                }
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblUsers " +
                                     "(userID, userFirstName, userLastName, userBirthDate, userAddress, userCity, userPhone, userMail, userPassword, userIsAdmin, userPicture) " +
                                     " VALUES ( \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", {9}, \"{10}\")",
                                       idUser.Text, firstNameUser.Text, lastNameUser.Text, birthDateUser.Text,
                                       addressUser.Text, cityUser.Text, phoneUser.Text, mailUser.Text, passwordUser.Text, false, pictureUser.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblUsers ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblUsers failed \n" + err.Message, "Error",
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
