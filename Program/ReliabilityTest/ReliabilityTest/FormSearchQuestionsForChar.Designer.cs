namespace ReliabilityTest
{
    partial class FormSearchQuestionsForChar
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
            this.qfcCharNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcCharOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcFromValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcToValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsForCharBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsForChar = new ReliabilityTest.DataSetQuestionsForChar();
            this.label1 = new System.Windows.Forms.Label();
            this.tblQuestionsForCharTableAdapter = new ReliabilityTest.DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(967, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "טבלת שאלות לתכונה";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(507, 472);
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
            this.qfcCharNameDataGridViewTextBoxColumn,
            this.qfcCharOrderDataGridViewTextBoxColumn,
            this.qfcFromValueDataGridViewTextBoxColumn,
            this.qfcToValueDataGridViewTextBoxColumn});
            this.dataGridCharacters.DataSource = this.tblQuestionsForCharBindingSource;
            this.dataGridCharacters.Location = new System.Drawing.Point(26, 180);
            this.dataGridCharacters.Name = "dataGridCharacters";
            this.dataGridCharacters.ReadOnly = true;
            this.dataGridCharacters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridCharacters.Size = new System.Drawing.Size(1056, 268);
            this.dataGridCharacters.TabIndex = 4;
            // 
            // qfcCharNameDataGridViewTextBoxColumn
            // 
            this.qfcCharNameDataGridViewTextBoxColumn.DataPropertyName = "qfcCharName";
            this.qfcCharNameDataGridViewTextBoxColumn.HeaderText = "שם תכונה";
            this.qfcCharNameDataGridViewTextBoxColumn.Name = "qfcCharNameDataGridViewTextBoxColumn";
            this.qfcCharNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qfcCharOrderDataGridViewTextBoxColumn
            // 
            this.qfcCharOrderDataGridViewTextBoxColumn.DataPropertyName = "qfcCharOrder";
            this.qfcCharOrderDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.qfcCharOrderDataGridViewTextBoxColumn.Name = "qfcCharOrderDataGridViewTextBoxColumn";
            this.qfcCharOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qfcFromValueDataGridViewTextBoxColumn
            // 
            this.qfcFromValueDataGridViewTextBoxColumn.DataPropertyName = "qfcFromValue";
            this.qfcFromValueDataGridViewTextBoxColumn.HeaderText = "ערך התחלה";
            this.qfcFromValueDataGridViewTextBoxColumn.Name = "qfcFromValueDataGridViewTextBoxColumn";
            this.qfcFromValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qfcToValueDataGridViewTextBoxColumn
            // 
            this.qfcToValueDataGridViewTextBoxColumn.DataPropertyName = "qfcToValue";
            this.qfcToValueDataGridViewTextBoxColumn.HeaderText = "ערך סיום";
            this.qfcToValueDataGridViewTextBoxColumn.Name = "qfcToValueDataGridViewTextBoxColumn";
            this.qfcToValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblQuestionsForCharBindingSource
            // 
            this.tblQuestionsForCharBindingSource.DataMember = "tblQuestionsForChar";
            this.tblQuestionsForCharBindingSource.DataSource = this.dataSetQuestionsForChar;
            // 
            // dataSetQuestionsForChar
            // 
            this.dataSetQuestionsForChar.DataSetName = "DataSetQuestionsForChar";
            this.dataSetQuestionsForChar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(426, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "חיפוש בטבלת שאלות לתכונה";
            // 
            // tblQuestionsForCharTableAdapter
            // 
            this.tblQuestionsForCharTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(530, 532);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 43);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "רענן ";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormSearchQuestionsForChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormSearchQuestionsForChar";
            this.Text = "FormSearchQuestionsForChar";
            this.Load += new System.EventHandler(this.FormSearchQuestionsForChar_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).EndInit();
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
        private DataSetQuestionsForChar dataSetQuestionsForChar;
        private System.Windows.Forms.BindingSource tblQuestionsForCharBindingSource;
        private DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter tblQuestionsForCharTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcCharNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcCharOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcFromValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcToValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRefresh;
    }
}