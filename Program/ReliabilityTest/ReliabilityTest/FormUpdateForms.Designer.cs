namespace ReliabilityTest
{
    partial class FormUpdateForms
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
            this.FormDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.formIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formCreatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFormsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForms = new ReliabilityTest.DataSetForms();
            this.tblFormsTableAdapter = new ReliabilityTest.DataSetFormsTableAdapters.tblFormsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboUsers
            // 
            this.comboUsers.FormattingEnabled = true;
            this.comboUsers.Location = new System.Drawing.Point(105, 103);
            this.comboUsers.Name = "comboUsers";
            this.comboUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboUsers.Size = new System.Drawing.Size(292, 21);
            this.comboUsers.TabIndex = 36;
            // 
            // FormDate
            // 
            this.FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FormDate.Location = new System.Drawing.Point(510, 105);
            this.FormDate.Name = "FormDate";
            this.FormDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FormDate.Size = new System.Drawing.Size(167, 20);
            this.FormDate.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 103);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "ת\"ז יוצר:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 103);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "תאריך יצירה:";
            // 
            // formName
            // 
            this.formName.Location = new System.Drawing.Point(814, 105);
            this.formName.Name = "formName";
            this.formName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.formName.Size = new System.Drawing.Size(145, 20);
            this.formName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(965, 103);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "שם מבחן:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "עדכון טופס";
            // 
            // formID
            // 
            this.formID.Enabled = false;
            this.formID.Location = new System.Drawing.Point(512, 57);
            this.formID.Name = "formID";
            this.formID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.formID.Size = new System.Drawing.Size(145, 20);
            this.formID.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(663, 55);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "מספר טופס:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(549, 221);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(113, 47);
            this.buttonUpdate.TabIndex = 66;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(692, 163);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 39);
            this.buttonFirst.TabIndex = 65;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.firstButtonClick);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(417, 163);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(87, 39);
            this.buttonLast.TabIndex = 64;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.lastButtonClick);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(508, 163);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 39);
            this.buttonNext.TabIndex = 63;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.nextButtonClick);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(615, 163);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(73, 39);
            this.buttonPrev.TabIndex = 62;
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
            this.formIDDataGridViewTextBoxColumn,
            this.formNameDataGridViewTextBoxColumn,
            this.formDateDataGridViewTextBoxColumn,
            this.formCreatorIDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tblFormsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(387, 307);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(457, 313);
            this.dataGridView.TabIndex = 67;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // formIDDataGridViewTextBoxColumn
            // 
            this.formIDDataGridViewTextBoxColumn.DataPropertyName = "formID";
            this.formIDDataGridViewTextBoxColumn.HeaderText = "מספר טופס";
            this.formIDDataGridViewTextBoxColumn.Name = "formIDDataGridViewTextBoxColumn";
            this.formIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formNameDataGridViewTextBoxColumn
            // 
            this.formNameDataGridViewTextBoxColumn.DataPropertyName = "formName";
            this.formNameDataGridViewTextBoxColumn.HeaderText = "שם מבחן";
            this.formNameDataGridViewTextBoxColumn.Name = "formNameDataGridViewTextBoxColumn";
            this.formNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formDateDataGridViewTextBoxColumn
            // 
            this.formDateDataGridViewTextBoxColumn.DataPropertyName = "formDate";
            this.formDateDataGridViewTextBoxColumn.HeaderText = "תאריך יצירה";
            this.formDateDataGridViewTextBoxColumn.Name = "formDateDataGridViewTextBoxColumn";
            this.formDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formCreatorIDDataGridViewTextBoxColumn
            // 
            this.formCreatorIDDataGridViewTextBoxColumn.DataPropertyName = "formCreatorID";
            this.formCreatorIDDataGridViewTextBoxColumn.HeaderText = "תז יוצר";
            this.formCreatorIDDataGridViewTextBoxColumn.Name = "formCreatorIDDataGridViewTextBoxColumn";
            this.formCreatorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblFormsBindingSource
            // 
            this.tblFormsBindingSource.DataMember = "tblForms";
            this.tblFormsBindingSource.DataSource = this.dataSetForms;
            // 
            // dataSetForms
            // 
            this.dataSetForms.DataSetName = "DataSetForms";
            this.dataSetForms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFormsTableAdapter
            // 
            this.tblFormsTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(765, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "טבלת טפסים";
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
            this.panel1.Controls.Add(this.formID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboUsers);
            this.panel1.Controls.Add(this.FormDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.formName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 635);
            this.panel1.TabIndex = 69;
            // 
            // FormUpdateForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdateForms";
            this.Text = "FormUpdateForms";
            this.Load += new System.EventHandler(this.FormUpdateForms_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUsers;
        private System.Windows.Forms.DateTimePicker FormDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataSetForms dataSetForms;
        private System.Windows.Forms.BindingSource tblFormsBindingSource;
        private DataSetFormsTableAdapters.tblFormsTableAdapter tblFormsTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formCreatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}