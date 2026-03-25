namespace DBMarkevich
{
    partial class ZakrepForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Название = new System.Windows.Forms.Label();
            this.textBoxSurnameS = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxNameS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxNameAnimalS = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonSearchNo = new System.Windows.Forms.Button();
            this.textBoxVidS = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(984, 170);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 62);
            this.buttonDel.TabIndex = 19;
            this.buttonDel.Text = "Удалить запись";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.dateTimePicker1);
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.comboBoxAnimal);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.comboBoxWorker);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 170);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(328, 239);
            this.groupBoxAdd.TabIndex = 21;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(4, 197);
            this.buttonAddOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(139, 33);
            this.buttonAddOk.TabIndex = 33;
            this.buttonAddOk.Text = "Добавить";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // buttonAddNo
            // 
            this.buttonAddNo.Location = new System.Drawing.Point(175, 197);
            this.buttonAddNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddNo.Name = "buttonAddNo";
            this.buttonAddNo.Size = new System.Drawing.Size(139, 33);
            this.buttonAddNo.TabIndex = 34;
            this.buttonAddNo.Text = "Отмена";
            this.buttonAddNo.UseVisualStyleBackColor = true;
            this.buttonAddNo.Click += new System.EventHandler(this.buttonAddNo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дата закрепления";
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(5, 105);
            this.comboBoxAnimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(309, 29);
            this.comboBoxAnimal.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Животное";
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(5, 51);
            this.comboBoxWorker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(309, 29);
            this.comboBoxWorker.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Работник";
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(5, 29);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(85, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Фамилия";
            // 
            // textBoxSurnameS
            // 
            this.textBoxSurnameS.Location = new System.Drawing.Point(5, 53);
            this.textBoxSurnameS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSurnameS.Name = "textBoxSurnameS";
            this.textBoxSurnameS.Size = new System.Drawing.Size(309, 27);
            this.textBoxSurnameS.TabIndex = 3;
            this.textBoxSurnameS.TextChanged += new System.EventHandler(this.textBoxSurnameS_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(318, 29);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 21);
            this.label29.TabIndex = 4;
            this.label29.Text = "Имя";
            // 
            // textBoxNameS
            // 
            this.textBoxNameS.Location = new System.Drawing.Point(318, 53);
            this.textBoxNameS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNameS.Name = "textBoxNameS";
            this.textBoxNameS.Size = new System.Drawing.Size(309, 27);
            this.textBoxNameS.TabIndex = 5;
            this.textBoxNameS.TextChanged += new System.EventHandler(this.textBoxNameS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 85);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Название";
            // 
            // textBoxNameAnimalS
            // 
            this.textBoxNameAnimalS.Location = new System.Drawing.Point(5, 109);
            this.textBoxNameAnimalS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNameAnimalS.Name = "textBoxNameAnimalS";
            this.textBoxNameAnimalS.Size = new System.Drawing.Size(309, 27);
            this.textBoxNameAnimalS.TabIndex = 7;
            this.textBoxNameAnimalS.TextChanged += new System.EventHandler(this.textBoxNameAnimalS_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(318, 85);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 21);
            this.label27.TabIndex = 8;
            this.label27.Text = "Вид";
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(488, 141);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            this.buttonSearchNo.Click += new System.EventHandler(this.buttonSearchNo_Click);
            // 
            // textBoxVidS
            // 
            this.textBoxVidS.Location = new System.Drawing.Point(318, 108);
            this.textBoxVidS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxVidS.Name = "textBoxVidS";
            this.textBoxVidS.Size = new System.Drawing.Size(309, 27);
            this.textBoxVidS.TabIndex = 36;
            this.textBoxVidS.TextChanged += new System.EventHandler(this.textBoxVidS_TextChanged);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxVidS);
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.label27);
            this.groupBoxSearch.Controls.Add(this.textBoxNameAnimalS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxNameS);
            this.groupBoxSearch.Controls.Add(this.label29);
            this.groupBoxSearch.Controls.Add(this.textBoxSurnameS);
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Location = new System.Drawing.Point(344, 175);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(636, 186);
            this.groupBoxSearch.TabIndex = 22;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // ZakrepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1154, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonDel);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "ZakrepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZakrepForm";
            this.Load += new System.EventHandler(this.ZakrepForm_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.TextBox textBoxSurnameS;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxNameS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxNameAnimalS;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button buttonSearchNo;
        private System.Windows.Forms.TextBox textBoxVidS;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}