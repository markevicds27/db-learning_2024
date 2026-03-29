namespace DBZhuk
{
    partial class SpmFrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonEditYes = new System.Windows.Forms.Button();
            this.buttonEditNo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSurnameE = new System.Windows.Forms.TextBox();
            this.comboBoxGenderE = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNameE = new System.Windows.Forms.TextBox();
            this.textBoxAgeE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPatronE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView111 = new System.Windows.Forms.DataGridView();
            this.idSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView111)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSname);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Все"});
            this.comboBoxGender.Location = new System.Drawing.Point(627, 47);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(200, 28);
            this.comboBoxGender.TabIndex = 8;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возраст";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(834, 49);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(200, 26);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // textBoxPname
            // 
            this.textBoxPname.Location = new System.Drawing.Point(421, 49);
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(200, 26);
            this.textBoxPname.TabIndex = 4;
            this.textBoxPname.TextChanged += new System.EventHandler(this.textBoxPname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(215, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 26);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(9, 49);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(200, 26);
            this.textBoxSname.TabIndex = 0;
            this.textBoxSname.TextChanged += new System.EventHandler(this.textBoxSname_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 70);
            this.button1.TabIndex = 12;
            this.button1.Text = "Закрепленные тренера";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 70);
            this.button2.TabIndex = 13;
            this.button2.Text = "Оформить спортсмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 70);
            this.button3.TabIndex = 14;
            this.button3.Text = "Удалить данные о спортсмене";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(274, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 70);
            this.button4.TabIndex = 15;
            this.button4.Text = "Изменить данные о спортсмене";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonEditYes);
            this.groupBoxEdit.Controls.Add(this.buttonEditNo);
            this.groupBoxEdit.Controls.Add(this.label7);
            this.groupBoxEdit.Controls.Add(this.textBoxSurnameE);
            this.groupBoxEdit.Controls.Add(this.comboBoxGenderE);
            this.groupBoxEdit.Controls.Add(this.label11);
            this.groupBoxEdit.Controls.Add(this.label8);
            this.groupBoxEdit.Controls.Add(this.textBoxNameE);
            this.groupBoxEdit.Controls.Add(this.textBoxAgeE);
            this.groupBoxEdit.Controls.Add(this.label10);
            this.groupBoxEdit.Controls.Add(this.label9);
            this.groupBoxEdit.Controls.Add(this.textBoxPatronE);
            this.groupBoxEdit.Location = new System.Drawing.Point(12, 429);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(1041, 129);
            this.groupBoxEdit.TabIndex = 17;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование данных";
            // 
            // buttonEditYes
            // 
            this.buttonEditYes.Location = new System.Drawing.Point(728, 88);
            this.buttonEditYes.Name = "buttonEditYes";
            this.buttonEditYes.Size = new System.Drawing.Size(150, 35);
            this.buttonEditYes.TabIndex = 27;
            this.buttonEditYes.Text = "Изменить";
            this.buttonEditYes.UseVisualStyleBackColor = true;
            this.buttonEditYes.Click += new System.EventHandler(this.buttonEditYes_Click);
            // 
            // buttonEditNo
            // 
            this.buttonEditNo.Location = new System.Drawing.Point(884, 88);
            this.buttonEditNo.Name = "buttonEditNo";
            this.buttonEditNo.Size = new System.Drawing.Size(150, 35);
            this.buttonEditNo.TabIndex = 26;
            this.buttonEditNo.Text = "Отмена";
            this.buttonEditNo.UseVisualStyleBackColor = true;
            this.buttonEditNo.Click += new System.EventHandler(this.buttonEditNo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Пол";
            // 
            // textBoxSurnameE
            // 
            this.textBoxSurnameE.Location = new System.Drawing.Point(9, 54);
            this.textBoxSurnameE.Name = "textBoxSurnameE";
            this.textBoxSurnameE.Size = new System.Drawing.Size(200, 26);
            this.textBoxSurnameE.TabIndex = 10;
            // 
            // comboBoxGenderE
            // 
            this.comboBoxGenderE.FormattingEnabled = true;
            this.comboBoxGenderE.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Все"});
            this.comboBoxGenderE.Location = new System.Drawing.Point(627, 52);
            this.comboBoxGenderE.Name = "comboBoxGenderE";
            this.comboBoxGenderE.Size = new System.Drawing.Size(200, 28);
            this.comboBoxGenderE.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(835, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Возраст";
            // 
            // textBoxNameE
            // 
            this.textBoxNameE.Location = new System.Drawing.Point(215, 54);
            this.textBoxNameE.Name = "textBoxNameE";
            this.textBoxNameE.Size = new System.Drawing.Size(200, 26);
            this.textBoxNameE.TabIndex = 12;
            // 
            // textBoxAgeE
            // 
            this.textBoxAgeE.Location = new System.Drawing.Point(834, 54);
            this.textBoxAgeE.Name = "textBoxAgeE";
            this.textBoxAgeE.Size = new System.Drawing.Size(200, 26);
            this.textBoxAgeE.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Отчество";
            // 
            // textBoxPatronE
            // 
            this.textBoxPatronE.Location = new System.Drawing.Point(421, 54);
            this.textBoxPatronE.Name = "textBoxPatronE";
            this.textBoxPatronE.Size = new System.Drawing.Size(200, 26);
            this.textBoxPatronE.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите вид спорта";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1041, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView111
            // 
            this.dataGridView111.AllowUserToAddRows = false;
            this.dataGridView111.AllowUserToDeleteRows = false;
            this.dataGridView111.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView111.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView111.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSportsman,
            this.sNameSportsman,
            this.nameSportsman,
            this.pNameSportsman,
            this.genderSportsman,
            this.ageSportsman,
            this.idSport,
            this.nameSport});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView111.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView111.Location = new System.Drawing.Point(12, 165);
            this.dataGridView111.Name = "dataGridView111";
            this.dataGridView111.ReadOnly = true;
            this.dataGridView111.RowHeadersWidth = 62;
            this.dataGridView111.RowTemplate.Height = 28;
            this.dataGridView111.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView111.Size = new System.Drawing.Size(1042, 258);
            this.dataGridView111.TabIndex = 19;
            // 
            // idSportsman
            // 
            this.idSportsman.DataPropertyName = "idSportsman";
            this.idSportsman.HeaderText = "idSportsman";
            this.idSportsman.MinimumWidth = 8;
            this.idSportsman.Name = "idSportsman";
            this.idSportsman.ReadOnly = true;
            this.idSportsman.Visible = false;
            // 
            // sNameSportsman
            // 
            this.sNameSportsman.DataPropertyName = "sNameSportsman";
            this.sNameSportsman.HeaderText = "Фамилия";
            this.sNameSportsman.MinimumWidth = 8;
            this.sNameSportsman.Name = "sNameSportsman";
            this.sNameSportsman.ReadOnly = true;
            // 
            // nameSportsman
            // 
            this.nameSportsman.DataPropertyName = "nameSportsman";
            this.nameSportsman.HeaderText = "Имя";
            this.nameSportsman.MinimumWidth = 8;
            this.nameSportsman.Name = "nameSportsman";
            this.nameSportsman.ReadOnly = true;
            // 
            // pNameSportsman
            // 
            this.pNameSportsman.DataPropertyName = "pNameSportsman";
            this.pNameSportsman.HeaderText = "Отчество";
            this.pNameSportsman.MinimumWidth = 8;
            this.pNameSportsman.Name = "pNameSportsman";
            this.pNameSportsman.ReadOnly = true;
            // 
            // genderSportsman
            // 
            this.genderSportsman.DataPropertyName = "genderSportsman";
            this.genderSportsman.HeaderText = "Пол";
            this.genderSportsman.MinimumWidth = 8;
            this.genderSportsman.Name = "genderSportsman";
            this.genderSportsman.ReadOnly = true;
            // 
            // ageSportsman
            // 
            this.ageSportsman.DataPropertyName = "ageSportsman";
            this.ageSportsman.HeaderText = "Возраст";
            this.ageSportsman.MinimumWidth = 8;
            this.ageSportsman.Name = "ageSportsman";
            this.ageSportsman.ReadOnly = true;
            // 
            // idSport
            // 
            this.idSport.DataPropertyName = "idSport";
            this.idSport.HeaderText = "idSport";
            this.idSport.MinimumWidth = 8;
            this.idSport.Name = "idSport";
            this.idSport.ReadOnly = true;
            this.idSport.Visible = false;
            // 
            // nameSport
            // 
            this.nameSport.DataPropertyName = "nameSport";
            this.nameSport.HeaderText = "Вид спорта";
            this.nameSport.MinimumWidth = 8;
            this.nameSport.Name = "nameSport";
            this.nameSport.ReadOnly = true;
            // 
            // SpmFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 970);
            this.Controls.Add(this.dataGridView111);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEdit);
            this.Name = "SpmFrom";
            this.Text = "SpmFrom";
            this.Load += new System.EventHandler(this.SpmFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView111)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGenderE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAgeE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPatronE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSurnameE;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonEditYes;
        private System.Windows.Forms.Button buttonEditNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView111;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSport;
    }
}