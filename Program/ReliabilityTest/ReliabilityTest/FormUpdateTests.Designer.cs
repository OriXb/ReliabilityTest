namespace ReliabilityTest
{
    partial class FormUpdateTests
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
            this.comboUsers = new System.Windows.Forms.ComboBox();
            this.ComboForms = new System.Windows.Forms.ComboBox();
            this.testDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testNumber = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testFormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTests = new ReliabilityTest.DataSetTests();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.tblTestsTableAdapter = new ReliabilityTest.DataSetTestsTableAdapters.tblTestsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTests)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboUsers
            // 
            this.comboUsers.FormattingEnabled = true;
            this.comboUsers.Location = new System.Drawing.Point(292, 105);
            this.comboUsers.Name = "comboUsers";
            this.comboUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboUsers.Size = new System.Drawing.Size(209, 21);
            this.comboUsers.TabIndex = 34;
            // 
            // ComboForms
            // 
            this.ComboForms.FormattingEnabled = true;
            this.ComboForms.Location = new System.Drawing.Point(608, 105);
            this.ComboForms.Name = "ComboForms";
            this.ComboForms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboForms.Size = new System.Drawing.Size(154, 21);
            this.ComboForms.TabIndex = 33;
            // 
            // testDate
            // 
            this.testDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.testDate.Location = new System.Drawing.Point(444, 156);
            this.testDate.Name = "testDate";
            this.testDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.testDate.Size = new System.Drawing.Size(167, 20);
            this.testDate.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(617, 154);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "תאריך בחינה:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 106);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "ת\"ז של נבחן:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(768, 106);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "מספר טופס:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "עדכון מבחן";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "מספר מבחן:";
            // 
            // testNumber
            // 
            this.testNumber.Enabled = false;
            this.testNumber.Location = new System.Drawing.Point(444, 63);
            this.testNumber.Name = "testNumber";
            this.testNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.testNumber.Size = new System.Drawing.Size(154, 20);
            this.testNumber.TabIndex = 36;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testIDDataGridViewTextBoxColumn,
            this.testFormIDDataGridViewTextBoxColumn,
            this.testUserIDDataGridViewTextBoxColumn,
            this.testDateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tblTestsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(351, 337);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(454, 306);
            this.dataGridView.TabIndex = 68;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "testID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "מספר מבחן";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testFormIDDataGridViewTextBoxColumn
            // 
            this.testFormIDDataGridViewTextBoxColumn.DataPropertyName = "testFormID";
            this.testFormIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.testFormIDDataGridViewTextBoxColumn.Name = "testFormIDDataGridViewTextBoxColumn";
            this.testFormIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testUserIDDataGridViewTextBoxColumn
            // 
            this.testUserIDDataGridViewTextBoxColumn.DataPropertyName = "testUserID";
            this.testUserIDDataGridViewTextBoxColumn.HeaderText = "תז של נבחן";
            this.testUserIDDataGridViewTextBoxColumn.Name = "testUserIDDataGridViewTextBoxColumn";
            this.testUserIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testDateDataGridViewTextBoxColumn
            // 
            this.testDateDataGridViewTextBoxColumn.DataPropertyName = "testDate";
            this.testDateDataGridViewTextBoxColumn.HeaderText = "תאריך בחינה";
            this.testDateDataGridViewTextBoxColumn.Name = "testDateDataGridViewTextBoxColumn";
            this.testDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(518, 259);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(113, 47);
            this.buttonUpdate.TabIndex = 67;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(661, 201);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 39);
            this.buttonFirst.TabIndex = 66;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.firstButtonClick);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(386, 201);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(87, 39);
            this.buttonLast.TabIndex = 65;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.lastButtonClick);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(477, 201);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 39);
            this.buttonNext.TabIndex = 64;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.nextButtonClick);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(584, 201);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(73, 39);
            this.buttonPrev.TabIndex = 63;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.prevButtonClick);
            // 
            // tblTestsTableAdapter
            // 
            this.tblTestsTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(721, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "טבלת מבחנים";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.testNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboUsers);
            this.panel1.Controls.Add(this.ComboForms);
            this.panel1.Controls.Add(this.testDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 653);
            this.panel1.TabIndex = 73;
            // 
            // FormUpdateTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdateTests";
            this.Text = "FormUpdateTests";
            this.Load += new System.EventHandler(this.FormUpdateTests_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUsers;
        private System.Windows.Forms.ComboBox ComboForms;
        private System.Windows.Forms.DateTimePicker testDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testNumber;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private DataSetTests dataSetTests;
        private System.Windows.Forms.BindingSource tblTestsBindingSource;
        private DataSetTestsTableAdapters.tblTestsTableAdapter tblTestsTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testFormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}