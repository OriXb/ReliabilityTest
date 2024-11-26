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
    public partial class FormUpdateCharacters : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateCharacters(OleDbConnection dataConnection, bool isManager)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            RefreshDataGridView();

        }
        private int scrWidth;
        private int scrHeight;
        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            panel1.Location = new Point((scrWidth - panel1.Size.Width) / 2, panel1.Location.Y);
        }
        private void FormUpdateCharacters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCharacters.tblCharacters' table. You can move, or remove it, as needed.
            this.tblCharactersTableAdapter.Fill(this.dataSetCharacters.tblCharacters);

        }
        private void firstButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void prevButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void nextButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void lastButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows[lastRow].Selected = false;
            lastRow = dataGridView.Rows.Count - 1;
            dataGridView.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
        private void FillSelectedRow()
        {
            try
            {
                charName.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                charDesc.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();

                dataGridView.CurrentCell = dataGridView[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblCharacters   \n" +
                                          "SET    charDesc   =  \"" + charDesc.Text + "\"  \n" +
                                          "WHERE  charName = \"" + charName.Text + "\"  \n";
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView.CurrentCell = dataGridView[0, lastRow];
                MessageBox.Show("Update tblCharacters ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblCharacters failed \n" + err.Message, "Error",
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
                                     "FROM     tblCharacters " +
                                     "ORDER BY charName";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView.DataSource = tbl;
                dataGridView.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblCharacters table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }
    }
}
