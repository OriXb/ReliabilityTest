namespace ReliabilityTest
{
    partial class FormTestCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.charactersList = new System.Windows.Forms.CheckedListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quesCount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.creatorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "טופס יצירת מבחן";
            // 
            // charactersList
            // 
            this.charactersList.FormattingEnabled = true;
            this.charactersList.Location = new System.Drawing.Point(485, 192);
            this.charactersList.Name = "charactersList";
            this.charactersList.Size = new System.Drawing.Size(204, 229);
            this.charactersList.TabIndex = 32;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Ivory;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.createButton.Location = new System.Drawing.Point(515, 564);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(162, 53);
            this.createButton.TabIndex = 33;
            this.createButton.Text = "צור טופס בחינה";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.buttonCreateClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 162);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(256, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "אנא בחר בין 1 עד 3 תכונות:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 106);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(153, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "שם טופס המבחן:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formName
            // 
            this.formName.Location = new System.Drawing.Point(431, 111);
            this.formName.Name = "formName";
            this.formName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.formName.Size = new System.Drawing.Size(168, 20);
            this.formName.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 448);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(212, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "בחר כמות שאלות לכל תכונה:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quesCount
            // 
            this.quesCount.BackColor = System.Drawing.Color.Khaki;
            this.quesCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quesCount.FormattingEnabled = true;
            this.quesCount.Location = new System.Drawing.Point(503, 478);
            this.quesCount.Name = "quesCount";
            this.quesCount.Size = new System.Drawing.Size(186, 21);
            this.quesCount.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 69);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(153, 27);
            this.label4.TabIndex = 43;
            this.label4.Text = "ת\"ז יוצר המבחן:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creatorID
            // 
            this.creatorID.Enabled = false;
            this.creatorID.Location = new System.Drawing.Point(431, 74);
            this.creatorID.Name = "creatorID";
            this.creatorID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creatorID.Size = new System.Drawing.Size(168, 20);
            this.creatorID.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(397, 502);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(393, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "בנוסף לשאלות אלו יתווספו 10 אחוז שאלות זיוף בשביל אמיתות הבחינה.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.creatorID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.quesCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.formName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.charactersList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 650);
            this.panel1.TabIndex = 46;
            // 
            // FormTestCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormTestCreate";
            this.Text = "FormTestCreate";
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox charactersList;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox formName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox creatorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}