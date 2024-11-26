namespace ReliabilityTest
{
    partial class FormAddForms
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FormDate = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.formIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formCreatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFormsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForms = new ReliabilityTest.DataSetForms();
            this.tblFormsTableAdapter = new ReliabilityTest.DataSetFormsTableAdapters.tblFormsTableAdapter();
            this.comboUsers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת טופס";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 72);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ת\"ז יוצר:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 72);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "תאריך יצירה:";
            // 
            // formName
            // 
            this.formName.Location = new System.Drawing.Point(809, 74);
            this.formName.Name = "formName";
            this.formName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.formName.Size = new System.Drawing.Size(145, 20);
            this.formName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(960, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "שם מבחן:";
            // 
            // FormDate
            // 
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FormDate.Location = new System.Drawing.Point(505, 74);
            this.FormDate.Name = "FormDate";
            this.FormDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FormDate.Size = new System.Drawing.Size(167, 20);
            this.FormDate.TabIndex = 19;
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
            this.formIDDataGridViewTextBoxColumn,
            this.formNameDataGridViewTextBoxColumn,
            this.formDateDataGridViewTextBoxColumn,
            this.formCreatorIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFormsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(370, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(450, 435);
            this.dataGridView1.TabIndex = 26;
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
            // comboUsers
            // 
            this.comboUsers.FormattingEnabled = true;
            this.comboUsers.Location = new System.Drawing.Point(100, 72);
            this.comboUsers.Name = "comboUsers";
            this.comboUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboUsers.Size = new System.Drawing.Size(292, 21);
            this.comboUsers.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(741, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "טבלת טפסים";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboUsers);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.FormDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.formName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 643);
            this.panel1.TabIndex = 29;
            // 
            // FormAddForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddForms";
            this.Text = "FormAddForms";
            this.Load += new System.EventHandler(this.FormAddForms_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FormDate;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetForms dataSetForms;
        private System.Windows.Forms.BindingSource tblFormsBindingSource;
        private DataSetFormsTableAdapters.tblFormsTableAdapter tblFormsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formCreatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}