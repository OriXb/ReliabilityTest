namespace ReliabilityTest
{
    partial class FormAddCharacters
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
            this.charDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.charName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.charNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCharactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCharactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCharacters = new ReliabilityTest.DataSetCharacters();
            this.tblCharactersTableAdapter = new ReliabilityTest.DataSetCharactersTableAdapters.tblCharactersTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharacters)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת תכונה";
            // 
            // charDesc
            // 
            this.charDesc.Location = new System.Drawing.Point(286, 112);
            this.charDesc.Name = "charDesc";
            this.charDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.charDesc.Size = new System.Drawing.Size(556, 20);
            this.charDesc.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(848, 110);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "תיאור:";
            // 
            // charName
            // 
            this.charName.Location = new System.Drawing.Point(476, 67);
            this.charName.Name = "charName";
            this.charName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.charName.Size = new System.Drawing.Size(145, 20);
            this.charName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 65);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "שם תכונה:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(498, 164);
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
            this.charNameDataGridViewTextBoxColumn,
            this.charDescDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCharactersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(448, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(250, 394);
            this.dataGridView1.TabIndex = 26;
            // 
            // charNameDataGridViewTextBoxColumn
            // 
            this.charNameDataGridViewTextBoxColumn.DataPropertyName = "charName";
            this.charNameDataGridViewTextBoxColumn.HeaderText = "שם תכונה";
            this.charNameDataGridViewTextBoxColumn.Name = "charNameDataGridViewTextBoxColumn";
            // 
            // charDescDataGridViewTextBoxColumn
            // 
            this.charDescDataGridViewTextBoxColumn.DataPropertyName = "charDesc";
            this.charDescDataGridViewTextBoxColumn.HeaderText = "תיאור תכונה";
            this.charDescDataGridViewTextBoxColumn.Name = "charDescDataGridViewTextBoxColumn";
            // 
            // tblCharactersBindingSource
            // 
            this.tblCharactersBindingSource.DataMember = "tblCharacters";
            this.tblCharactersBindingSource.DataSource = this.dataSetCharactersBindingSource;
            // 
            // dataSetCharactersBindingSource
            // 
            this.dataSetCharactersBindingSource.DataSource = this.dataSetCharacters;
            this.dataSetCharactersBindingSource.Position = 0;
            // 
            // dataSetCharacters
            // 
            this.dataSetCharacters.DataSetName = "DataSetCharacters";
            this.dataSetCharacters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCharactersTableAdapter
            // 
            this.tblCharactersTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(619, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "טבלת תכונות";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.charDesc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.charName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 639);
            this.panel1.TabIndex = 28;
            // 
            // FormAddCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddCharacters";
            this.Text = "FormAddCharacters";
            this.Load += new System.EventHandler(this.FormAddCharacters_Load);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCharacters)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox charDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox charName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetCharactersBindingSource;
        private DataSetCharacters dataSetCharacters;
        private System.Windows.Forms.BindingSource tblCharactersBindingSource;
        private DataSetCharactersTableAdapters.tblCharactersTableAdapter tblCharactersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn charNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}