namespace ReliabilityTest
{
    partial class FormTblQuestions
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataSetQuestions = new ReliabilityTest.DataSetQuestions();
            this.tblQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQuestionsTableAdapter = new ReliabilityTest.DataSetQuestionsTableAdapters.tblQuestionsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.quesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesAnswersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "טבלת שאלות";
            // 
            // dataSetQuestions
            // 
            this.dataSetQuestions.DataSetName = "DataSetQuestions";
            this.dataSetQuestions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQuestionsBindingSource
            // 
            this.tblQuestionsBindingSource.DataMember = "tblQuestions";
            this.tblQuestionsBindingSource.DataSource = this.dataSetQuestions;
            // 
            // tblQuestionsTableAdapter
            // 
            this.tblQuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quesIDDataGridViewTextBoxColumn,
            this.quesTextDataGridViewTextBoxColumn,
            this.quesAnswersDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblQuestionsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(422, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(346, 505);
            this.dataGridView2.TabIndex = 14;
            // 
            // quesIDDataGridViewTextBoxColumn
            // 
            this.quesIDDataGridViewTextBoxColumn.DataPropertyName = "quesID";
            this.quesIDDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.quesIDDataGridViewTextBoxColumn.Name = "quesIDDataGridViewTextBoxColumn";
            // 
            // quesTextDataGridViewTextBoxColumn
            // 
            this.quesTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quesTextDataGridViewTextBoxColumn.DataPropertyName = "quesText";
            this.quesTextDataGridViewTextBoxColumn.HeaderText = "טקסט שאלה";
            this.quesTextDataGridViewTextBoxColumn.Name = "quesTextDataGridViewTextBoxColumn";
            this.quesTextDataGridViewTextBoxColumn.Width = 94;
            // 
            // quesAnswersDataGridViewTextBoxColumn
            // 
            this.quesAnswersDataGridViewTextBoxColumn.DataPropertyName = "quesAnswers";
            this.quesAnswersDataGridViewTextBoxColumn.HeaderText = "מספר תשובות";
            this.quesAnswersDataGridViewTextBoxColumn.Name = "quesAnswersDataGridViewTextBoxColumn";
            // 
            // tblQuestionsBindingSource1
            // 
            this.tblQuestionsBindingSource1.DataMember = "tblQuestions";
            this.tblQuestionsBindingSource1.DataSource = this.dataSetQuestions;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(541, 620);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 29);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(689, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "טבלת שאלות";
            // 
            // FormTblQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Name = "FormTblQuestions";
            this.Text = "FormTblQuestions";
            this.Load += new System.EventHandler(this.FormTblQuestions_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DataSetQuestions dataSetQuestions;
        private System.Windows.Forms.BindingSource tblQuestionsBindingSource;
        private DataSetQuestionsTableAdapters.tblQuestionsTableAdapter tblQuestionsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblQuestionsBindingSource1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesAnswersDataGridViewTextBoxColumn;
    }
}