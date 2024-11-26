namespace ReliabilityTest
{
    partial class FormTblQuestionsInForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qifFormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qifOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qifQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsInFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsInForm = new ReliabilityTest.DataSetQuestionsInForm();
            this.saveButton = new System.Windows.Forms.Button();
            this.tblQuestionsInFormTableAdapter = new ReliabilityTest.DataSetQuestionsInFormTableAdapters.tblQuestionsInFormTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsInForm)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "טבלת שאלות בטופס";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qifFormIDDataGridViewTextBoxColumn,
            this.qifOrderNumDataGridViewTextBoxColumn,
            this.qifQuestionID});
            this.dataGridView1.DataSource = this.tblQuestionsInFormBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(451, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 503);
            this.dataGridView1.TabIndex = 13;
            // 
            // qifFormIDDataGridViewTextBoxColumn
            // 
            this.qifFormIDDataGridViewTextBoxColumn.DataPropertyName = "qifFormID";
            this.qifFormIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.qifFormIDDataGridViewTextBoxColumn.Name = "qifFormIDDataGridViewTextBoxColumn";
            // 
            // qifOrderNumDataGridViewTextBoxColumn
            // 
            this.qifOrderNumDataGridViewTextBoxColumn.DataPropertyName = "qifOrderNum";
            this.qifOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי של שאלה";
            this.qifOrderNumDataGridViewTextBoxColumn.Name = "qifOrderNumDataGridViewTextBoxColumn";
            // 
            // qifQuestionID
            // 
            this.qifQuestionID.DataPropertyName = "qifQuestionID";
            this.qifQuestionID.HeaderText = "מספר שאלה";
            this.qifQuestionID.Name = "qifQuestionID";
            // 
            // tblQuestionsInFormBindingSource
            // 
            this.tblQuestionsInFormBindingSource.DataMember = "tblQuestionsInForm";
            this.tblQuestionsInFormBindingSource.DataSource = this.dataSetQuestionsInForm;
            // 
            // dataSetQuestionsInForm
            // 
            this.dataSetQuestionsInForm.DataSetName = "DataSetQuestionsInForm";
            this.dataSetQuestionsInForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(574, 623);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 29);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // tblQuestionsInFormTableAdapter
            // 
            this.tblQuestionsInFormTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(680, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "טבלת שאלות בטופס";
            // 
            // FormTblQuestionsInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "FormTblQuestionsInForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormTblQuestionsInForm";
            this.Load += new System.EventHandler(this.FormTblQuestionsInForm_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsInForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetQuestionsInForm dataSetQuestionsInForm;
        private System.Windows.Forms.BindingSource tblQuestionsInFormBindingSource;
        private DataSetQuestionsInFormTableAdapters.tblQuestionsInFormTableAdapter tblQuestionsInFormTableAdapter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifFormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifQuestionID;
        private System.Windows.Forms.Label label4;
    }
}