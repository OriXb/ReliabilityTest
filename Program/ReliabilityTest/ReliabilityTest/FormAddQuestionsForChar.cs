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
    public partial class FormAddQuestionsForChar : Form
    {
        private OleDbConnection dataConnection;
        public FormAddQuestionsForChar(OleDbConnection dataConnection)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillComboQuestions();
            FillComboChars();
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
        private void FillComboQuestions()                                   
        {
            try
            {
                string str;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT quesID, quesText " +
                                          "FROM tblQuestions " +
                                          "ORDER BY quesID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                   str = dataReader.GetInt32(0).ToString() + " - " + dataReader.GetString(1);
                   comboQuestions.Items.Add(str);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill questions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillComboFromValue()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT quesID, quesAnswers " +
                                          "FROM tblQuestions " +
                                          "ORDER BY quesID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                string[] arr = comboQuestions.Text.Split(' ');
                while (dataReader.Read())
                {
                    if(arr[0] == dataReader.GetInt32(0).ToString())
                    {
                        for (int i = 1; i <= dataReader.GetInt32(1); i++)
                        {
                            comboFromValue.Items.Add(i);
                        }
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill from value combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillComboToValue()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT quesID, quesAnswers " +
                                          "FROM tblQuestions " +
                                          "ORDER BY quesID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                string[] arr = comboQuestions.Text.Split(' ');
                while (dataReader.Read())
                {
                    if (arr[0] == dataReader.GetInt32(0).ToString())
                    {
                        for (int i = int.Parse(comboFromValue.Text); i <= dataReader.GetInt32(1); i++)
                        {
                            comboToValue.Items.Add(i);
                        }
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill to value combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddQuestionsForChar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQuestionsForChar.tblQuestionsForChar' table. You can move, or remove it, as needed.
            this.tblQuestionsForCharTableAdapter.Fill(this.dataSetQuestionsForChar.tblQuestionsForChar);

        }
        
        private void AddButton(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string[] arr = comboQuestions.Text.Split(' ');
                string str = string.Format
                                    ("INSERT INTO tblQuestionsForChar " +
                                     "(qfcCharName, qfcCharOrder, qfcFromValue, qfcToValue) " +
                                     " VALUES (  \"{0}\", {1}, {2}, {3})",
                                       comboChars.Text, arr[0], comboFromValue.Text, comboToValue.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblQuestionsForChar ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblQuestionsForChar failed \n" + err.Message, "Error",
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
                                     "FROM     tblQuestionsForChar " +
                                     "ORDER BY qfcCharName";
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

        private void FromValueClick(object sender, EventArgs e)
        {
            comboToValue.Text = "";
            comboFromValue.Items.Clear();
            if (comboQuestions.Text != "")
            {   
                FillComboFromValue();
            }
        }

        private void ToValueClick(object sender, EventArgs e)
        {
            comboToValue.Items.Clear();
            if (comboFromValue.Text != "")
            { 
                FillComboToValue();
            }
        }

        private void QuestionsClick(object sender, EventArgs e)
        {
            comboToValue.Text = "";
            comboFromValue.Text = "";
        }
    }
}
