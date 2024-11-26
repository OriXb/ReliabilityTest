namespace ReliabilityTest
{
    partial class FormTblQuestionsForChar
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
            this.tblQuestionsForCharBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsForChar = new ReliabilityTest.DataSetQuestionsForChar();
            this.tblQuestionsForCharTableAdapter = new ReliabilityTest.DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qfcCharNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcCharOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcFromValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcToValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsForCharBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsForCharBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForCharBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "טבלת שאלות לתכונות";
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
            // tblQuestionsForCharTableAdapter
            // 
            this.tblQuestionsForCharTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(543, 620);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 29);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qfcCharNameDataGridViewTextBoxColumn,
            this.qfcCharOrderDataGridViewTextBoxColumn,
            this.qfcFromValueDataGridViewTextBoxColumn,
            this.qfcToValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblQuestionsForCharBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(383, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(447, 500);
            this.dataGridView1.TabIndex = 19;
            // 
            // qfcCharNameDataGridViewTextBoxColumn
            // 
            this.qfcCharNameDataGridViewTextBoxColumn.DataPropertyName = "qfcCharName";
            this.qfcCharNameDataGridViewTextBoxColumn.HeaderText = "שם תכונה";
            this.qfcCharNameDataGridViewTextBoxColumn.Name = "qfcCharNameDataGridViewTextBoxColumn";
            // 
            // qfcCharOrderDataGridViewTextBoxColumn
            // 
            this.qfcCharOrderDataGridViewTextBoxColumn.DataPropertyName = "qfcCharOrder";
            this.qfcCharOrderDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.qfcCharOrderDataGridViewTextBoxColumn.Name = "qfcCharOrderDataGridViewTextBoxColumn";
            // 
            // qfcFromValueDataGridViewTextBoxColumn
            // 
            this.qfcFromValueDataGridViewTextBoxColumn.DataPropertyName = "qfcFromValue";
            this.qfcFromValueDataGridViewTextBoxColumn.HeaderText = "ערך התחלה";
            this.qfcFromValueDataGridViewTextBoxColumn.Name = "qfcFromValueDataGridViewTextBoxColumn";
            // 
            // qfcToValueDataGridViewTextBoxColumn
            // 
            this.qfcToValueDataGridViewTextBoxColumn.DataPropertyName = "qfcToValue";
            this.qfcToValueDataGridViewTextBoxColumn.HeaderText = "ערך סיום";
            this.qfcToValueDataGridViewTextBoxColumn.Name = "qfcToValueDataGridViewTextBoxColumn";
            // 
            // tblQuestionsForCharBindingSource1
            // 
            this.tblQuestionsForCharBindingSource1.DataMember = "tblQuestionsForChar";
            this.tblQuestionsForCharBindingSource1.DataSource = this.dataSetQuestionsForCharBindingSource;
            // 
            // dataSetQuestionsForCharBindingSource
            // 
            this.dataSetQuestionsForCharBindingSource.DataSource = this.dataSetQuestionsForChar;
            this.dataSetQuestionsForCharBindingSource.Position = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(704, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "טבלת שאלות לתכונות";
            // 
            // FormTblQuestionsForChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Name = "FormTblQuestionsForChar";
            this.Text = "FormTblQuestionsForChar";
            this.Load += new System.EventHandler(this.FormTblQuestionsForChar_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForCharBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DataSetQuestionsForChar dataSetQuestionsForChar;
        private System.Windows.Forms.BindingSource tblQuestionsForCharBindingSource;
        private DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter tblQuestionsForCharTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfeCharNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcCharNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcCharOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcFromValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcToValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblQuestionsForCharBindingSource1;
        private System.Windows.Forms.BindingSource dataSetQuestionsForCharBindingSource;
        private System.Windows.Forms.Label label4;
    }
}