namespace ReliabilityTest
{
    partial class FormTblCharsInForm
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
            this.cifFormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifCharNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCharsInFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCharsInForm = new ReliabilityTest.DataSetCharsInForm();
            this.tblCharsInFormTableAdapter = new ReliabilityTest.DataSetCharsInFormTableAdapters.tblCharsInFormTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharsInFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharsInForm)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "טבלת תכונות בטפסים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cifFormIDDataGridViewTextBoxColumn,
            this.cifCharNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCharsInFormBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(448, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(245, 505);
            this.dataGridView1.TabIndex = 13;
            // 
            // cifFormIDDataGridViewTextBoxColumn
            // 
            this.cifFormIDDataGridViewTextBoxColumn.DataPropertyName = "cifFormID";
            this.cifFormIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.cifFormIDDataGridViewTextBoxColumn.Name = "cifFormIDDataGridViewTextBoxColumn";
            // 
            // cifCharNameDataGridViewTextBoxColumn
            // 
            this.cifCharNameDataGridViewTextBoxColumn.DataPropertyName = "cifCharName";
            this.cifCharNameDataGridViewTextBoxColumn.HeaderText = "שם תכונה";
            this.cifCharNameDataGridViewTextBoxColumn.Name = "cifCharNameDataGridViewTextBoxColumn";
            // 
            // tblCharsInFormBindingSource
            // 
            this.tblCharsInFormBindingSource.DataMember = "tblCharsInForm";
            this.tblCharsInFormBindingSource.DataSource = this.dataSetCharsInForm;
            // 
            // dataSetCharsInForm
            // 
            this.dataSetCharsInForm.DataSetName = "DataSetCharsInForm";
            this.dataSetCharsInForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCharsInFormTableAdapter
            // 
            this.tblCharsInFormTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(525, 622);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 29);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(566, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "טבלת תכונות בטפסים";
            // 
            // FormTblCharsInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "FormTblCharsInForm";
            this.Text = "FormTblCharsInForm";
            this.Load += new System.EventHandler(this.FormTblCharsInForm_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharsInFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharsInForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetCharsInForm dataSetCharsInForm;
        private System.Windows.Forms.BindingSource tblCharsInFormBindingSource;
        private DataSetCharsInFormTableAdapters.tblCharsInFormTableAdapter tblCharsInFormTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifFormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifCharNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
    }
}