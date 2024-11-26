namespace ReliabilityTest
{
    partial class FormAddQuestionsForChar
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
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcCharOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcFromValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcToValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsForCharBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsForChar = new ReliabilityTest.DataSetQuestionsForChar();
            this.tblQuestionsForCharTableAdapter = new ReliabilityTest.DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter();
            this.comboQuestions = new System.Windows.Forms.ComboBox();
            this.comboFromValue = new System.Windows.Forms.ComboBox();
            this.comboToValue = new System.Windows.Forms.ComboBox();
            this.comboChars = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת שאלה לתכונה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 128);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ערך התחלה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(745, 91);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "מספר שאלה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "שם תכונה:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 131);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ערך סיום:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(509, 165);
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
            this.dataGridViewTextBoxColumn1,
            this.qfcCharOrderDataGridViewTextBoxColumn,
            this.qfcFromValueDataGridViewTextBoxColumn,
            this.qfcToValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblQuestionsForCharBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(356, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(447, 386);
            this.dataGridView1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "qfcCharName";
            this.dataGridViewTextBoxColumn1.HeaderText = "שם תכונה";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // qfcCharOrderDataGridViewTextBoxColumn
            // 
            this.qfcCharOrderDataGridViewTextBoxColumn.DataPropertyName = "qfcCharOrder";
            this.qfcCharOrderDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.qfcCharOrderDataGridViewTextBoxColumn.Name = "qfcCharOrderDataGridViewTextBoxColumn";
            // 
            // qfcFromValueDataGridViewTextBoxColumn
            // 
            this.qfcFromValueDataGridViewTextBoxColumn.DataPropertyName = "qfcFromValue";
            this.qfcFromValueDataGridViewTextBoxColumn.HeaderText = "ערך התחלה";
            this.qfcFromValueDataGridViewTextBoxColumn.Name = "qfcFromValueDataGridViewTextBoxColumn";
            // 
            // qfcToValueDataGridViewTextBoxColumn
            // 
            this.qfcToValueDataGridViewTextBoxColumn.DataPropertyName = "qfcToValue";
            this.qfcToValueDataGridViewTextBoxColumn.HeaderText = "ערך סיום";
            this.qfcToValueDataGridViewTextBoxColumn.Name = "qfcToValueDataGridViewTextBoxColumn";
            // 
            // tblQuestionsForCharBindingSource
            // 
            this.tblQuestionsForCharBindingSource.DataMember = "tblQuestionsForChar";
            this.tblQuestionsForCharBindingSource.DataSource = this.dataSetQuestionsForChar;
            // 
            // dataSetQuestionsForChar
            // 
            this.dataSetQuestionsForChar.DataSetName = "DataSetQuestionsForChar";
            this.dataSetQuestionsForChar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQuestionsForCharTableAdapter
            // 
            this.tblQuestionsForCharTableAdapter.ClearBeforeFill = true;
            // 
            // comboQuestions
            // 
            this.comboQuestions.FormattingEnabled = true;
            this.comboQuestions.Location = new System.Drawing.Point(325, 91);
            this.comboQuestions.Name = "comboQuestions";
            this.comboQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboQuestions.Size = new System.Drawing.Size(414, 21);
            this.comboQuestions.TabIndex = 26;
            this.comboQuestions.Click += new System.EventHandler(this.QuestionsClick);
            // 
            // comboFromValue
            // 
            this.comboFromValue.FormattingEnabled = true;
            this.comboFromValue.Location = new System.Drawing.Point(582, 130);
            this.comboFromValue.Name = "comboFromValue";
            this.comboFromValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboFromValue.Size = new System.Drawing.Size(157, 21);
            this.comboFromValue.TabIndex = 27;
            this.comboFromValue.Click += new System.EventHandler(this.FromValueClick);
            // 
            // comboToValue
            // 
            this.comboToValue.FormattingEnabled = true;
            this.comboToValue.Location = new System.Drawing.Point(314, 131);
            this.comboToValue.Name = "comboToValue";
            this.comboToValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboToValue.Size = new System.Drawing.Size(170, 21);
            this.comboToValue.TabIndex = 28;
            this.comboToValue.Click += new System.EventHandler(this.ToValueClick);
            // 
            // comboChars
            // 
            this.comboChars.FormattingEnabled = true;
            this.comboChars.Location = new System.Drawing.Point(445, 54);
            this.comboChars.Name = "comboChars";
            this.comboChars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboChars.Size = new System.Drawing.Size(157, 21);
            this.comboChars.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(677, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "טבלת שאלות לתכונות";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboChars);
            this.panel1.Controls.Add(this.comboToValue);
            this.panel1.Controls.Add(this.comboFromValue);
            this.panel1.Controls.Add(this.comboQuestions);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 647);
            this.panel1.TabIndex = 31;
            // 
            // FormAddQuestionsForChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddQuestionsForChar";
            this.Text = "FormAddQuestionsForChar";
            this.Load += new System.EventHandler(this.FormAddQuestionsForChar_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfeCharNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetQuestionsForChar dataSetQuestionsForChar;
        private System.Windows.Forms.BindingSource tblQuestionsForCharBindingSource;
        private DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter tblQuestionsForCharTableAdapter;
        private System.Windows.Forms.ComboBox comboQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcCharOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcFromValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcToValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboFromValue;
        private System.Windows.Forms.ComboBox comboToValue;
        private System.Windows.Forms.ComboBox comboChars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}