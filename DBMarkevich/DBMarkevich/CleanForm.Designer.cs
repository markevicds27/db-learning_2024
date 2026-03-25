namespace DBMarkevich
{
    partial class CleanForm
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
            this.textBoxCageS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxSurnameS = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldnameworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.textBoxCageS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxSurnameS);
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Location = new System.Drawing.Point(345, 182);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(321, 189);
            this.groupBoxSearch.TabIndex = 27;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(176, 147);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            // 
            // textBoxCageS
            // 
            this.textBoxCageS.Location = new System.Drawing.Point(6, 114);
            this.textBoxCageS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxCageS.Name = "textBoxCageS";
            this.textBoxCageS.Size = new System.Drawing.Size(309, 27);
            this.textBoxCageS.TabIndex = 7;
            this.textBoxCageS.TextChanged += new System.EventHandler(this.textBoxCageS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 89);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Клетка";
            // 
            // textBoxSurnameS
            // 
            this.textBoxSurnameS.Location = new System.Drawing.Point(6, 56);
            this.textBoxSurnameS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSurnameS.Name = "textBoxSurnameS";
            this.textBoxSurnameS.Size = new System.Drawing.Size(309, 27);
            this.textBoxSurnameS.TabIndex = 3;
            this.textBoxSurnameS.TextChanged += new System.EventHandler(this.textBoxSurnameS_TextChanged);
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(6, 30);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(85, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Фамилия";
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
            this.groupBoxAdd.Location = new System.Drawing.Point(16, 182);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(325, 251);
            this.groupBoxAdd.TabIndex = 26;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(6, 205);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // buttonAddNo
            // 
            this.buttonAddNo.Location = new System.Drawing.Point(176, 205);
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
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дата уборки";
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(6, 110);
            this.comboBoxAnimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(309, 29);
            this.comboBoxAnimal.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Клетка";
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(6, 54);
            this.comboBoxWorker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(309, 29);
            this.comboBoxWorker.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Работник";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(670, 182);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(176, 65);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить запись";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclean,
            this.idworker,
            this.surnameworker,
            this.nameworker,
            this.oldnameworker,
            this.idcage,
            this.date});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(830, 161);
            this.dataGridView1.TabIndex = 24;
            // 
            // idclean
            // 
            this.idclean.DataPropertyName = "idclean";
            this.idclean.HeaderText = "idclean";
            this.idclean.MinimumWidth = 8;
            this.idclean.Name = "idclean";
            this.idclean.ReadOnly = true;
            this.idclean.Visible = false;
            // 
            // idworker
            // 
            this.idworker.DataPropertyName = "idworker";
            this.idworker.HeaderText = "idworker";
            this.idworker.MinimumWidth = 8;
            this.idworker.Name = "idworker";
            this.idworker.ReadOnly = true;
            this.idworker.Visible = false;
            // 
            // surnameworker
            // 
            this.surnameworker.DataPropertyName = "surnameworker";
            this.surnameworker.HeaderText = "Фамилия";
            this.surnameworker.MinimumWidth = 8;
            this.surnameworker.Name = "surnameworker";
            this.surnameworker.ReadOnly = true;
            // 
            // nameworker
            // 
            this.nameworker.DataPropertyName = "nameworker";
            this.nameworker.HeaderText = "Имя";
            this.nameworker.MinimumWidth = 8;
            this.nameworker.Name = "nameworker";
            this.nameworker.ReadOnly = true;
            // 
            // oldnameworker
            // 
            this.oldnameworker.DataPropertyName = "oldnameworker";
            this.oldnameworker.HeaderText = "Отчество";
            this.oldnameworker.MinimumWidth = 8;
            this.oldnameworker.Name = "oldnameworker";
            this.oldnameworker.ReadOnly = true;
            // 
            // idcage
            // 
            this.idcage.DataPropertyName = "idcage";
            this.idcage.HeaderText = "Номер клетки";
            this.idcage.MinimumWidth = 8;
            this.idcage.Name = "idcage";
            this.idcage.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата уборки ";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // CleanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(855, 445);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "CleanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleanForm";
            this.Load += new System.EventHandler(this.CleanForm_Load);
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
        private System.Windows.Forms.TextBox textBoxCageS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxSurnameS;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclean;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldnameworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcage;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}