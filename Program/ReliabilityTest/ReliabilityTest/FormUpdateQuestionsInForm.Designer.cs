namespace ReliabilityTest
{
    partial class FormUpdateQuestionsInForm
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
            this.comboQuestions = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblQuestionsInFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsInForm = new ReliabilityTest.DataSetQuestionsInForm();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.tblQuestionsInFormTableAdapter = new ReliabilityTest.DataSetQuestionsInFormTableAdapters.tblQuestionsInFormTableAdapter();
            this.comboFormID = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.qifFormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qifOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qifQuestionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsInFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsInForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboQuestions
            // 
            this.comboQuestions.FormattingEnabled = true;
            this.comboQuestions.Location = new System.Drawing.Point(333, 130);
            this.comboQuestions.Name = "comboQuestions";
            this.comboQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboQuestions.Size = new System.Drawing.Size(429, 21);
            this.comboQuestions.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(767, 131);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "מספר שאלה:";
            // 
            // orderNum
            // 
            this.orderNum.Enabled = false;
            this.orderNum.Location = new System.Drawing.Point(312, 86);
            this.orderNum.Name = "orderNum";
            this.orderNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderNum.Size = new System.Drawing.Size(145, 20);
            this.orderNum.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 86);
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
            this.label2.Location = new System.Drawing.Point(824, 86);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "מספר טופס:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "עדכון שאלה בטופס מבחן";
            // 
            // tblQuestionsInFormBindingSource
            // 
            this.tblQuestionsInFormBindingSource.DataMember = "tblQuestionsInForm";
            this.tblQuestionsInFormBindingSource.DataSource = this.dataSetQuestionsInForm;
            // 
            // dataSetQuestionsInForm
            // 
            this.dataSetQuestionsInForm.DataSetName = "DataSetQuestionsInForm";
            this.dataSetQuestionsInForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(551, 238);
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
            this.buttonFirst.Location = new System.Drawing.Point(694, 180);
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
            this.buttonLast.Location = new System.Drawing.Point(419, 180);
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
            this.buttonNext.Location = new System.Drawing.Point(510, 180);
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
            this.buttonPrev.Location = new System.Drawing.Point(617, 180);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(73, 39);
            this.buttonPrev.TabIndex = 63;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.prevButtonClick);
            // 
            // tblQuestionsInFormTableAdapter
            // 
            this.tblQuestionsInFormTableAdapter.ClearBeforeFill = true;
            // 
            // comboFormID
            // 
            this.comboFormID.Enabled = false;
            this.comboFormID.Location = new System.Drawing.Point(649, 86);
            this.comboFormID.Name = "comboFormID";
            this.comboFormID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboFormID.Size = new System.Drawing.Size(169, 20);
            this.comboFormID.TabIndex = 69;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qifFormIDDataGridViewTextBoxColumn,
            this.qifOrderNumDataGridViewTextBoxColumn,
            this.qifQuestionIDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tblQuestionsInFormBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(419, 310);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(364, 326);
            this.dataGridView.TabIndex = 70;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // qifFormIDDataGridViewTextBoxColumn
            // 
            this.qifFormIDDataGridViewTextBoxColumn.DataPropertyName = "qifFormID";
            this.qifFormIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.qifFormIDDataGridViewTextBoxColumn.Name = "qifFormIDDataGridViewTextBoxColumn";
            this.qifFormIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qifOrderNumDataGridViewTextBoxColumn
            // 
            this.qifOrderNumDataGridViewTextBoxColumn.DataPropertyName = "qifOrderNum";
            this.qifOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי של שאלה";
            this.qifOrderNumDataGridViewTextBoxColumn.Name = "qifOrderNumDataGridViewTextBoxColumn";
            this.qifOrderNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qifQuestionIDDataGridViewTextBoxColumn
            // 
            this.qifQuestionIDDataGridViewTextBoxColumn.DataPropertyName = "qifQuestionID";
            this.qifQuestionIDDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.qifQuestionIDDataGridViewTextBoxColumn.Name = "qifQuestionIDDataGridViewTextBoxColumn";
            this.qifQuestionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblQuestionsInFormBindingSource1
            // 
            this.tblQuestionsInFormBindingSource1.DataMember = "tblQuestionsInForm";
            this.tblQuestionsInFormBindingSource1.DataSource = this.dataSetQuestionsInForm;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(664, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "טבלת שאלות בטופס";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.comboFormID);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.comboQuestions);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.orderNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 645);
            this.panel1.TabIndex = 72;
            // 
            // FormUpdateQuestionsInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdateQuestionsInForm";
            this.Text = "FormUpdateQuestionsInForm";
            this.Load += new System.EventHandler(this.FormUpdateQuestionsInForm_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsInForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private DataSetQuestionsInForm dataSetQuestionsInForm;
        private System.Windows.Forms.BindingSource tblQuestionsInFormBindingSource;
        private DataSetQuestionsInFormTableAdapters.tblQuestionsInFormTableAdapter tblQuestionsInFormTableAdapter;
        private System.Windows.Forms.TextBox comboFormID;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource tblQuestionsInFormBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifFormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifQuestionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}