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
    public partial class FormTblQuestionsForChar : Form
    {
        public FormTblQuestionsForChar()
        {
            WindowState = FormWindowState.Maximized;

            InitializeComponent();
        }

        private void FormTblQuestionsForChar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQuestionsForChar.tblQuestionsForChar' table. You can move, or remove it, as needed.
            this.tblQuestionsForCharTableAdapter.Fill(this.dataSetQuestionsForChar.tblQuestionsForChar);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetQuestionsForChar changes = (DataSetQuestionsForChar)dataSetQuestionsForChar.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblQuestionsForChar.GetChanges();
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
                int numRows = tblQuestionsForCharTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetQuestionsForChar.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetQuestionsForChar.RejectChanges();
            }
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
    }
    
}
