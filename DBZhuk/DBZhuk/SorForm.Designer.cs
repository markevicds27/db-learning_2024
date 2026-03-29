namespace DBZhuk
{
    partial class SorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSor = new System.Windows.Forms.DataGridView();
            this.idSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinishSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.dataGridViewSt = new System.Windows.Forms.DataGridView();
            this.idSorevnovanieStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearchSport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxSearchTypr = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrg = new System.Windows.Forms.DataGridView();
            this.idSorevnovanieOrganizator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOrganizator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOrganizator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonAddSor = new System.Windows.Forms.Button();
            this.buttonDelSor = new System.Windows.Forms.Button();
            this.buttonAddSt = new System.Windows.Forms.Button();
            this.groupBoxAddSt = new System.Windows.Forms.GroupBox();
            this.dateTimePickerSt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddStNo = new System.Windows.Forms.Button();
            this.buttonAddStYes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddOrg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxAddOrg = new System.Windows.Forms.GroupBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxOrg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddOrgNo = new System.Windows.Forms.Button();
            this.buttonAddOrgYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSt)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrg)).BeginInit();
            this.groupBoxAddSt.SuspendLayout();
            this.groupBoxAddOrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSor
            // 
            this.dataGridViewSor.AllowUserToAddRows = false;
            this.dataGridViewSor.AllowUserToDeleteRows = false;
            this.dataGridViewSor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSorevnovanie,
            this.nameSorevnovanie,
            this.sportSorevnovanie,
            this.nameSport,
            this.typeSorevnovanie,
            this.nameType,
            this.dateStartSorevnovanie,
            this.dateFinishSorevnovanie});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSor.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewSor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewSor.Name = "dataGridViewSor";
            this.dataGridViewSor.ReadOnly = true;
            this.dataGridViewSor.RowHeadersWidth = 62;
            this.dataGridViewSor.RowTemplate.Height = 28;
            this.dataGridViewSor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSor.Size = new System.Drawing.Size(1263, 200);
            this.dataGridViewSor.TabIndex = 0;
            this.dataGridViewSor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSor_CellClick_1);
            // 
            // idSorevnovanie
            // 
            this.idSorevnovanie.DataPropertyName = "idSorevnovanie";
            this.idSorevnovanie.HeaderText = "idSorevnovanie";
            this.idSorevnovanie.MinimumWidth = 8;
            this.idSorevnovanie.Name = "idSorevnovanie";
            this.idSorevnovanie.ReadOnly = true;
            this.idSorevnovanie.Visible = false;
            // 
            // nameSorevnovanie
            // 
            this.nameSorevnovanie.DataPropertyName = "nameSorevnovanie";
            this.nameSorevnovanie.HeaderText = "Название";
            this.nameSorevnovanie.MinimumWidth = 8;
            this.nameSorevnovanie.Name = "nameSorevnovanie";
            this.nameSorevnovanie.ReadOnly = true;
            // 
            // sportSorevnovanie
            // 
            this.sportSorevnovanie.DataPropertyName = "sportSorevnovanie";
            this.sportSorevnovanie.HeaderText = "sportSorevnovanie";
            this.sportSorevnovanie.MinimumWidth = 8;
            this.sportSorevnovanie.Name = "sportSorevnovanie";
            this.sportSorevnovanie.ReadOnly = true;
            this.sportSorevnovanie.Visible = false;
            // 
            // nameSport
            // 
            this.nameSport.DataPropertyName = "nameSport";
            this.nameSport.HeaderText = "Вид спорта";
            this.nameSport.MinimumWidth = 8;
            this.nameSport.Name = "nameSport";
            this.nameSport.ReadOnly = true;
            // 
            // typeSorevnovanie
            // 
            this.typeSorevnovanie.DataPropertyName = "typeSorevnovanie";
            this.typeSorevnovanie.HeaderText = "typeSorevnovanie";
            this.typeSorevnovanie.MinimumWidth = 8;
            this.typeSorevnovanie.Name = "typeSorevnovanie";
            this.typeSorevnovanie.ReadOnly = true;
            this.typeSorevnovanie.Visible = false;
            // 
            // nameType
            // 
            this.nameType.DataPropertyName = "nameType";
            this.nameType.HeaderText = "Тип";
            this.nameType.MinimumWidth = 8;
            this.nameType.Name = "nameType";
            this.nameType.ReadOnly = true;
            // 
            // dateStartSorevnovanie
            // 
            this.dateStartSorevnovanie.DataPropertyName = "dateStartSorevnovanie";
            this.dateStartSorevnovanie.HeaderText = "Дата начала";
            this.dateStartSorevnovanie.MinimumWidth = 8;
            this.dateStartSorevnovanie.Name = "dateStartSorevnovanie";
            this.dateStartSorevnovanie.ReadOnly = true;
            // 
            // dateFinishSorevnovanie
            // 
            this.dateFinishSorevnovanie.DataPropertyName = "dateFinishSorevnovanie";
            this.dateFinishSorevnovanie.HeaderText = "Дата конца";
            this.dateFinishSorevnovanie.MinimumWidth = 8;
            this.dateFinishSorevnovanie.Name = "dateFinishSorevnovanie";
            this.dateFinishSorevnovanie.ReadOnly = true;
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.AllowUserToAddRows = false;
            this.dataGridViewPlayer.AllowUserToDeleteRows = false;
            this.dataGridViewPlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlayer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(12, 811);
            this.dataGridViewPlayer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.ReadOnly = true;
            this.dataGridViewPlayer.RowHeadersWidth = 62;
            this.dataGridViewPlayer.RowTemplate.Height = 28;
            this.dataGridViewPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(1263, 200);
            this.dataGridViewPlayer.TabIndex = 2;
            // 
            // dataGridViewSt
            // 
            this.dataGridViewSt.AllowUserToAddRows = false;
            this.dataGridViewSt.AllowUserToDeleteRows = false;
            this.dataGridViewSt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSorevnovanieStadion,
            this.nameStadion,
            this.typeStadion,
            this.date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSt.Location = new System.Drawing.Point(12, 365);
            this.dataGridViewSt.Name = "dataGridViewSt";
            this.dataGridViewSt.ReadOnly = true;
            this.dataGridViewSt.RowHeadersWidth = 62;
            this.dataGridViewSt.RowTemplate.Height = 28;
            this.dataGridViewSt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSt.Size = new System.Drawing.Size(1263, 200);
            this.dataGridViewSt.TabIndex = 3;
            // 
            // idSorevnovanieStadion
            // 
            this.idSorevnovanieStadion.DataPropertyName = "idSorevnovanieStadion";
            this.idSorevnovanieStadion.HeaderText = "idst";
            this.idSorevnovanieStadion.MinimumWidth = 8;
            this.idSorevnovanieStadion.Name = "idSorevnovanieStadion";
            this.idSorevnovanieStadion.ReadOnly = true;
            this.idSorevnovanieStadion.Visible = false;
            // 
            // nameStadion
            // 
            this.nameStadion.DataPropertyName = "nameStadion";
            this.nameStadion.HeaderText = "Место проведения";
            this.nameStadion.MinimumWidth = 8;
            this.nameStadion.Name = "nameStadion";
            this.nameStadion.ReadOnly = true;
            // 
            // typeStadion
            // 
            this.typeStadion.DataPropertyName = "typeStadion";
            this.typeStadion.HeaderText = "Тип";
            this.typeStadion.MinimumWidth = 8;
            this.typeStadion.Name = "typeStadion";
            this.typeStadion.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата проведения";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearchSport);
            this.groupBoxSearch.Controls.Add(this.label11);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchTypr);
            this.groupBoxSearch.Controls.Add(this.label10);
            this.groupBoxSearch.Controls.Add(this.textBoxSearchName);
            this.groupBoxSearch.Controls.Add(this.label9);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxSearch.Size = new System.Drawing.Size(1263, 100);
            this.groupBoxSearch.TabIndex = 4;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // textBoxSearchSport
            // 
            this.textBoxSearchSport.Location = new System.Drawing.Point(362, 52);
            this.textBoxSearchSport.Name = "textBoxSearchSport";
            this.textBoxSearchSport.Size = new System.Drawing.Size(350, 26);
            this.textBoxSearchSport.TabIndex = 35;
            this.textBoxSearchSport.TextChanged += new System.EventHandler(this.textBoxSearchSport_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Вид спорта";
            // 
            // comboBoxSearchTypr
            // 
            this.comboBoxSearchTypr.FormattingEnabled = true;
            this.comboBoxSearchTypr.Items.AddRange(new object[] {
            "Личное первенство",
            "Командный зачет",
            "Все"});
            this.comboBoxSearchTypr.Location = new System.Drawing.Point(718, 52);
            this.comboBoxSearchTypr.Name = "comboBoxSearchTypr";
            this.comboBoxSearchTypr.Size = new System.Drawing.Size(350, 28);
            this.comboBoxSearchTypr.TabIndex = 33;
            this.comboBoxSearchTypr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(714, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Тип";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(6, 52);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(350, 26);
            this.textBoxSearchName.TabIndex = 31;
            this.textBoxSearchName.TextChanged += new System.EventHandler(this.textBoxSearchName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Соревнование";
            // 
            // dataGridViewOrg
            // 
            this.dataGridViewOrg.AllowUserToAddRows = false;
            this.dataGridViewOrg.AllowUserToDeleteRows = false;
            this.dataGridViewOrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSorevnovanieOrganizator,
            this.nameOrganizator,
            this.typeOrganizator,
            this.money});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrg.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrg.Location = new System.Drawing.Point(12, 589);
            this.dataGridViewOrg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewOrg.Name = "dataGridViewOrg";
            this.dataGridViewOrg.ReadOnly = true;
            this.dataGridViewOrg.RowHeadersWidth = 62;
            this.dataGridViewOrg.RowTemplate.Height = 28;
            this.dataGridViewOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrg.Size = new System.Drawing.Size(1263, 200);
            this.dataGridViewOrg.TabIndex = 9;
            // 
            // idSorevnovanieOrganizator
            // 
            this.idSorevnovanieOrganizator.DataPropertyName = "idSorevnovanieOrganizator";
            this.idSorevnovanieOrganizator.HeaderText = "idorg";
            this.idSorevnovanieOrganizator.MinimumWidth = 8;
            this.idSorevnovanieOrganizator.Name = "idSorevnovanieOrganizator";
            this.idSorevnovanieOrganizator.ReadOnly = true;
            this.idSorevnovanieOrganizator.Visible = false;
            // 
            // nameOrganizator
            // 
            this.nameOrganizator.DataPropertyName = "nameOrganizator";
            this.nameOrganizator.HeaderText = "Огранизатор";
            this.nameOrganizator.MinimumWidth = 8;
            this.nameOrganizator.Name = "nameOrganizator";
            this.nameOrganizator.ReadOnly = true;
            // 
            // typeOrganizator
            // 
            this.typeOrganizator.DataPropertyName = "typeOrganizator";
            this.typeOrganizator.HeaderText = "Тип";
            this.typeOrganizator.MinimumWidth = 8;
            this.typeOrganizator.Name = "typeOrganizator";
            this.typeOrganizator.ReadOnly = true;
            // 
            // money
            // 
            this.money.DataPropertyName = "money";
            this.money.HeaderText = "Выделенные средства";
            this.money.MinimumWidth = 8;
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Места проведения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Организаторы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 790);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Участники";
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(1281, 811);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(336, 79);
            this.buttonAddPlayer.TabIndex = 14;
            this.buttonAddPlayer.Text = "Управление участниками";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonAddSor
            // 
            this.buttonAddSor.Location = new System.Drawing.Point(1281, 141);
            this.buttonAddSor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonAddSor.Name = "buttonAddSor";
            this.buttonAddSor.Size = new System.Drawing.Size(336, 79);
            this.buttonAddSor.TabIndex = 15;
            this.buttonAddSor.Text = "Оформить соревнование";
            this.buttonAddSor.UseVisualStyleBackColor = true;
            this.buttonAddSor.Click += new System.EventHandler(this.buttonAddSor_Click);
            // 
            // buttonDelSor
            // 
            this.buttonDelSor.Location = new System.Drawing.Point(1281, 222);
            this.buttonDelSor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonDelSor.Name = "buttonDelSor";
            this.buttonDelSor.Size = new System.Drawing.Size(336, 79);
            this.buttonDelSor.TabIndex = 16;
            this.buttonDelSor.Text = "Удалить соревнование";
            this.buttonDelSor.UseVisualStyleBackColor = true;
            this.buttonDelSor.Click += new System.EventHandler(this.buttonDelSor_Click);
            // 
            // buttonAddSt
            // 
            this.buttonAddSt.Location = new System.Drawing.Point(1281, 365);
            this.buttonAddSt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonAddSt.Name = "buttonAddSt";
            this.buttonAddSt.Size = new System.Drawing.Size(336, 79);
            this.buttonAddSt.TabIndex = 7;
            this.buttonAddSt.Text = "Добавить место проведения";
            this.buttonAddSt.UseVisualStyleBackColor = true;
            this.buttonAddSt.Click += new System.EventHandler(this.buttonAddSt_Click);
            // 
            // groupBoxAddSt
            // 
            this.groupBoxAddSt.Controls.Add(this.dateTimePickerSt);
            this.groupBoxAddSt.Controls.Add(this.label7);
            this.groupBoxAddSt.Controls.Add(this.comboBoxSt);
            this.groupBoxAddSt.Controls.Add(this.label5);
            this.groupBoxAddSt.Controls.Add(this.buttonAddStNo);
            this.groupBoxAddSt.Controls.Add(this.buttonAddStYes);
            this.groupBoxAddSt.Location = new System.Drawing.Point(1282, 365);
            this.groupBoxAddSt.Name = "groupBoxAddSt";
            this.groupBoxAddSt.Size = new System.Drawing.Size(335, 200);
            this.groupBoxAddSt.TabIndex = 18;
            this.groupBoxAddSt.TabStop = false;
            this.groupBoxAddSt.Text = "Добавление места проведения";
            // 
            // dateTimePickerSt
            // 
            this.dateTimePickerSt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSt.Location = new System.Drawing.Point(11, 108);
            this.dateTimePickerSt.Name = "dateTimePickerSt";
            this.dateTimePickerSt.Size = new System.Drawing.Size(318, 26);
            this.dateTimePickerSt.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дата проведения";
            // 
            // comboBoxSt
            // 
            this.comboBoxSt.FormattingEnabled = true;
            this.comboBoxSt.Location = new System.Drawing.Point(11, 50);
            this.comboBoxSt.Name = "comboBoxSt";
            this.comboBoxSt.Size = new System.Drawing.Size(318, 28);
            this.comboBoxSt.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Стадион";
            // 
            // buttonAddStNo
            // 
            this.buttonAddStNo.Location = new System.Drawing.Point(179, 159);
            this.buttonAddStNo.Name = "buttonAddStNo";
            this.buttonAddStNo.Size = new System.Drawing.Size(150, 35);
            this.buttonAddStNo.TabIndex = 23;
            this.buttonAddStNo.Text = "Отмена";
            this.buttonAddStNo.UseVisualStyleBackColor = true;
            this.buttonAddStNo.Click += new System.EventHandler(this.buttonAddStNo_Click);
            // 
            // buttonAddStYes
            // 
            this.buttonAddStYes.Location = new System.Drawing.Point(6, 159);
            this.buttonAddStYes.Name = "buttonAddStYes";
            this.buttonAddStYes.Size = new System.Drawing.Size(150, 35);
            this.buttonAddStYes.TabIndex = 22;
            this.buttonAddStYes.Text = "Добавить";
            this.buttonAddStYes.UseVisualStyleBackColor = true;
            this.buttonAddStYes.Click += new System.EventHandler(this.buttonAddStYes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1281, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 79);
            this.button1.TabIndex = 19;
            this.button1.Text = "Удалить место проведения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddOrg
            // 
            this.buttonAddOrg.Location = new System.Drawing.Point(1281, 588);
            this.buttonAddOrg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonAddOrg.Name = "buttonAddOrg";
            this.buttonAddOrg.Size = new System.Drawing.Size(336, 79);
            this.buttonAddOrg.TabIndex = 13;
            this.buttonAddOrg.Text = "Добавить организатора";
            this.buttonAddOrg.UseVisualStyleBackColor = true;
            this.buttonAddOrg.Click += new System.EventHandler(this.buttonAddOrg_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1281, 710);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 79);
            this.button2.TabIndex = 20;
            this.button2.Text = "Удалить организатора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxAddOrg
            // 
            this.groupBoxAddOrg.Controls.Add(this.textBoxMoney);
            this.groupBoxAddOrg.Controls.Add(this.label8);
            this.groupBoxAddOrg.Controls.Add(this.comboBoxOrg);
            this.groupBoxAddOrg.Controls.Add(this.label6);
            this.groupBoxAddOrg.Controls.Add(this.buttonAddOrgNo);
            this.groupBoxAddOrg.Controls.Add(this.buttonAddOrgYes);
            this.groupBoxAddOrg.Location = new System.Drawing.Point(1282, 589);
            this.groupBoxAddOrg.Name = "groupBoxAddOrg";
            this.groupBoxAddOrg.Size = new System.Drawing.Size(335, 200);
            this.groupBoxAddOrg.TabIndex = 21;
            this.groupBoxAddOrg.TabStop = false;
            this.groupBoxAddOrg.Text = "Добавление организатора";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(11, 107);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(318, 26);
            this.textBoxMoney.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Бюджет";
            // 
            // comboBoxOrg
            // 
            this.comboBoxOrg.FormattingEnabled = true;
            this.comboBoxOrg.Location = new System.Drawing.Point(11, 50);
            this.comboBoxOrg.Name = "comboBoxOrg";
            this.comboBoxOrg.Size = new System.Drawing.Size(318, 28);
            this.comboBoxOrg.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Название";
            // 
            // buttonAddOrgNo
            // 
            this.buttonAddOrgNo.Location = new System.Drawing.Point(179, 159);
            this.buttonAddOrgNo.Name = "buttonAddOrgNo";
            this.buttonAddOrgNo.Size = new System.Drawing.Size(150, 35);
            this.buttonAddOrgNo.TabIndex = 25;
            this.buttonAddOrgNo.Text = "Отмена";
            this.buttonAddOrgNo.UseVisualStyleBackColor = true;
            this.buttonAddOrgNo.Click += new System.EventHandler(this.buttonAddOrgNo_Click);
            // 
            // buttonAddOrgYes
            // 
            this.buttonAddOrgYes.Location = new System.Drawing.Point(6, 159);
            this.buttonAddOrgYes.Name = "buttonAddOrgYes";
            this.buttonAddOrgYes.Size = new System.Drawing.Size(150, 35);
            this.buttonAddOrgYes.TabIndex = 24;
            this.buttonAddOrgYes.Text = "Добавить";
            this.buttonAddOrgYes.UseVisualStyleBackColor = true;
            this.buttonAddOrgYes.Click += new System.EventHandler(this.buttonAddOrgYes_Click);
            // 
            // SorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 1021);
            this.Controls.Add(this.groupBoxAddSt);
            this.Controls.Add(this.groupBoxAddOrg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelSor);
            this.Controls.Add(this.buttonAddSor);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.buttonAddOrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddSt);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridViewSt);
            this.Controls.Add(this.dataGridViewPlayer);
            this.Controls.Add(this.dataGridViewSor);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "SorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SorForm";
            this.Load += new System.EventHandler(this.SorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSt)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrg)).EndInit();
            this.groupBoxAddSt.ResumeLayout(false);
            this.groupBoxAddSt.PerformLayout();
            this.groupBoxAddOrg.ResumeLayout(false);
            this.groupBoxAddOrg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSor;
        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.DataGridView dataGridViewSt;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Button buttonAddSor;
        private System.Windows.Forms.Button buttonDelSor;
        private System.Windows.Forms.Button buttonAddSt;
        private System.Windows.Forms.GroupBox groupBoxAddSt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddOrg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxAddOrg;
        private System.Windows.Forms.DateTimePicker dateTimePickerSt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddStNo;
        private System.Windows.Forms.Button buttonAddStYes;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxOrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddOrgNo;
        private System.Windows.Forms.Button buttonAddOrgYes;
        private System.Windows.Forms.ComboBox comboBoxSearchTypr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearchSport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSorevnovanieStadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeStadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSorevnovanieOrganizator;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOrganizator;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOrganizator;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSorevnovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSorevnovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportSorevnovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSorevnovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartSorevnovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinishSorevnovanie;
    }
}