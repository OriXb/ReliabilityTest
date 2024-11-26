namespace ReliabilityTest
{
    partial class FormAddQuestions
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
            this.quesText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesAnswersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestions = new ReliabilityTest.DataSetQuestions();
            this.tblQuestionsTableAdapter = new ReliabilityTest.DataSetQuestionsTableAdapters.tblQuestionsTableAdapter();
            this.comboAnswers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת שאלה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(663, 106);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "מספר תשובות:";
            // 
            // quesText
            // 
            this.quesText.Location = new System.Drawing.Point(242, 71);
            this.quesText.Name = "quesText";
            this.quesText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quesText.Size = new System.Drawing.Size(633, 20);
            this.quesText.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(881, 71);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "טקטס שאלה:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(526, 161);
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
            this.quesIDDataGridViewTextBoxColumn,
            this.quesTextDataGridViewTextBoxColumn,
            this.quesAnswersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblQuestionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(231, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(749, 395);
            this.dataGridView1.TabIndex = 26;
            // 
            // quesIDDataGridViewTextBoxColumn
            // 
            this.quesIDDataGridViewTextBoxColumn.DataPropertyName = "quesID";
            this.quesIDDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.quesIDDataGridViewTextBoxColumn.Name = "quesIDDataGridViewTextBoxColumn";
            // 
            // quesTextDataGridViewTextBoxColumn
            // 
            this.quesTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quesTextDataGridViewTextBoxColumn.DataPropertyName = "quesText";
            this.quesTextDataGridViewTextBoxColumn.HeaderText = "טקסט שאלה";
            this.quesTextDataGridViewTextBoxColumn.Name = "quesTextDataGridViewTextBoxColumn";
            this.quesTextDataGridViewTextBoxColumn.Width = 94;
            // 
            // quesAnswersDataGridViewTextBoxColumn
            // 
            this.quesAnswersDataGridViewTextBoxColumn.DataPropertyName = "quesAnswers";
            this.quesAnswersDataGridViewTextBoxColumn.HeaderText = "מספר תשובות";
            this.quesAnswersDataGridViewTextBoxColumn.Name = "quesAnswersDataGridViewTextBoxColumn";
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
            // comboAnswers
            // 
            this.comboAnswers.FormattingEnabled = true;
            this.comboAnswers.Location = new System.Drawing.Point(486, 105);
            this.comboAnswers.Name = "comboAnswers";
            this.comboAnswers.Size = new System.Drawing.Size(171, 21);
            this.comboAnswers.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(901, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "טבלת שאלות";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboAnswers);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.quesText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 641);
            this.panel1.TabIndex = 29;
            // 
            // FormAddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddQuestions";
            this.Text = "FormAddQuestions";
            this.Load += new System.EventHandler(this.FormAddQuestions_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quesText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetQuestions dataSetQuestions;
        private System.Windows.Forms.BindingSource tblQuestionsBindingSource;
        private DataSetQuestionsTableAdapters.tblQuestionsTableAdapter tblQuestionsTableAdapter;
        private System.Windows.Forms.ComboBox comboAnswers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesAnswersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}