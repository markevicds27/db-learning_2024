namespace DBZhuk
{
    partial class AddSportsmanForm
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
            this.buttonAddStYes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSurame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatron = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxSport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddStYes
            // 
            this.buttonAddStYes.Location = new System.Drawing.Point(12, 334);
            this.buttonAddStYes.Name = "buttonAddStYes";
            this.buttonAddStYes.Size = new System.Drawing.Size(150, 35);
            this.buttonAddStYes.TabIndex = 36;
            this.buttonAddStYes.Text = "Добавить";
            this.buttonAddStYes.UseVisualStyleBackColor = true;
            this.buttonAddStYes.Click += new System.EventHandler(this.buttonAddStYes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Имя";
            // 
            // textBoxSurame
            // 
            this.textBoxSurame.Location = new System.Drawing.Point(12, 32);
            this.textBoxSurame.Name = "textBoxSurame";
            this.textBoxSurame.Size = new System.Drawing.Size(323, 26);
            this.textBoxSurame.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 84);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(323, 26);
            this.textBoxName.TabIndex = 38;
            // 
            // textBoxPatron
            // 
            this.textBoxPatron.Location = new System.Drawing.Point(12, 139);
            this.textBoxPatron.Name = "textBoxPatron";
            this.textBoxPatron.Size = new System.Drawing.Size(323, 26);
            this.textBoxPatron.TabIndex = 39;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(12, 245);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(323, 26);
            this.textBoxAge.TabIndex = 40;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(12, 191);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(323, 28);
            this.comboBoxGender.TabIndex = 41;
            // 
            // comboBoxSport
            // 
            this.comboBoxSport.FormattingEnabled = true;
            this.comboBoxSport.Location = new System.Drawing.Point(12, 300);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(323, 28);
            this.comboBoxSport.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Вид спорта";
            // 
            // AddSportsmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 379);
            this.Controls.Add(this.comboBoxSport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPatron);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddStYes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSurame);
            this.Controls.Add(this.label1);
            this.Name = "AddSportsmanForm";
            this.Text = "AddSportsmanForm";
            this.Load += new System.EventHandler(this.AddSportsmanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddStYes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSurame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatron;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxSport;
        private System.Windows.Forms.Label label6;
    }
}