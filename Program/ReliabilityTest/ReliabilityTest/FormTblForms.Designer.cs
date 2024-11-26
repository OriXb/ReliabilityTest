namespace ReliabilityTest
{
    partial class FormTblForms
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
            this.formIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formCreatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFormsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForms = new ReliabilityTest.DataSetForms();
            this.tblFormsTableAdapter = new ReliabilityTest.DataSetFormsTableAdapters.tblFormsTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "טבלת טפסים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formIDDataGridViewTextBoxColumn,
            this.formNameDataGridViewTextBoxColumn,
            this.formDateDataGridViewTextBoxColumn,
            this.formCreatorIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFormsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(363, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(446, 507);
            this.dataGridView1.TabIndex = 13;
            // 
            // formIDDataGridViewTextBoxColumn
            // 
            this.formIDDataGridViewTextBoxColumn.DataPropertyName = "formID";
            this.formIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.formIDDataGridViewTextBoxColumn.Name = "formIDDataGridViewTextBoxColumn";
            // 
            // formNameDataGridViewTextBoxColumn
            // 
            this.formNameDataGridViewTextBoxColumn.DataPropertyName = "formName";
            this.formNameDataGridViewTextBoxColumn.HeaderText = "שם מבחן";
            this.formNameDataGridViewTextBoxColumn.Name = "formNameDataGridViewTextBoxColumn";
            // 
            // formDateDataGridViewTextBoxColumn
            // 
            this.formDateDataGridViewTextBoxColumn.DataPropertyName = "formDate";
            this.formDateDataGridViewTextBoxColumn.HeaderText = "תאריך יצירה";
            this.formDateDataGridViewTextBoxColumn.Name = "formDateDataGridViewTextBoxColumn";
            // 
            // formCreatorIDDataGridViewTextBoxColumn
            // 
            this.formCreatorIDDataGridViewTextBoxColumn.DataPropertyName = "formCreatorID";
            this.formCreatorIDDataGridViewTextBoxColumn.HeaderText = "תז יוצר";
            this.formCreatorIDDataGridViewTextBoxColumn.Name = "formCreatorIDDataGridViewTextBoxColumn";
            // 
            // tblFormsBindingSource
            // 
            this.tblFormsBindingSource.DataMember = "tblForms";
            this.tblFormsBindingSource.DataSource = this.dataSetForms;
            // 
            // dataSetForms
            // 
            this.dataSetForms.DataSetName = "DataSetForms";
            this.dataSetForms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFormsTableAdapter
            // 
            this.tblFormsTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(542, 623);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 29);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(730, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "טבלת טפסים";
            // 
            // FormTblForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "FormTblForms";
            this.Text = "FormTblForms";
            this.Load += new System.EventHandler(this.FormTblForms_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetForms dataSetForms;
        private System.Windows.Forms.BindingSource tblFormsBindingSource;
        private DataSetFormsTableAdapters.tblFormsTableAdapter tblFormsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formCreatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
    }
}