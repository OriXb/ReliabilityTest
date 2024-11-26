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

    public partial class FormTestExamination : Form
    {
        private OleDbConnection dataConnection;
        private bool userChosed;
        private bool formChosed;
        private int testSpeed;
        public FormTestExamination(OleDbConnection dataConnection, bool isManager)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void FormTestExamination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForms.tblForms' table. You can move, or remove it, as needed.
            this.tblFormsTableAdapter.Fill(this.dataSetForms.tblForms);
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            label1.Location = new Point((scrWidth - label1.Size.Width) / 2, label1.Location.Y);
            label2.Location = new Point((scrWidth - label2.Size.Width) / 2, label2.Location.Y);
            label4.Location = new Point((scrWidth - label4.Size.Width) / 2, label4.Location.Y);
            label3.Location = new Point((scrWidth - label3.Size.Width) / 2, label3.Location.Y);
            dataGridView2.Location = new Point((scrWidth - dataGridView2.Size.Width) / 2, dataGridView2.Location.Y);
            dataGridView1.Location = new Point((scrWidth - dataGridView1.Size.Width) / 2, dataGridView1.Location.Y);
            startButton.Location = new Point((scrWidth - startButton.Size.Width) / 2, startButton.Location.Y);
            groupBox1.Location = new Point((scrWidth - groupBox1.Size.Width) / 2, groupBox1.Location.Y);

        }
        private void CreateTestClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;

                DateTime now = DateTime.Now;


                string str = string.Format
                                    ("INSERT INTO tblTests " +
                                     "(testFormID, testUserID, testDate) " +
                                     " VALUES ( {0}, {1}, \"{2}\")",
                                       dataGridView2.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), now.Date);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Start test failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int testNumber = CurrentCreatedTest();

            string userID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string formID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            string[] data = GetUserData(userID);
            this.Hide();
            if(radioButton1.Checked) { testSpeed = 5; } else if (radioButton2.Checked){ testSpeed = 10; } else { testSpeed = 15; }
            FormTestExaminationProcess frTestExaminationProcess = new FormTestExaminationProcess(dataConnection, userID, data[0], data[1], data[2], formID, testNumber.ToString(), testSpeed);
            frTestExaminationProcess.Show();
            frTestExaminationProcess.Disposed += new EventHandler(Form_Disposed);
        }
        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private string[] GetUserData(string userID)
        {
            try
            {
                string[] arr = new string[3];
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName, userPicture " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userID = " + userID + " ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();

                dataReader.Read();
                    arr[0] = dataReader.GetString(0);
                    arr[1] = dataReader.GetString(1);
                    arr[2] = dataReader.GetString(2);
                dataReader.Close();
                return arr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private int CurrentCreatedTest()
        {
            try
            {

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT MAX(testID) FROM tblTests ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    return dataReader.GetInt32(0);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("QuestionsForCharNumber failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        private void UserChosed(object sender, DataGridViewCellEventArgs e)
        {
            userChosed = true;
            if (userChosed && formChosed)
            {
                startButton.Enabled = true;
            }
        }

        private void FormChosed(object sender, DataGridViewCellEventArgs e)
        {
            formChosed = true;
            if (userChosed && formChosed)
            {
                startButton.Enabled = true;
            }

        }
    }
}
