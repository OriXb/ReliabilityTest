namespace ReliabilityTest
{
    partial class FormAddAnswersInTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aitTestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAnswersInTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAnswersInTest = new ReliabilityTest.DataSetAnswersInTest();
            this.tblAnswersInTestTableAdapter = new ReliabilityTest.DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter();
            this.comboTests = new System.Windows.Forms.ComboBox();
            this.comboOrderNum = new System.Windows.Forms.ComboBox();
            this.comboAnswers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת תשובה במבחן";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 190);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "תשובה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 138);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "מספר סידורי של שאלה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "מספר מבחן:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(284, 240);
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
            this.aitTestIDDataGridViewTextBoxColumn,
            this.aitOrderNumDataGridViewTextBoxColumn,
            this.aitAnswerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAnswersInTestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(728, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(346, 557);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.aitOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי של  שאלה";
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
            this.tblAnswersInTestBindingSource.DataSource = this.dataSetAnswersInTest;
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
            // comboTests
            // 
            this.comboTests.FormattingEnabled = true;
            this.comboTests.Location = new System.Drawing.Point(251, 93);
            this.comboTests.Name = "comboTests";
            this.comboTests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboTests.Size = new System.Drawing.Size(155, 21);
            this.comboTests.TabIndex = 27;
            this.comboTests.Click += new System.EventHandler(this.TestsClick);
            // 
            // comboOrderNum
            // 
            this.comboOrderNum.FormattingEnabled = true;
            this.comboOrderNum.Location = new System.Drawing.Point(163, 140);
            this.comboOrderNum.Name = "comboOrderNum";
            this.comboOrderNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboOrderNum.Size = new System.Drawing.Size(333, 21);
            this.comboOrderNum.TabIndex = 28;
            this.comboOrderNum.Click += new System.EventHandler(this.QuestionsClick);
            // 
            // comboAnswers
            // 
            this.comboAnswers.FormattingEnabled = true;
            this.comboAnswers.Location = new System.Drawing.Point(163, 189);
            this.comboAnswers.Name = "comboAnswers";
            this.comboAnswers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAnswers.Size = new System.Drawing.Size(333, 21);
            this.comboAnswers.TabIndex = 29;
            this.comboAnswers.Click += new System.EventHandler(this.AnswersClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(949, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "טבלת תשובות במבחן";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboAnswers);
            this.panel1.Controls.Add(this.comboOrderNum);
            this.panel1.Controls.Add(this.comboTests);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 633);
            this.panel1.TabIndex = 31;
            // 
            // FormAddAnswersInTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddAnswersInTest";
            this.Text = "FormAddAnswersInTest";
            this.Load += new System.EventHandler(this.FormAddAnswersInTest_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetAnswersInTest dataSetAnswersInTest;
        private System.Windows.Forms.BindingSource tblAnswersInTestBindingSource;
        private DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter tblAnswersInTestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitTestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboTests;
        private System.Windows.Forms.ComboBox comboOrderNum;
        private System.Windows.Forms.ComboBox comboAnswers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}