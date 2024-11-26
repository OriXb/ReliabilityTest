namespace ReliabilityTest
{
    partial class FormUpdateQuestions
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
            this.quesText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.quesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesAnswersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestions = new ReliabilityTest.DataSetQuestions();
            this.tblQuestionsTableAdapter = new ReliabilityTest.DataSetQuestionsTableAdapters.tblQuestionsTableAdapter();
            this.quesID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboAnswers
            // 
            this.comboAnswers.FormattingEnabled = true;
            this.comboAnswers.Location = new System.Drawing.Point(453, 130);
            this.comboAnswers.Name = "comboAnswers";
            this.comboAnswers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAnswers.Size = new System.Drawing.Size(171, 21);
            this.comboAnswers.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 131);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "מספר תשובות:";
            // 
            // quesText
            // 
            this.quesText.Location = new System.Drawing.Point(209, 96);
            this.quesText.Name = "quesText";
            this.quesText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quesText.Size = new System.Drawing.Size(633, 20);
            this.quesText.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(848, 96);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "טקטס שאלה:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "עדכון שאלה";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(511, 234);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(113, 47);
            this.buttonUpdate.TabIndex = 61;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(654, 176);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 39);
            this.buttonFirst.TabIndex = 60;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.firstButtonClick);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(379, 176);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(87, 39);
            this.buttonLast.TabIndex = 59;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.lastButtonClick);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(470, 176);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 39);
            this.buttonNext.TabIndex = 58;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.nextButtonClick);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(577, 176);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(73, 39);
            this.buttonPrev.TabIndex = 57;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.prevButtonClick);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quesIDDataGridViewTextBoxColumn,
            this.quesTextDataGridViewTextBoxColumn,
            this.quesAnswersDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tblQuestionsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(388, 319);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(346, 299);
            this.dataGridView.TabIndex = 62;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // quesIDDataGridViewTextBoxColumn
            // 
            this.quesIDDataGridViewTextBoxColumn.DataPropertyName = "quesID";
            this.quesIDDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.quesIDDataGridViewTextBoxColumn.Name = "quesIDDataGridViewTextBoxColumn";
            this.quesIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quesTextDataGridViewTextBoxColumn
            // 
            this.quesTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quesTextDataGridViewTextBoxColumn.DataPropertyName = "quesText";
            this.quesTextDataGridViewTextBoxColumn.HeaderText = "טקסט שאלה";
            this.quesTextDataGridViewTextBoxColumn.Name = "quesTextDataGridViewTextBoxColumn";
            this.quesTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.quesTextDataGridViewTextBoxColumn.Width = 94;
            // 
            // quesAnswersDataGridViewTextBoxColumn
            // 
            this.quesAnswersDataGridViewTextBoxColumn.DataPropertyName = "quesAnswers";
            this.quesAnswersDataGridViewTextBoxColumn.HeaderText = "מספר תשובות";
            this.quesAnswersDataGridViewTextBoxColumn.Name = "quesAnswersDataGridViewTextBoxColumn";
            this.quesAnswersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblQuestionsBindingSource
            // 
            this.tblQuestionsBindingSource.DataMember = "tblQuestions";
            this.tblQuestionsBindingSource.DataSource = this.dataSetQuestions;
            // 
            // dataSetQuestions
            // 
            this.dataSetQuestions.DataSetName = "DataSetQuestions";
            this.dataSetQuestions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQuestionsTableAdapter
            // 
            this.tblQuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // quesID
            // 
            this.quesID.Enabled = false;
            this.quesID.Location = new System.Drawing.Point(453, 61);
            this.quesID.Name = "quesID";
            this.quesID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quesID.Size = new System.Drawing.Size(171, 20);
            this.quesID.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 59);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "מספר שאלה:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(655, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "טבלת שאלות";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.quesID);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.comboAnswers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.quesText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 638);
            this.panel1.TabIndex = 66;
            // 
            // FormUpdateQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdateQuestions";
            this.Text = "FormUpdateQuestions";
            this.Load += new System.EventHandler(this.FormUpdateQuestions_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quesText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataSetQuestions dataSetQuestions;
        private System.Windows.Forms.BindingSource tblQuestionsBindingSource;
        private DataSetQuestionsTableAdapters.tblQuestionsTableAdapter tblQuestionsTableAdapter;
        private System.Windows.Forms.TextBox quesID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAnswers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesAnswersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}