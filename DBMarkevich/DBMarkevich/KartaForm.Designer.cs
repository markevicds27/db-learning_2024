namespace DBMarkevich
{
    partial class KartaForm
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchNo = new System.Windows.Forms.Button();
            this.textBoxBoleznS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxAnimalS = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.textBoxNaznachenie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBolezn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idkarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idanimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameanimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebolezn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naznachenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.textBoxBoleznS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxAnimalS);
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Location = new System.Drawing.Point(330, 172);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(320, 186);
            this.groupBoxSearch.TabIndex = 34;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(175, 142);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            this.buttonSearchNo.Click += new System.EventHandler(this.buttonSearchNo_Click);
            // 
            // textBoxBoleznS
            // 
            this.textBoxBoleznS.Location = new System.Drawing.Point(5, 109);
            this.textBoxBoleznS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxBoleznS.Name = "textBoxBoleznS";
            this.textBoxBoleznS.Size = new System.Drawing.Size(309, 27);
            this.textBoxBoleznS.TabIndex = 7;
            this.textBoxBoleznS.TextChanged += new System.EventHandler(this.textBoxBoleznS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 85);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Болезнь";
            // 
            // textBoxAnimalS
            // 
            this.textBoxAnimalS.Location = new System.Drawing.Point(5, 53);
            this.textBoxAnimalS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxAnimalS.Name = "textBoxAnimalS";
            this.textBoxAnimalS.Size = new System.Drawing.Size(309, 27);
            this.textBoxAnimalS.TabIndex = 3;
            this.textBoxAnimalS.TextChanged += new System.EventHandler(this.textBoxAnimalS_TextChanged);
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(5, 29);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(88, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Животное";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.textBoxNaznachenie);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Controls.Add(this.dateTimePicker1);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.comboBoxBolezn);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.comboBoxAnimal);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 172);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(320, 291);
            this.groupBoxAdd.TabIndex = 33;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(5, 249);
            this.buttonAddOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(139, 33);
            this.buttonAddOk.TabIndex = 33;
            this.buttonAddOk.Text = "Добавить";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // buttonAddNo
            // 
            this.buttonAddNo.Location = new System.Drawing.Point(175, 248);
            this.buttonAddNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddNo.Name = "buttonAddNo";
            this.buttonAddNo.Size = new System.Drawing.Size(139, 33);
            this.buttonAddNo.TabIndex = 34;
            this.buttonAddNo.Text = "Отмена";
            this.buttonAddNo.UseVisualStyleBackColor = true;
            this.buttonAddNo.Click += new System.EventHandler(this.buttonAddNo_Click);
            // 
            // textBoxNaznachenie
            // 
            this.textBoxNaznachenie.Location = new System.Drawing.Point(5, 215);
            this.textBoxNaznachenie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNaznachenie.Name = "textBoxNaznachenie";
            this.textBoxNaznachenie.Size = new System.Drawing.Size(309, 27);
            this.textBoxNaznachenie.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Назначение";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Дата";
            // 
            // comboBoxBolezn
            // 
            this.comboBoxBolezn.FormattingEnabled = true;
            this.comboBoxBolezn.Location = new System.Drawing.Point(5, 105);
            this.comboBoxBolezn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxBolezn.Name = "comboBoxBolezn";
            this.comboBoxBolezn.Size = new System.Drawing.Size(309, 29);
            this.comboBoxBolezn.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Болещнь";
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(5, 51);
            this.comboBoxAnimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(309, 29);
            this.comboBoxAnimal.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Животное";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkarta,
            this.idanimal,
            this.nameanimal,
            this.namebolezn,
            this.date,
            this.naznachenie});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(806, 153);
            this.dataGridView1.TabIndex = 31;
            // 
            // idkarta
            // 
            this.idkarta.DataPropertyName = "idkarta";
            this.idkarta.HeaderText = "idkarta";
            this.idkarta.MinimumWidth = 8;
            this.idkarta.Name = "idkarta";
            this.idkarta.ReadOnly = true;
            this.idkarta.Visible = false;
            // 
            // idanimal
            // 
            this.idanimal.DataPropertyName = "idanimal";
            this.idanimal.HeaderText = "Номер";
            this.idanimal.MinimumWidth = 8;
            this.idanimal.Name = "idanimal";
            this.idanimal.ReadOnly = true;
            // 
            // nameanimal
            // 
            this.nameanimal.DataPropertyName = "nameanimal";
            this.nameanimal.HeaderText = "Животное";
            this.nameanimal.MinimumWidth = 8;
            this.nameanimal.Name = "nameanimal";
            this.nameanimal.ReadOnly = true;
            // 
            // namebolezn
            // 
            this.namebolezn.DataPropertyName = "namebolezn";
            this.namebolezn.HeaderText = "Болезнь";
            this.namebolezn.MinimumWidth = 8;
            this.namebolezn.Name = "namebolezn";
            this.namebolezn.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // naznachenie
            // 
            this.naznachenie.DataPropertyName = "naznachenie";
            this.naznachenie.HeaderText = "Назначение";
            this.naznachenie.MinimumWidth = 8;
            this.naznachenie.Name = "naznachenie";
            this.naznachenie.ReadOnly = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(660, 172);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 62);
            this.buttonDel.TabIndex = 35;
            this.buttonDel.Text = "Удалить запись";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // KartaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(840, 473);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "KartaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartaForm";
            this.Load += new System.EventHandler(this.KartaForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearchNo;
        private System.Windows.Forms.TextBox textBoxBoleznS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxAnimalS;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.TextBox textBoxNaznachenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBolezn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameanimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebolezn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn naznachenie;
        private System.Windows.Forms.Button buttonDel;
    }
}