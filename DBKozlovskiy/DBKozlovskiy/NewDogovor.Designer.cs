namespace DBKozlovskiy
{
    partial class NewDogovor
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
            this.comboBoxZakaz = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.Controls.Add(this.comboBoxZakaz);
            this.groupBoxNew.Controls.Add(this.buttonOk);
            this.groupBoxNew.Controls.Add(this.dateTimePicker2);
            this.groupBoxNew.Controls.Add(this.dateTimePicker1);
            this.groupBoxNew.Controls.Add(this.label5);
            this.groupBoxNew.Controls.Add(this.label6);
            this.groupBoxNew.Controls.Add(this.comboBoxStatus);
            this.groupBoxNew.Controls.Add(this.label4);
            this.groupBoxNew.Controls.Add(this.label2);
            this.groupBoxNew.Controls.Add(this.textBoxName);
            this.groupBoxNew.Controls.Add(this.label1);
            this.groupBoxNew.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(350, 350);
            this.groupBoxNew.TabIndex = 5;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "Добавление записи";
            // 
            // comboBoxZakaz
            // 
            this.comboBoxZakaz.FormattingEnabled = true;
            this.comboBoxZakaz.Location = new System.Drawing.Point(11, 108);
            this.comboBoxZakaz.Name = "comboBoxZakaz";
            this.comboBoxZakaz.Size = new System.Drawing.Size(333, 28);
            this.comboBoxZakaz.TabIndex = 13;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(11, 303);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(333, 36);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 271);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(333, 26);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Срок выполнения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата заключения";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Активен",
            "Приостановлен\t",
            "Выполнен"});
            this.comboBoxStatus.Location = new System.Drawing.Point(11, 162);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(333, 28);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заказчик";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(333, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // NewDogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 374);
            this.Controls.Add(this.groupBoxNew);
            this.Name = "NewDogovor";
            this.Text = "NewDogovor";
            this.Load += new System.EventHandler(this.NewDogovor_Load);
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxZakaz;
    }
}