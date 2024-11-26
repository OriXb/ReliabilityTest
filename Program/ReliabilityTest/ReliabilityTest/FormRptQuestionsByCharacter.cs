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
    public partial class FormRptQuestionsByCharacter : Form
    {
        private OleDbConnection dataConnection;
        private string saveColor = "";

        private string charName;
        private string QuesNumber;
        private string QuesText;
        private string QuesAnswers;
        private string QuesFromValue;
        private string QuesToValue;

        public FormRptQuestionsByCharacter(OleDbConnection dataConnection, bool isManager)
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
        private void FormRptQuestionsByCharacter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCharacters.tblCharacters' table. You can move, or remove it, as needed.
            this.tblCharactersTableAdapter.Fill(this.dataSetCharacters.tblCharacters);

        }
        private void ShowReportButton(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qfcCharOrder, qfcFromValue, qfcToValue " +
                                          "FROM     tblQuestionsForChar   " +
                                          "WHERE    qfcCharName = \"" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "\"  " +
                                          "ORDER BY qfcCharOrder";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                charName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                while (dataReader.Read())
                {
                    counter++;
                    string[] s = GetQuesTextAndAnswers(dataReader.GetInt32(0).ToString());
                    QuesText = s[0];
                    QuesNumber = dataReader.GetInt32(0).ToString();
                    QuesAnswers = s[1];
                    QuesFromValue = dataReader.GetInt32(1).ToString();
                    QuesToValue = dataReader.GetInt32(2).ToString();
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsForChar failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string[] GetQuesTextAndAnswers(string quesID)
        {
            string[] arr = new string[2];
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT   quesText, quesAnswers " +
                                      "FROM     tblQuestions   " +
                                      "WHERE    quesID = " + quesID + " " +
                                      "ORDER BY quesText";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                arr[0] = dataReader.GetString(0);
                arr[1] = dataReader.GetInt32(1).ToString();
                return arr;
            }
            dataReader.Close();
            return arr;
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[6];

                if (counter == 1)
                { arr[0] = charName; }
                arr[1] = QuesNumber;
                arr[2] = QuesText;
                arr[3] = QuesAnswers;
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
        }
    }
}
