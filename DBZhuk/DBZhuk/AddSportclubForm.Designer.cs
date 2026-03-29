namespace DBZhuk
{
    partial class AddSportclubForm
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
            this.comboBoxSport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonAddStYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSport
            // 
            this.comboBoxSport.FormattingEnabled = true;
            this.comboBoxSport.Location = new System.Drawing.Point(16, 136);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(323, 28);
            this.comboBoxSport.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Вид спорта";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(16, 84);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(323, 26);
            this.textBoxCity.TabIndex = 51;
            // 
            // buttonAddStYes
            // 
            this.buttonAddStYes.Location = new System.Drawing.Point(16, 170);
            this.buttonAddStYes.Name = "buttonAddStYes";
            this.buttonAddStYes.Size = new System.Drawing.Size(150, 35);
            this.buttonAddStYes.TabIndex = 50;
            this.buttonAddStYes.Text = "Добавить";
            this.buttonAddStYes.UseVisualStyleBackColor = true;
            this.buttonAddStYes.Click += new System.EventHandler(this.buttonAddStYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Город";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(323, 26);
            this.textBoxName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Навазние";
            // 
            // AddSportclubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 215);
            this.Controls.Add(this.comboBoxSport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.buttonAddStYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "AddSportclubForm";
            this.Text = "AddSportclubForm";
            this.Load += new System.EventHandler(this.AddSportclubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonAddStYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}