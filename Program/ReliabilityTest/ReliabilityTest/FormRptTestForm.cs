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

    public partial class FormRptTestForm : Form
    {
        private OleDbConnection dataConnection;
        private string saveColor = "";

        private string formID;
        private string formName;
        private string QuesText;
        private string QuesChar;
        private string QuesFromValue;
        private string QuesToValue;

        public FormRptTestForm(OleDbConnection dataConnection, bool isManager)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
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
        private void FormRptTestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForms.tblForms' table. You can move, or remove it, as needed.
            this.tblFormsTableAdapter.Fill(this.dataSetForms.tblForms);

        }

        private void ShowReportButton(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (GetFormChars(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) == "")
            { charLabel.Text = "לטופס זה אין שום תכונות מוגדרות"; }
            else { charLabel.Text = "תכונות הטופס: " + GetFormChars(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()); }
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   formID, formName " +
                                          "FROM     tblForms   " +
                                          "WHERE    formID = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " " +
                                          "ORDER BY formID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    formID = dataReader.GetInt32(0).ToString();
                    formName = dataReader.GetString(1);
                    GetQuestion();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblForms failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFormChars(string formID)
        {
            try
            {
                string str = "";
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   cifCharName " +
                                          "FROM     tblCharsInForm   " +
                                          "WHERE    cifFormID = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " " +
                                          "ORDER BY cifCharName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    str = str + dataReader.GetString(0) + ", ";
                }
                dataReader.Close();
                if(str.Length == 0) { return ""; }
                return str.Substring(0, str.Length - 2);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblCharInForms failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "ERROR";
        }
        private void GetQuestion()
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qifQuestionID " +
                                          "FROM     tblQuestionsInForm   " +
                                          "WHERE    qifFormID = " + formID + " " +
                                          "ORDER BY qifQuestionID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    QuesText = dataReader.GetInt32(0) + " - " + GetQuesText(dataReader.GetInt32(0));
                    string[] charInfo = GetQuesChar(dataReader.GetInt32(0)).Split('|');
                    QuesChar = charInfo[0];
                    QuesFromValue = charInfo[1];
                    QuesToValue = charInfo[2];
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetQuestion failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetQuesText(int quesID)
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT   quesText " +
                                      "FROM     tblQuestions   " +
                                      "WHERE    quesID = " + quesID + " " +
                                      "ORDER BY quesText";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                return dataReader.GetString(0);
            }
            dataReader.Close();
            return "Error";

        }
        private string GetQuesChar(int quesID)
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT   qfcCharName, qfcFromValue, qfcToValue " +
                                      "FROM     tblQuestionsForChar   " +
                                      "WHERE    qfcCharOrder = " + quesID + " " +
                                      "ORDER BY qfcCharName";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                return dataReader.GetString(0) + "|" + dataReader.GetInt32(1) + "|" + dataReader.GetInt32(2);
            }
            dataReader.Close();
            return "Error";

        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[6];
                if (counter == 1)
                {
                    arr[0] = formID;
                    arr[1] = formName;
                }
                arr[2] = QuesText;
                arr[3] = QuesChar;
                arr[4] = QuesFromValue;
                arr[5] = QuesToValue;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectColorButton(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor.BackColor = cd.Color;
            saveColor = buttonColor.BackColor.ToArgb().ToString();
        }

        private void ClearReportButton(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            charLabel.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
