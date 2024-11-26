namespace ReliabilityTest
{
    partial class FormAddTests
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
            this.label5 = new System.Windows.Forms.Label();
            this.testDate = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testFormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTests = new ReliabilityTest.DataSetTests();
            this.tblTestsTableAdapter = new ReliabilityTest.DataSetTestsTableAdapters.tblTestsTableAdapter();
            this.ComboForms = new System.Windows.Forms.ComboBox();
            this.comboUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTests)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת מבחן";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 96);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ת\"ז של נבחן:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 96);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "מספר טופס:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 144);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "תאריך בחינה:";
            // 
            // testDate
            // 
            this.testDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.testDate.Location = new System.Drawing.Point(189, 146);
            this.testDate.Name = "testDate";
            this.testDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.testDate.Size = new System.Drawing.Size(167, 20);
            this.testDate.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(231, 202);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 45);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testIDDataGridViewTextBoxColumn,
            this.testFormIDDataGridViewTextBoxColumn,
            this.testUserIDDataGridViewTextBoxColumn,
            this.testDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(684, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(450, 557);
            this.dataGridView1.TabIndex = 25;
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "testID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "מספר מבחן";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            // 
            // testFormIDDataGridViewTextBoxColumn
            // 
            this.testFormIDDataGridViewTextBoxColumn.DataPropertyName = "testFormID";
            this.testFormIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.testFormIDDataGridViewTextBoxColumn.Name = "testFormIDDataGridViewTextBoxColumn";
            // 
            // testUserIDDataGridViewTextBoxColumn
            // 
            this.testUserIDDataGridViewTextBoxColumn.DataPropertyName = "testUserID";
            this.testUserIDDataGridViewTextBoxColumn.HeaderText = "תז נבחן";
            this.testUserIDDataGridViewTextBoxColumn.Name = "testUserIDDataGridViewTextBoxColumn";
            // 
            // testDateDataGridViewTextBoxColumn
            // 
            this.testDateDataGridViewTextBoxColumn.DataPropertyName = "testDate";
            this.testDateDataGridViewTextBoxColumn.HeaderText = "תאריך בחינה";
            this.testDateDataGridViewTextBoxColumn.Name = "testDateDataGridViewTextBoxColumn";
            // 
            // tblTestsBindingSource
            // 
            this.tblTestsBindingSource.DataMember = "tblTests";
            this.tblTestsBindingSource.DataSource = this.dataSetTests;
            // 
            // dataSetTests
            // 
            this.dataSetTests.DataSetName = "DataSetTests";
            this.dataSetTests.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTestsTableAdapter
            // 
            this.tblTestsTableAdapter.ClearBeforeFill = true;
            // 
            // ComboForms
            // 
            this.ComboForms.FormattingEnabled = true;
            this.ComboForms.Location = new System.Drawing.Point(353, 95);
            this.ComboForms.Name = "ComboForms";
            this.ComboForms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboForms.Size = new System.Drawing.Size(154, 21);
            this.ComboForms.TabIndex = 26;
            // 
            // comboUsers
            // 
            this.comboUsers.FormattingEnabled = true;
            this.comboUsers.Location = new System.Drawing.Point(37, 95);
            this.comboUsers.Name = "comboUsers";
            this.comboUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboUsers.Size = new System.Drawing.Size(209, 21);
            this.comboUsers.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(1050, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "טבלת מבחנים";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboUsers);
            this.panel1.Controls.Add(this.ComboForms);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.testDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 654);
            this.panel1.TabIndex = 29;
            // 
            // FormAddTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddTests";
            this.Text = "FormAddTests";
            this.Load += new System.EventHandler(this.FormAddTests_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker testDate;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetTests dataSetTests;
        private System.Windows.Forms.BindingSource tblTestsBindingSource;
        private DataSetTestsTableAdapters.tblTestsTableAdapter tblTestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testFormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ComboForms;
        private System.Windows.Forms.ComboBox comboUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}