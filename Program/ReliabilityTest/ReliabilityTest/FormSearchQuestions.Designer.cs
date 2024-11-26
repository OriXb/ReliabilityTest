namespace ReliabilityTest
{
    partial class FormSearchQuestions
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
            this.dataGridQuestions = new System.Windows.Forms.DataGridView();
            this.quesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesAnswersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestions = new ReliabilityTest.DataSetQuestions();
            this.label1 = new System.Windows.Forms.Label();
            this.tblQuestionsTableAdapter = new ReliabilityTest.DataSetQuestionsTableAdapters.tblQuestionsTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.searchStr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridQuestions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 584);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(1003, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "טבלת שאלות";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(507, 470);
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
            // dataGridQuestions
            // 
            this.dataGridQuestions.AutoGenerateColumns = false;
            this.dataGridQuestions.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quesIDDataGridViewTextBoxColumn,
            this.quesTextDataGridViewTextBoxColumn,
            this.quesAnswersDataGridViewTextBoxColumn});
            this.dataGridQuestions.DataSource = this.tblQuestionsBindingSource;
            this.dataGridQuestions.Location = new System.Drawing.Point(26, 180);
            this.dataGridQuestions.Name = "dataGridQuestions";
            this.dataGridQuestions.ReadOnly = true;
            this.dataGridQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridQuestions.Size = new System.Drawing.Size(1056, 268);
            this.dataGridQuestions.TabIndex = 4;
            // 
            // quesIDDataGridViewTextBoxColumn
            // 
            this.quesIDDataGridViewTextBoxColumn.DataPropertyName = "quesID";
            this.quesIDDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.quesIDDataGridViewTextBoxColumn.Name = "quesIDDataGridViewTextBoxColumn";
            this.quesIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quesTextDataGridViewTextBoxColumn
            // 
            this.quesTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quesTextDataGridViewTextBoxColumn.DataPropertyName = "quesText";
            this.quesTextDataGridViewTextBoxColumn.HeaderText = "טקסט שאלה";
            this.quesTextDataGridViewTextBoxColumn.Name = "quesTextDataGridViewTextBoxColumn";
            this.quesTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.quesTextDataGridViewTextBoxColumn.Width = 94;
            // 
            // quesAnswersDataGridViewTextBoxColumn
            // 
            this.quesAnswersDataGridViewTextBoxColumn.DataPropertyName = "quesAnswers";
            this.quesAnswersDataGridViewTextBoxColumn.HeaderText = "מספר תשובות";
            this.quesAnswersDataGridViewTextBoxColumn.Name = "quesAnswersDataGridViewTextBoxColumn";
            this.quesAnswersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblQuestionsBindingSource
            // 
            this.tblQuestionsBindingSource.DataMember = "tblQuestions";
            this.tblQuestionsBindingSource.DataSource = this.dataSetQuestions;
            // 
            // dataSetQuestions
            // 
            this.dataSetQuestions.DataSetName = "DataSetQuestions";
            this.dataSetQuestions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(445, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "חיפוש בטבלת שאלות";
            // 
            // tblQuestionsTableAdapter
            // 
            this.tblQuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(530, 530);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 43);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "רענן ";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormSearchQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormSearchQuestions";
            this.Text = "FormSearchQuestions";
            this.Load += new System.EventHandler(this.FormSearchQuestions_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridQuestions;
        private System.Windows.Forms.Label label1;
        private DataSetQuestions dataSetQuestions;
        private System.Windows.Forms.BindingSource tblQuestionsBindingSource;
        private DataSetQuestionsTableAdapters.tblQuestionsTableAdapter tblQuestionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesAnswersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRefresh;
    }
}