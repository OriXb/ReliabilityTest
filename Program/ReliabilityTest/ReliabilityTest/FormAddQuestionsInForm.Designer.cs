namespace ReliabilityTest
{
    partial class FormAddQuestionsInForm
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
            this.qifFormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qifOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qifQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsInFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsInForm = new ReliabilityTest.DataSetQuestionsInForm();
            this.tblQuestionsInFormTableAdapter = new ReliabilityTest.DataSetQuestionsInFormTableAdapters.tblQuestionsInFormTableAdapter();
            this.comboQuestions = new System.Windows.Forms.ComboBox();
            this.comboFormID = new System.Windows.Forms.ComboBox();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsInForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת שאלה בטופס מבחן";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 153);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "מספר שאלה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 108);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "מספר סידורי של שאלה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 108);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "מספר טופס:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(314, 216);
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
            this.qifFormIDDataGridViewTextBoxColumn,
            this.qifOrderNumDataGridViewTextBoxColumn,
            this.qifQuestionID});
            this.dataGridView1.DataSource = this.tblQuestionsInFormBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(765, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(363, 565);
            this.dataGridView1.TabIndex = 26;
            // 
            // qifFormIDDataGridViewTextBoxColumn
            // 
            this.qifFormIDDataGridViewTextBoxColumn.DataPropertyName = "qifFormID";
            this.qifFormIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.qifFormIDDataGridViewTextBoxColumn.Name = "qifFormIDDataGridViewTextBoxColumn";
            // 
            // qifOrderNumDataGridViewTextBoxColumn
            // 
            this.qifOrderNumDataGridViewTextBoxColumn.DataPropertyName = "qifOrderNum";
            this.qifOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי של שאלה";
            this.qifOrderNumDataGridViewTextBoxColumn.Name = "qifOrderNumDataGridViewTextBoxColumn";
            // 
            // qifQuestionID
            // 
            this.qifQuestionID.DataPropertyName = "qifQuestionID";
            this.qifQuestionID.HeaderText = "מספר שאלה";
            this.qifQuestionID.Name = "qifQuestionID";
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
            // tblQuestionsInFormTableAdapter
            // 
            this.tblQuestionsInFormTableAdapter.ClearBeforeFill = true;
            // 
            // comboQuestions
            // 
            this.comboQuestions.FormattingEnabled = true;
            this.comboQuestions.Location = new System.Drawing.Point(130, 152);
            this.comboQuestions.Name = "comboQuestions";
            this.comboQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboQuestions.Size = new System.Drawing.Size(429, 21);
            this.comboQuestions.TabIndex = 27;
            // 
            // comboFormID
            // 
            this.comboFormID.FormattingEnabled = true;
            this.comboFormID.Location = new System.Drawing.Point(428, 110);
            this.comboFormID.Name = "comboFormID";
            this.comboFormID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboFormID.Size = new System.Drawing.Size(192, 21);
            this.comboFormID.TabIndex = 28;
            this.comboFormID.DropDownClosed += new System.EventHandler(this.FormIDClosed);
            // 
            // orderNum
            // 
            this.orderNum.Enabled = false;
            this.orderNum.Location = new System.Drawing.Point(109, 108);
            this.orderNum.Name = "orderNum";
            this.orderNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderNum.Size = new System.Drawing.Size(145, 20);
            this.orderNum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(1010, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "טבלת שאלות בטופס";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboFormID);
            this.panel1.Controls.Add(this.comboQuestions);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.orderNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 653);
            this.panel1.TabIndex = 30;
            // 
            // FormAddQuestionsInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddQuestionsInForm";
            this.Text = "FormAddQuestionsInForm";
            this.Load += new System.EventHandler(this.FormAddQuestionsInForm_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsInFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsInForm)).EndInit();
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
        private DataSetQuestionsInForm dataSetQuestionsInForm;
        private System.Windows.Forms.BindingSource tblQuestionsInFormBindingSource;
        private DataSetQuestionsInFormTableAdapters.tblQuestionsInFormTableAdapter tblQuestionsInFormTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifQuestionsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboQuestions;
        private System.Windows.Forms.ComboBox comboFormID;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifFormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qifQuestionID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}