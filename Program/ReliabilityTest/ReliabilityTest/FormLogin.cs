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
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        private bool enter = false;
        public FormLogin()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            OpenDb();
        }

        private void OpenDb()
        {
            dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2023\\Project_OriBurg\\Access\\dbReliabilityTest.accdb";
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database: " +
                e.Message,
                "Errors",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            String line, password;
            bool isManager;
            int id;
            
            try
            {
                if (!IsIdValid(idNumber.Text))
                {
                    MessageBox.Show("User ID is not valid");
                    return;
                }
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT userID, userPassword, userIsAdmin, userFirstName, userLastName, userPicture " +
                 "FROM tblUsers " + "WHERE userID = " + this.idNumber.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                password = dataReader.GetString(1);
                isManager = dataReader.GetBoolean(2);
                if (password == this.passwordText.Text)
                {
                    if(enter == false)
                    {
                        name.Text = "ברוך הבא: " + dataReader.GetString(3) + " " + dataReader.GetString(4);
                        pictureBox.ImageLocation = dataReader.GetString(5);
                        checkButton.Text = "המשך";
                        idNumber.Enabled = false;
                        passwordText.Enabled = false;
                        enter = true;
                    }
                    else
                    {
                        idNumber.Enabled = true;
                        passwordText.Enabled = true;
                        enter = false;
                        name.Text = "";
                        checkButton.Text = "כניסה";
                        pictureBox.ImageLocation = null;

                        this.Hide();
                        FormMenu frMenu = new FormMenu(dataConnection, isManager, idNumber.Text);
                        frMenu.Show();
                        frMenu.Disposed += new EventHandler(frMenu_Disposed);
                    }  
                }
                else
                {
                    line = "Invalid password: " + this.passwordText.Text;
                    MessageBox.Show(line, "Error");
                }
            }
            catch (Exception err)
            {
                line = "Invalid id: " + this.idNumber.Text + err.Message;
                MessageBox.Show(line, "Error");
            }
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
        void frMenu_Disposed(object sender, EventArgs e)
        {
            this.idNumber.Text = "";
            this.passwordText.Text = "";
            this.Show();
            this.Activate();
        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            label1.Location = new Point((scrWidth - label1.Size.Width) / 2 +60, label1.Location.Y);
            label2.Location = new Point((scrWidth - label2.Size.Width) / 2 +60, label2.Location.Y);
            label3.Location = new Point((scrWidth - label3.Size.Width) / 2, label3.Location.Y);
            passwordText.Location = new Point((scrWidth - passwordText.Size.Width) / 2-30, passwordText.Location.Y);
            idNumber.Location = new Point((scrWidth - idNumber.Size.Width) / 2 -30, idNumber.Location.Y);
            checkButton.Location = new Point((scrWidth - checkButton.Size.Width) / 2, checkButton.Location.Y);
            pictureBox.Location = new Point((scrWidth - pictureBox.Size.Width) / 2, pictureBox.Location.Y);
            name.Location = new Point((scrWidth - name.Size.Width) / 2 - 80, name.Location.Y);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }
    }
}
