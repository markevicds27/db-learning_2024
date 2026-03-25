namespace DBMarkevich
{
    partial class MedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldnameworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idanimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameanimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchNo = new System.Windows.Forms.Button();
            this.textBoxNameAnimalS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxSurnameS = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.Label();
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmed,
            this.surnameworker,
            this.nameworker,
            this.oldnameworker,
            this.idanimal,
            this.nameanimal,
            this.datemed,
            this.result});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(985, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // idmed
            // 
            this.idmed.DataPropertyName = "idmed";
            this.idmed.HeaderText = "idmedicine";
            this.idmed.MinimumWidth = 8;
            this.idmed.Name = "idmed";
            this.idmed.ReadOnly = true;
            this.idmed.Visible = false;
            // 
            // surnameworker
            // 
            this.surnameworker.DataPropertyName = "surnameworker";
            this.surnameworker.HeaderText = "Фамилия работника";
            this.surnameworker.MinimumWidth = 8;
            this.surnameworker.Name = "surnameworker";
            this.surnameworker.ReadOnly = true;
            // 
            // nameworker
            // 
            this.nameworker.DataPropertyName = "nameworker";
            this.nameworker.HeaderText = "Имя работника";
            this.nameworker.MinimumWidth = 8;
            this.nameworker.Name = "nameworker";
            this.nameworker.ReadOnly = true;
            // 
            // oldnameworker
            // 
            this.oldnameworker.DataPropertyName = "oldnameworker";
            this.oldnameworker.HeaderText = "Отчество работника";
            this.oldnameworker.MinimumWidth = 8;
            this.oldnameworker.Name = "oldnameworker";
            this.oldnameworker.ReadOnly = true;
            // 
            // idanimal
            // 
            this.idanimal.DataPropertyName = "idanimal";
            this.idanimal.HeaderText = "Номер животного";
            this.idanimal.MinimumWidth = 8;
            this.idanimal.Name = "idanimal";
            this.idanimal.ReadOnly = true;
            // 
            // nameanimal
            // 
            this.nameanimal.DataPropertyName = "nameanimal";
            this.nameanimal.HeaderText = "Название животного";
            this.nameanimal.MinimumWidth = 8;
            this.nameanimal.Name = "nameanimal";
            this.nameanimal.ReadOnly = true;
            // 
            // datemed
            // 
            this.datemed.DataPropertyName = "datemed";
            this.datemed.HeaderText = "Дата";
            this.datemed.MinimumWidth = 8;
            this.datemed.Name = "datemed";
            this.datemed.ReadOnly = true;
            // 
            // result
            // 
            this.result.DataPropertyName = "result";
            this.result.HeaderText = "Результат";
            this.result.MinimumWidth = 8;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(836, 142);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 62);
            this.buttonDel.TabIndex = 21;
            this.buttonDel.Text = "Удалить запись";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.textBoxResult);
            this.groupBoxAdd.Controls.Add(this.dateTimePicker1);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.comboBoxAnimal);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.comboBoxWorker);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Location = new System.Drawing.Point(9, 141);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(320, 293);
            this.groupBoxAdd.TabIndex = 24;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(5, 251);
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
            this.buttonAddNo.Location = new System.Drawing.Point(175, 251);
            this.buttonAddNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddNo.Name = "buttonAddNo";
            this.buttonAddNo.Size = new System.Drawing.Size(139, 33);
            this.buttonAddNo.TabIndex = 34;
            this.buttonAddNo.Text = "Отмена";
            this.buttonAddNo.UseVisualStyleBackColor = true;
            this.buttonAddNo.Click += new System.EventHandler(this.buttonAddNo_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(5, 218);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(309, 27);
            this.textBoxResult.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Дата";
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
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.textBoxNameAnimalS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxSurnameS);
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Location = new System.Drawing.Point(333, 142);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(328, 186);
            this.groupBoxSearch.TabIndex = 25;
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
            // textBoxNameAnimalS
            // 
            this.textBoxNameAnimalS.Location = new System.Drawing.Point(5, 109);
            this.textBoxNameAnimalS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNameAnimalS.Name = "textBoxNameAnimalS";
            this.textBoxNameAnimalS.Size = new System.Drawing.Size(309, 27);
            this.textBoxNameAnimalS.TabIndex = 7;
            this.textBoxNameAnimalS.TextChanged += new System.EventHandler(this.textBoxNameAnimalS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 85);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Животное";
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
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(5, 29);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(85, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Работник";
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.button9);
            this.groupBoxTable.Controls.Add(this.button6);
            this.groupBoxTable.Controls.Add(this.button7);
            this.groupBoxTable.Controls.Add(this.button8);
            this.groupBoxTable.Location = new System.Drawing.Point(9, 440);
            this.groupBoxTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxTable.Size = new System.Drawing.Size(985, 101);
            this.groupBoxTable.TabIndex = 26;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Дополнительные данные";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(329, 26);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(158, 62);
            this.button9.TabIndex = 49;
            this.button9.Text = "Перенесенные болезни";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(491, 26);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 62);
            this.button7.TabIndex = 46;
            this.button7.Text = "Справочник болезней";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(5, 26);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 62);
            this.button6.TabIndex = 47;
            this.button6.Text = "Справочник прививок";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(167, 26);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 62);
            this.button8.TabIndex = 48;
            this.button8.Text = "Поставленные прививки";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // MedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1000, 552);
            this.Controls.Add(this.groupBoxTable);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "MedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedForm";
            this.Load += new System.EventHandler(this.MedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearchNo;
        private System.Windows.Forms.TextBox textBoxNameAnimalS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxSurnameS;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldnameworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameanimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemed;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}