namespace ReliabilityTest
{
    partial class FormTblAnswersInTest
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
            this.aitTestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAnswersInTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAnswersInTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAnswersInTest = new ReliabilityTest.DataSetAnswersInTest();
            this.tblAnswersInTestTableAdapter = new ReliabilityTest.DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "טבלת תשובות במבחנים";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aitTestIDDataGridViewTextBoxColumn,
            this.aitOrderNumDataGridViewTextBoxColumn,
            this.aitAnswerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAnswersInTestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(392, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(345, 514);
            this.dataGridView1.TabIndex = 12;
            // 
            // aitTestIDDataGridViewTextBoxColumn
            // 
            this.aitTestIDDataGridViewTextBoxColumn.DataPropertyName = "aitTestID";
            this.aitTestIDDataGridViewTextBoxColumn.HeaderText = "מספר מבחן";
            this.aitTestIDDataGridViewTextBoxColumn.Name = "aitTestIDDataGridViewTextBoxColumn";
            // 
            // aitOrderNumDataGridViewTextBoxColumn
            // 
            this.aitOrderNumDataGridViewTextBoxColumn.DataPropertyName = "aitOrderNum";
            this.aitOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי של שאלה";
            this.aitOrderNumDataGridViewTextBoxColumn.Name = "aitOrderNumDataGridViewTextBoxColumn";
            // 
            // aitAnswerDataGridViewTextBoxColumn
            // 
            this.aitAnswerDataGridViewTextBoxColumn.DataPropertyName = "aitAnswer";
            this.aitAnswerDataGridViewTextBoxColumn.HeaderText = "תשובה";
            this.aitAnswerDataGridViewTextBoxColumn.Name = "aitAnswerDataGridViewTextBoxColumn";
            // 
            // tblAnswersInTestBindingSource
            // 
            this.tblAnswersInTestBindingSource.DataMember = "tblAnswersInTest";
            this.tblAnswersInTestBindingSource.DataSource = this.dataSetAnswersInTestBindingSource;
            // 
            // dataSetAnswersInTestBindingSource
            // 
            this.dataSetAnswersInTestBindingSource.DataSource = this.dataSetAnswersInTest;
            this.dataSetAnswersInTestBindingSource.Position = 0;
            // 
            // dataSetAnswersInTest
            // 
            this.dataSetAnswersInTest.DataSetName = "DataSetAnswersInTest";
            this.dataSetAnswersInTest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAnswersInTestTableAdapter
            // 
            this.tblAnswersInTestTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(511, 620);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 29);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(600, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "טבלת תשובות במבחנים";
            // 
            // FormTblAnswersInTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "FormTblAnswersInTest";
            this.Text = "FormTblAnswersInTest";
            this.Load += new System.EventHandler(this.FormTblAnswersInTest_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetAnswersInTestBindingSource;
        private DataSetAnswersInTest dataSetAnswersInTest;
        private System.Windows.Forms.BindingSource tblAnswersInTestBindingSource;
        private DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter tblAnswersInTestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitTestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
    }
}