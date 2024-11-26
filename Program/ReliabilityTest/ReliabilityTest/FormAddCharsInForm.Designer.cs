namespace ReliabilityTest
{
    partial class FormAddCharsInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cifFormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifCharNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCharsInFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCharsInFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCharsInForm = new ReliabilityTest.DataSetCharsInForm();
            this.tblCharsInFormTableAdapter = new ReliabilityTest.DataSetCharsInFormTableAdapters.tblCharsInFormTableAdapter();
            this.comboChars = new System.Windows.Forms.ComboBox();
            this.comboFormID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharsInFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharsInFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharsInForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת תכונה בטופס מבחן";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "שם תכונה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 61);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "מספר טופס:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(516, 132);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 45);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cifFormIDDataGridViewTextBoxColumn,
            this.cifCharNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCharsInFormBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(471, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(246, 418);
            this.dataGridView1.TabIndex = 26;
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
            this.tblCharsInFormBindingSource.DataSource = this.dataSetCharsInFormBindingSource;
            // 
            // dataSetCharsInFormBindingSource
            // 
            this.dataSetCharsInFormBindingSource.DataSource = this.dataSetCharsInForm;
            this.dataSetCharsInFormBindingSource.Position = 0;
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
            // comboChars
            // 
            this.comboChars.FormattingEnabled = true;
            this.comboChars.Location = new System.Drawing.Point(483, 96);
            this.comboChars.Name = "comboChars";
            this.comboChars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboChars.Size = new System.Drawing.Size(154, 21);
            this.comboChars.TabIndex = 27;
            // 
            // comboFormID
            // 
            this.comboFormID.FormattingEnabled = true;
            this.comboFormID.Location = new System.Drawing.Point(431, 60);
            this.comboFormID.Name = "comboFormID";
            this.comboFormID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboFormID.Size = new System.Drawing.Size(283, 21);
            this.comboFormID.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(599, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "טבלת תכונות לטופס";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboFormID);
            this.panel1.Controls.Add(this.comboChars);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 647);
            this.panel1.TabIndex = 30;
            // 
            // FormAddCharsInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddCharsInForm";
            this.Text = "FormAddCharsInForm";
            this.Load += new System.EventHandler(this.FormAddCharsInForm_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharsInFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharsInFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharsInForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetCharsInFormBindingSource;
        private DataSetCharsInForm dataSetCharsInForm;
        private System.Windows.Forms.BindingSource tblCharsInFormBindingSource;
        private DataSetCharsInFormTableAdapters.tblCharsInFormTableAdapter tblCharsInFormTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifFormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifCharNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboChars;
        private System.Windows.Forms.ComboBox comboFormID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}