namespace ReliabilityTest
{
    partial class FormSearchAnswersInTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridCharacters = new System.Windows.Forms.DataGridView();
            this.aitTestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAnswersInTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAnswersInTest = new ReliabilityTest.DataSetAnswersInTest();
            this.label1 = new System.Windows.Forms.Label();
            this.tblAnswersInTestTableAdapter = new ReliabilityTest.DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.searchStr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridCharacters);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 584);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(968, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "טבלת תשובות במבחן";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(507, 467);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 54);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "חפש ";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchStr
            // 
            this.searchStr.Location = new System.Drawing.Point(450, 92);
            this.searchStr.Name = "searchStr";
            this.searchStr.Size = new System.Drawing.Size(143, 20);
            this.searchStr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "מחרוזת לחיפוש";
            // 
            // dataGridCharacters
            // 
            this.dataGridCharacters.AutoGenerateColumns = false;
            this.dataGridCharacters.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aitTestIDDataGridViewTextBoxColumn,
            this.aitOrderNumDataGridViewTextBoxColumn,
            this.aitAnswerDataGridViewTextBoxColumn});
            this.dataGridCharacters.DataSource = this.tblAnswersInTestBindingSource;
            this.dataGridCharacters.Location = new System.Drawing.Point(26, 180);
            this.dataGridCharacters.Name = "dataGridCharacters";
            this.dataGridCharacters.ReadOnly = true;
            this.dataGridCharacters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridCharacters.Size = new System.Drawing.Size(1056, 268);
            this.dataGridCharacters.TabIndex = 4;
            // 
            // aitTestIDDataGridViewTextBoxColumn
            // 
            this.aitTestIDDataGridViewTextBoxColumn.DataPropertyName = "aitTestID";
            this.aitTestIDDataGridViewTextBoxColumn.HeaderText = "מספר מבחן";
            this.aitTestIDDataGridViewTextBoxColumn.Name = "aitTestIDDataGridViewTextBoxColumn";
            this.aitTestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aitOrderNumDataGridViewTextBoxColumn
            // 
            this.aitOrderNumDataGridViewTextBoxColumn.DataPropertyName = "aitOrderNum";
            this.aitOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי של שאלה";
            this.aitOrderNumDataGridViewTextBoxColumn.Name = "aitOrderNumDataGridViewTextBoxColumn";
            this.aitOrderNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aitAnswerDataGridViewTextBoxColumn
            // 
            this.aitAnswerDataGridViewTextBoxColumn.DataPropertyName = "aitAnswer";
            this.aitAnswerDataGridViewTextBoxColumn.HeaderText = "תשובה";
            this.aitAnswerDataGridViewTextBoxColumn.Name = "aitAnswerDataGridViewTextBoxColumn";
            this.aitAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblAnswersInTestBindingSource
            // 
            this.tblAnswersInTestBindingSource.DataMember = "tblAnswersInTest";
            this.tblAnswersInTestBindingSource.DataSource = this.dataSetAnswersInTest;
            // 
            // dataSetAnswersInTest
            // 
            this.dataSetAnswersInTest.DataSetName = "DataSetAnswersInTest";
            this.dataSetAnswersInTest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(412, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "חיפוש בטבלת תשובות במבחן";
            // 
            // tblAnswersInTestTableAdapter
            // 
            this.tblAnswersInTestTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(531, 527);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 43);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "רענן ";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormSearchAnswersInTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormSearchAnswersInTest";
            this.Text = "FormSearchAnswersInTest";
            this.Load += new System.EventHandler(this.FormSearchAnswersInTest_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridCharacters;
        private System.Windows.Forms.Label label1;
        private DataSetAnswersInTest dataSetAnswersInTest;
        private System.Windows.Forms.BindingSource tblAnswersInTestBindingSource;
        private DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter tblAnswersInTestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitTestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRefresh;
    }
}