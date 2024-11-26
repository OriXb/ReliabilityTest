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
    public partial class FormChartQuestionsByPropertiy : Form
    {

        private OleDbConnection dataConnection;

        private List<string> CharNames = new List<string>();
        private List<int> NumberOfQuestions = new List<int>();
        public FormChartQuestionsByPropertiy(OleDbConnection dataConnection)
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
                datacommand.CommandText = "SELECT   charName " +
                                          "FROM     tblCharacters  " +
                                          "ORDER BY charName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    CharNames.Add(dataReader.GetString(0));
                    NumberOfQuestions.Add(CountNumberOfQuestions(dataReader.GetString(0)));
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
        private int CountNumberOfQuestions(string charName)
        {
            try
            {
                int x = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   qfcCharOrder " +
                                          "FROM     tblQuestionsForChar   " +
                                          "WHERE    qfcCharName = \"" + charName + "\"  " +
                                          "ORDER BY qfcCharOrder";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while(dataReader.Read())
                {
                    x++;
                }
                dataReader.Close();
                return x;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblQuestionsForChar failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }
        private void EditDataGridView()
        {
            try
            {
                for (int i = 0; i < CharNames.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = CharNames[i];
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

                for (int i = 0; i < CharNames.Count; i++)
                {
                    chart1.Series["מספר שאלות"].Points.AddXY(CharNames[i], NumberOfQuestions[i]);
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
