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
    public partial class FormChartQuestionsByTest : Form
    { 

        private OleDbConnection dataConnection;

        private List<string> TestNumbers = new List<string>();
        private List<int> NumberOfQuestions = new List<int>();
        public FormChartQuestionsByTest(OleDbConnection dataConnection)
        {
            WindowState = FormWindowState.Maximized;
            this.dataConnection = dataConnection;
            InitializeComponent();
            FillArrs();
            ShowChart();
            EditDataGridView();
        }
        private void FillArrs()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   testID, testFormID " +
                                          "FROM     tblTests  " +
                                          "ORDER BY testID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    TestNumbers.Add(dataReader.GetInt32(0).ToString());
                    NumberOfQuestions.Add(CountNumberOfQuestions(dataReader.GetInt32(1).ToString()));
                    k++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblSubjects failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CountNumberOfQuestions(string formID)
        {
            try
            {

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT MAX(qifOrderNum) FROM tblQuestionsInForm WHERE qifFormID = " + formID + " ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    return dataReader.GetInt32(0);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("tblQuestionsInForm failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }
        private void EditDataGridView()
        {
            try
            {
                for (int i = 0; i < TestNumbers.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = TestNumbers[i];
                    row.Cells[1].Value = NumberOfQuestions[i].ToString();
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
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
        private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(1, 10);
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                for (int i = 0; i < TestNumbers.Count; i++)
                {
                    chart1.Series["מספר שאלות"].Points.AddXY("מבחן מספר " + TestNumbers[i], NumberOfQuestions[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show chart failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
