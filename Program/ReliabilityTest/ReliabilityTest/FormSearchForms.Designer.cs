namespace ReliabilityTest
{
    partial class FormSearchForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridForms = new System.Windows.Forms.DataGridView();
            this.formIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formCreatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFormsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForms = new ReliabilityTest.DataSetForms();
            this.label1 = new System.Windows.Forms.Label();
            this.tblFormsTableAdapter = new ReliabilityTest.DataSetFormsTableAdapters.tblFormsTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.searchStr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridForms);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 584);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(978, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "טבלת טפסי מבחן";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(507, 471);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 54);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "חפש ";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchStr
            // 
            this.searchStr.Location = new System.Drawing.Point(450, 92);
            this.searchStr.Name = "searchStr";
            this.searchStr.Size = new System.Drawing.Size(143, 20);
            this.searchStr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "מחרוזת לחיפוש";
            // 
            // dataGridForms
            // 
            this.dataGridForms.AutoGenerateColumns = false;
            this.dataGridForms.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formIDDataGridViewTextBoxColumn,
            this.formNameDataGridViewTextBoxColumn,
            this.formDateDataGridViewTextBoxColumn,
            this.formCreatorIDDataGridViewTextBoxColumn});
            this.dataGridForms.DataSource = this.tblFormsBindingSource;
            this.dataGridForms.Location = new System.Drawing.Point(26, 180);
            this.dataGridForms.Name = "dataGridForms";
            this.dataGridForms.ReadOnly = true;
            this.dataGridForms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridForms.Size = new System.Drawing.Size(1056, 268);
            this.dataGridForms.TabIndex = 4;
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
            this.formNameDataGridViewTextBoxColumn.HeaderText = "שם הטופס";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(426, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "חיפוש בטבלת טפסי מבחן";
            // 
            // tblFormsTableAdapter
            // 
            this.tblFormsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(529, 531);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 43);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "רענן ";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormSearchForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormSearchForms";
            this.Text = "FormSearchForms";
            this.Load += new System.EventHandler(this.FormSearchForms_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridForms;
        private System.Windows.Forms.Label label1;
        private DataSetForms dataSetForms;
        private System.Windows.Forms.BindingSource tblFormsBindingSource;
        private DataSetFormsTableAdapters.tblFormsTableAdapter tblFormsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formCreatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRefresh;
    }
}