namespace DBKozlovskiy
{
    partial class NewWorker
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
            this.groupBoxNew = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxStaz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatron = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDol = new System.Windows.Forms.ComboBox();
            this.comboBoxOtdel = new System.Windows.Forms.ComboBox();
            this.groupBoxNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.Controls.Add(this.comboBoxOtdel);
            this.groupBoxNew.Controls.Add(this.comboBoxDol);
            this.groupBoxNew.Controls.Add(this.label6);
            this.groupBoxNew.Controls.Add(this.label7);
            this.groupBoxNew.Controls.Add(this.buttonOk);
            this.groupBoxNew.Controls.Add(this.textBoxStaz);
            this.groupBoxNew.Controls.Add(this.label5);
            this.groupBoxNew.Controls.Add(this.textBoxAge);
            this.groupBoxNew.Controls.Add(this.label4);
            this.groupBoxNew.Controls.Add(this.textBoxPatron);
            this.groupBoxNew.Controls.Add(this.label3);
            this.groupBoxNew.Controls.Add(this.textBoxName);
            this.groupBoxNew.Controls.Add(this.label2);
            this.groupBoxNew.Controls.Add(this.textBoxSurname);
            this.groupBoxNew.Controls.Add(this.label1);
            this.groupBoxNew.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(350, 470);
            this.groupBoxNew.TabIndex = 2;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "Добавление записи";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(10, 424);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(333, 36);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxStaz
            // 
            this.textBoxStaz.Location = new System.Drawing.Point(10, 280);
            this.textBoxStaz.Name = "textBoxStaz";
            this.textBoxStaz.Size = new System.Drawing.Size(333, 26);
            this.textBoxStaz.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Стаж";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(10, 221);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(333, 26);
            this.textBoxAge.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст";
            // 
            // textBoxPatron
            // 
            this.textBoxPatron.Location = new System.Drawing.Point(11, 168);
            this.textBoxPatron.Name = "textBoxPatron";
            this.textBoxPatron.Size = new System.Drawing.Size(333, 26);
            this.textBoxPatron.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 109);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(333, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(11, 50);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(333, 26);
            this.textBoxSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Отдел";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Должность";
            // 
            // comboBoxDol
            // 
            this.comboBoxDol.FormattingEnabled = true;
            this.comboBoxDol.Location = new System.Drawing.Point(10, 333);
            this.comboBoxDol.Name = "comboBoxDol";
            this.comboBoxDol.Size = new System.Drawing.Size(334, 28);
            this.comboBoxDol.TabIndex = 17;
            // 
            // comboBoxOtdel
            // 
            this.comboBoxOtdel.FormattingEnabled = true;
            this.comboBoxOtdel.Location = new System.Drawing.Point(10, 392);
            this.comboBoxOtdel.Name = "comboBoxOtdel";
            this.comboBoxOtdel.Size = new System.Drawing.Size(333, 28);
            this.comboBoxOtdel.TabIndex = 18;
            // 
            // NewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 488);
            this.Controls.Add(this.groupBoxNew);
            this.Name = "NewWorker";
            this.Text = "NewWorker";
            this.Load += new System.EventHandler(this.NewWorker_Load);
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.TextBox textBoxStaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPatron;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxOtdel;
        private System.Windows.Forms.ComboBox comboBoxDol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}