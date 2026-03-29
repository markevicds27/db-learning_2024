namespace DBZhuk
{
    partial class TrForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idSportsmanm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citySportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStaz = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddTr = new System.Windows.Forms.Button();
            this.buttonSpm = new System.Windows.Forms.Button();
            this.buttonScl = new System.Windows.Forms.Button();
            this.buttonDelTr = new System.Windows.Forms.Button();
            this.idTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stazTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrener,
            this.sNameTrener,
            this.nameTrener,
            this.pNameTrener,
            this.genderTrener,
            this.ageTrener,
            this.stazTrener,
            this.nameSport,
            this.sportTrener});
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1455, 266);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSportsmanm,
            this.sNameSportsman,
            this.nameSportsman,
            this.pNameSportsman,
            this.genderSportsman,
            this.ageSportsman});
            this.dataGridView2.Location = new System.Drawing.Point(12, 414);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1455, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // idSportsmanm
            // 
            this.idSportsmanm.DataPropertyName = "idSportsman";
            this.idSportsmanm.HeaderText = "idSportsman";
            this.idSportsmanm.MinimumWidth = 8;
            this.idSportsmanm.Name = "idSportsmanm";
            this.idSportsmanm.ReadOnly = true;
            this.idSportsmanm.Visible = false;
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSportclub,
            this.nameSportclub,
            this.citySportclub});
            this.dataGridView3.Location = new System.Drawing.Point(12, 590);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1455, 150);
            this.dataGridView3.TabIndex = 5;
            // 
            // idSportclub
            // 
            this.idSportclub.DataPropertyName = "idSportclub";
            this.idSportclub.HeaderText = "idSportclub";
            this.idSportclub.MinimumWidth = 8;
            this.idSportclub.Name = "idSportclub";
            this.idSportclub.ReadOnly = true;
            this.idSportclub.Visible = false;
            // 
            // nameSportclub
            // 
            this.nameSportclub.DataPropertyName = "nameSportclub";
            this.nameSportclub.HeaderText = "Название";
            this.nameSportclub.MinimumWidth = 8;
            this.nameSportclub.Name = "nameSportclub";
            this.nameSportclub.ReadOnly = true;
            // 
            // citySportclub
            // 
            this.citySportclub.DataPropertyName = "citySportclub";
            this.citySportclub.HeaderText = "Город";
            this.citySportclub.MinimumWidth = 8;
            this.citySportclub.Name = "citySportclub";
            this.citySportclub.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxSport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxStaz);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1455, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1247, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вид спорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1041, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Стаж";
            // 
            // textBoxSport
            // 
            this.textBoxSport.Location = new System.Drawing.Point(1246, 49);
            this.textBoxSport.Name = "textBoxSport";
            this.textBoxSport.Size = new System.Drawing.Size(200, 26);
            this.textBoxSport.TabIndex = 10;
            this.textBoxSport.TextChanged += new System.EventHandler(this.textBoxSport_TextChanged);
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
            // textBoxStaz
            // 
            this.textBoxStaz.Location = new System.Drawing.Point(1040, 49);
            this.textBoxStaz.Name = "textBoxStaz";
            this.textBoxStaz.Size = new System.Drawing.Size(200, 26);
            this.textBoxStaz.TabIndex = 8;
            this.textBoxStaz.TextChanged += new System.EventHandler(this.textBoxStaz_TextChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Тренеруемые спортсмены";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Тренеруемые спортклубы";
            // 
            // buttonAddTr
            // 
            this.buttonAddTr.Location = new System.Drawing.Point(1473, 118);
            this.buttonAddTr.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonAddTr.Name = "buttonAddTr";
            this.buttonAddTr.Size = new System.Drawing.Size(195, 79);
            this.buttonAddTr.TabIndex = 15;
            this.buttonAddTr.Text = "Офрмить тренера";
            this.buttonAddTr.UseVisualStyleBackColor = true;
            this.buttonAddTr.Click += new System.EventHandler(this.buttonAddTr_Click);
            // 
            // buttonSpm
            // 
            this.buttonSpm.Location = new System.Drawing.Point(1473, 414);
            this.buttonSpm.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonSpm.Name = "buttonSpm";
            this.buttonSpm.Size = new System.Drawing.Size(195, 79);
            this.buttonSpm.TabIndex = 16;
            this.buttonSpm.Text = "Управление спортсменами";
            this.buttonSpm.UseVisualStyleBackColor = true;
            this.buttonSpm.Click += new System.EventHandler(this.buttonSpm_Click);
            // 
            // buttonScl
            // 
            this.buttonScl.Location = new System.Drawing.Point(1473, 590);
            this.buttonScl.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonScl.Name = "buttonScl";
            this.buttonScl.Size = new System.Drawing.Size(195, 79);
            this.buttonScl.TabIndex = 17;
            this.buttonScl.Text = "Управление спортклубами";
            this.buttonScl.UseVisualStyleBackColor = true;
            this.buttonScl.Click += new System.EventHandler(this.buttonScl_Click);
            // 
            // buttonDelTr
            // 
            this.buttonDelTr.Location = new System.Drawing.Point(1473, 199);
            this.buttonDelTr.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonDelTr.Name = "buttonDelTr";
            this.buttonDelTr.Size = new System.Drawing.Size(195, 79);
            this.buttonDelTr.TabIndex = 18;
            this.buttonDelTr.Text = "Удалить тренера";
            this.buttonDelTr.UseVisualStyleBackColor = true;
            this.buttonDelTr.Click += new System.EventHandler(this.buttonDelTr_Click);
            // 
            // idTrener
            // 
            this.idTrener.DataPropertyName = "idTrener";
            this.idTrener.HeaderText = "idTrener";
            this.idTrener.MinimumWidth = 8;
            this.idTrener.Name = "idTrener";
            this.idTrener.ReadOnly = true;
            this.idTrener.Visible = false;
            // 
            // sNameTrener
            // 
            this.sNameTrener.DataPropertyName = "sNameTrener";
            this.sNameTrener.HeaderText = "Фамилия";
            this.sNameTrener.MinimumWidth = 8;
            this.sNameTrener.Name = "sNameTrener";
            this.sNameTrener.ReadOnly = true;
            // 
            // nameTrener
            // 
            this.nameTrener.DataPropertyName = "nameTrener";
            this.nameTrener.HeaderText = "Имя";
            this.nameTrener.MinimumWidth = 8;
            this.nameTrener.Name = "nameTrener";
            this.nameTrener.ReadOnly = true;
            // 
            // pNameTrener
            // 
            this.pNameTrener.DataPropertyName = "pNameTrener";
            this.pNameTrener.HeaderText = "Отчетсво";
            this.pNameTrener.MinimumWidth = 8;
            this.pNameTrener.Name = "pNameTrener";
            this.pNameTrener.ReadOnly = true;
            // 
            // genderTrener
            // 
            this.genderTrener.DataPropertyName = "genderTrener";
            this.genderTrener.HeaderText = "Пол";
            this.genderTrener.MinimumWidth = 8;
            this.genderTrener.Name = "genderTrener";
            this.genderTrener.ReadOnly = true;
            // 
            // ageTrener
            // 
            this.ageTrener.DataPropertyName = "ageTrener";
            this.ageTrener.HeaderText = "Возраст";
            this.ageTrener.MinimumWidth = 8;
            this.ageTrener.Name = "ageTrener";
            this.ageTrener.ReadOnly = true;
            // 
            // stazTrener
            // 
            this.stazTrener.DataPropertyName = "stazTrener";
            this.stazTrener.HeaderText = "Стаж";
            this.stazTrener.MinimumWidth = 8;
            this.stazTrener.Name = "stazTrener";
            this.stazTrener.ReadOnly = true;
            // 
            // nameSport
            // 
            this.nameSport.DataPropertyName = "nameSport";
            this.nameSport.HeaderText = "Вид спорта";
            this.nameSport.MinimumWidth = 8;
            this.nameSport.Name = "nameSport";
            this.nameSport.ReadOnly = true;
            // 
            // sportTrener
            // 
            this.sportTrener.DataPropertyName = "sportTrener";
            this.sportTrener.HeaderText = "sportTrener";
            this.sportTrener.MinimumWidth = 8;
            this.sportTrener.Name = "sportTrener";
            this.sportTrener.ReadOnly = true;
            this.sportTrener.Visible = false;
            // 
            // TrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 750);
            this.Controls.Add(this.buttonDelTr);
            this.Controls.Add(this.buttonScl);
            this.Controls.Add(this.buttonSpm);
            this.Controls.Add(this.buttonAddTr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TrForm";
            this.Text = "TrForm";
            this.Load += new System.EventHandler(this.TrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStaz;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddTr;
        private System.Windows.Forms.Button buttonSpm;
        private System.Windows.Forms.Button buttonScl;
        private System.Windows.Forms.Button buttonDelTr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportsmanm;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn citySportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn stazTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportTrener;
    }
}