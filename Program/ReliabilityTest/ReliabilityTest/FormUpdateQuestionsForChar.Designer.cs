namespace ReliabilityTest
{
    partial class FormUpdateQuestionsForChar
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
            this.comboToValue = new System.Windows.Forms.ComboBox();
            this.comboFromValue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.qfcCharNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcCharOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcFromValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qfcToValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuestionsForCharBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsForCharBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuestionsForChar = new ReliabilityTest.DataSetQuestionsForChar();
            this.tblQuestionsForCharTableAdapter = new ReliabilityTest.DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.charName = new System.Windows.Forms.TextBox();
            this.charOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForCharBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboToValue
            // 
            this.comboToValue.FormattingEnabled = true;
            this.comboToValue.Location = new System.Drawing.Point(363, 140);
            this.comboToValue.Name = "comboToValue";
            this.comboToValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboToValue.Size = new System.Drawing.Size(170, 21);
            this.comboToValue.TabIndex = 38;
            this.comboToValue.Click += new System.EventHandler(this.ToValueClick);
            // 
            // comboFromValue
            // 
            this.comboFromValue.FormattingEnabled = true;
            this.comboFromValue.Location = new System.Drawing.Point(631, 139);
            this.comboFromValue.Name = "comboFromValue";
            this.comboFromValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboFromValue.Size = new System.Drawing.Size(157, 21);
            this.comboFromValue.TabIndex = 37;
            this.comboFromValue.Click += new System.EventHandler(this.FromValueClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 140);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "ערך סיום:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(794, 137);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "ערך התחלה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(794, 100);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "מספר שאלה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(657, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "שם תכונה:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "עדכון שאלה לתכונה";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qfcCharNameDataGridViewTextBoxColumn,
            this.qfcCharOrderDataGridViewTextBoxColumn,
            this.qfcFromValueDataGridViewTextBoxColumn,
            this.qfcToValueDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tblQuestionsForCharBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(384, 327);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(460, 315);
            this.dataGridView.TabIndex = 58;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // qfcCharNameDataGridViewTextBoxColumn
            // 
            this.qfcCharNameDataGridViewTextBoxColumn.DataPropertyName = "qfcCharName";
            this.qfcCharNameDataGridViewTextBoxColumn.HeaderText = "שם תכונה";
            this.qfcCharNameDataGridViewTextBoxColumn.Name = "qfcCharNameDataGridViewTextBoxColumn";
            this.qfcCharNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qfcCharOrderDataGridViewTextBoxColumn
            // 
            this.qfcCharOrderDataGridViewTextBoxColumn.DataPropertyName = "qfcCharOrder";
            this.qfcCharOrderDataGridViewTextBoxColumn.HeaderText = "מספר שאלה";
            this.qfcCharOrderDataGridViewTextBoxColumn.Name = "qfcCharOrderDataGridViewTextBoxColumn";
            this.qfcCharOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qfcFromValueDataGridViewTextBoxColumn
            // 
            this.qfcFromValueDataGridViewTextBoxColumn.DataPropertyName = "qfcFromValue";
            this.qfcFromValueDataGridViewTextBoxColumn.HeaderText = "ערך התחלה";
            this.qfcFromValueDataGridViewTextBoxColumn.Name = "qfcFromValueDataGridViewTextBoxColumn";
            this.qfcFromValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qfcToValueDataGridViewTextBoxColumn
            // 
            this.qfcToValueDataGridViewTextBoxColumn.DataPropertyName = "qfcToValue";
            this.qfcToValueDataGridViewTextBoxColumn.HeaderText = "ערך סיום";
            this.qfcToValueDataGridViewTextBoxColumn.Name = "qfcToValueDataGridViewTextBoxColumn";
            this.qfcToValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblQuestionsForCharBindingSource
            // 
            this.tblQuestionsForCharBindingSource.DataMember = "tblQuestionsForChar";
            this.tblQuestionsForCharBindingSource.DataSource = this.dataSetQuestionsForCharBindingSource;
            // 
            // dataSetQuestionsForCharBindingSource
            // 
            this.dataSetQuestionsForCharBindingSource.DataSource = this.dataSetQuestionsForChar;
            this.dataSetQuestionsForCharBindingSource.Position = 0;
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
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(557, 239);
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
            this.buttonFirst.Location = new System.Drawing.Point(700, 181);
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
            this.buttonLast.Location = new System.Drawing.Point(425, 181);
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
            this.buttonNext.Location = new System.Drawing.Point(516, 181);
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
            this.buttonPrev.Location = new System.Drawing.Point(623, 181);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(73, 39);
            this.buttonPrev.TabIndex = 63;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.prevButtonClick);
            // 
            // charName
            // 
            this.charName.Enabled = false;
            this.charName.Location = new System.Drawing.Point(491, 65);
            this.charName.Name = "charName";
            this.charName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.charName.Size = new System.Drawing.Size(160, 20);
            this.charName.TabIndex = 68;
            // 
            // charOrder
            // 
            this.charOrder.Enabled = false;
            this.charOrder.Location = new System.Drawing.Point(363, 102);
            this.charOrder.Name = "charOrder";
            this.charOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.charOrder.Size = new System.Drawing.Size(425, 20);
            this.charOrder.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(718, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "טבלת שאלות לתכונות";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.charOrder);
            this.panel1.Controls.Add(this.charName);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.comboToValue);
            this.panel1.Controls.Add(this.comboFromValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 655);
            this.panel1.TabIndex = 71;
            // 
            // FormUpdateQuestionsForChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdateQuestionsForChar";
            this.Text = "FormUpdateQuestionsForChar";
            this.Load += new System.EventHandler(this.FormUpdateQuestionsForChar_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionsForCharBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForCharBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuestionsForChar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboToValue;
        private System.Windows.Forms.ComboBox comboFromValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dataSetQuestionsForCharBindingSource;
        private DataSetQuestionsForChar dataSetQuestionsForChar;
        private System.Windows.Forms.BindingSource tblQuestionsForCharBindingSource;
        private DataSetQuestionsForCharTableAdapters.tblQuestionsForCharTableAdapter tblQuestionsForCharTableAdapter;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.TextBox charName;
        private System.Windows.Forms.TextBox charOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcCharNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcCharOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcFromValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qfcToValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}