namespace ReliabilityTest
{
    partial class FormUpdateAnswersInTest
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
            this.comboAnswers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testID = new System.Windows.Forms.TextBox();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.aitTestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAnswersInTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAnswersInTest = new ReliabilityTest.DataSetAnswersInTest();
            this.tblAnswersInTestTableAdapter = new ReliabilityTest.DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboAnswers
            // 
            this.comboAnswers.FormattingEnabled = true;
            this.comboAnswers.Location = new System.Drawing.Point(382, 142);
            this.comboAnswers.Name = "comboAnswers";
            this.comboAnswers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAnswers.Size = new System.Drawing.Size(333, 21);
            this.comboAnswers.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 143);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "תשובה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(720, 102);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "מספר סידורי של שאלה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "מספר מבחן:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "עדכון תשובה במבחן";
            // 
            // testID
            // 
            this.testID.Enabled = false;
            this.testID.Location = new System.Drawing.Point(459, 65);
            this.testID.Name = "testID";
            this.testID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.testID.Size = new System.Drawing.Size(166, 20);
            this.testID.TabIndex = 38;
            // 
            // orderNum
            // 
            this.orderNum.Enabled = false;
            this.orderNum.Location = new System.Drawing.Point(382, 102);
            this.orderNum.Name = "orderNum";
            this.orderNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderNum.Size = new System.Drawing.Size(334, 20);
            this.orderNum.TabIndex = 39;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aitTestIDDataGridViewTextBoxColumn,
            this.aitOrderNumDataGridViewTextBoxColumn,
            this.aitAnswerDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tblAnswersInTestBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(400, 331);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(364, 314);
            this.dataGridView.TabIndex = 63;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // aitTestIDDataGridViewTextBoxColumn
            // 
            this.aitTestIDDataGridViewTextBoxColumn.DataPropertyName = "aitTestID";
            this.aitTestIDDataGridViewTextBoxColumn.HeaderText = "מספר מבחן";
            this.aitTestIDDataGridViewTextBoxColumn.Name = "aitTestIDDataGridViewTextBoxColumn";
            this.aitTestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aitOrderNumDataGridViewTextBoxColumn
            // 
            this.aitOrderNumDataGridViewTextBoxColumn.DataPropertyName = "aitOrderNum";
            this.aitOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי של שאלה";
            this.aitOrderNumDataGridViewTextBoxColumn.Name = "aitOrderNumDataGridViewTextBoxColumn";
            this.aitOrderNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aitAnswerDataGridViewTextBoxColumn
            // 
            this.aitAnswerDataGridViewTextBoxColumn.DataPropertyName = "aitAnswer";
            this.aitAnswerDataGridViewTextBoxColumn.HeaderText = "תשובה";
            this.aitAnswerDataGridViewTextBoxColumn.Name = "aitAnswerDataGridViewTextBoxColumn";
            this.aitAnswerDataGridViewTextBoxColumn.ReadOnly = true;
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
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(532, 245);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(113, 47);
            this.buttonUpdate.TabIndex = 68;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(675, 187);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 39);
            this.buttonFirst.TabIndex = 67;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.firstButtonClick);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(400, 187);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(87, 39);
            this.buttonLast.TabIndex = 66;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.lastButtonClick);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(491, 187);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 39);
            this.buttonNext.TabIndex = 65;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.nextButtonClick);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(598, 187);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(73, 39);
            this.buttonPrev.TabIndex = 64;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.prevButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(627, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "טבלת תשובות במבחנים";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.orderNum);
            this.panel1.Controls.Add(this.testID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboAnswers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 653);
            this.panel1.TabIndex = 70;
            // 
            // FormUpdateAnswersInTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdateAnswersInTest";
            this.Text = "FormUpdateAnswersInTest";
            this.Load += new System.EventHandler(this.FormUpdateAnswersInTest_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnswersInTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnswersInTest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAnswers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox testID;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataSetAnswersInTest dataSetAnswersInTest;
        private System.Windows.Forms.BindingSource tblAnswersInTestBindingSource;
        private DataSetAnswersInTestTableAdapters.tblAnswersInTestTableAdapter tblAnswersInTestTableAdapter;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitTestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}