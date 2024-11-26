using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReliabilityTest
{
    public partial class FormTblAnswersInTest : Form
    {
        public FormTblAnswersInTest()
        {
            WindowState = FormWindowState.Maximized;

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormTblAnswersInTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnswersInTest.tblAnswersInTest' table. You can move, or remove it, as needed.
            this.tblAnswersInTestTableAdapter.Fill(this.dataSetAnswersInTest.tblAnswersInTest);

        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            label4.Location = new Point((scrWidth - label4.Size.Width) / 2, label4.Location.Y);
            label3.Location = new Point((scrWidth - label3.Size.Width) / 2, label3.Location.Y);
            dataGridView1.Location = new Point((scrWidth - dataGridView1.Size.Width) / 2, dataGridView1.Location.Y);
            saveButton.Location = new Point((scrWidth - saveButton.Size.Width) / 2, saveButton.Location.Y);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetAnswersInTest changes = (DataSetAnswersInTest)dataSetAnswersInTest.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblAnswersInTest.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                //find the errors and tell the user
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg,
                    "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //no error found, update the database
                int numRows = tblAnswersInTestTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetAnswersInTest.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetAnswersInTest.RejectChanges();
            }

        }
    }
}
