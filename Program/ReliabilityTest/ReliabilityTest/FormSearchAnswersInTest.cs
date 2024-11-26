﻿using System;
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
    public partial class FormSearchAnswersInTest : Form
    {

        private void FormSearchAnswersInTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnswersInTest.tblAnswersInTest' table. You can move, or remove it, as needed.
            this.tblAnswersInTestTableAdapter.Fill(this.dataSetAnswersInTest.tblAnswersInTest);

        }
        private OleDbConnection dataConnection;

        public FormSearchAnswersInTest(OleDbConnection dataConnection)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblAnswersInTest WHERE " +
                                           "aitTestID        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "aitOrderNum        LIKE \"%" + searchStr.Text + "%\"  OR \n" +
                                           "aitAnswer   LIKE \"%" + searchStr.Text + "%\" \n" +
                                     "ORDER BY aitTestID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridCharacters.DataSource = tbl;
                dataGridCharacters.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Search failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblAnswersInTest " +
                                     "ORDER BY aitTestID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridCharacters.DataSource = tbl;
                dataGridCharacters.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
