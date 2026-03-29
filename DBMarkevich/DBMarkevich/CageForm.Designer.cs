namespace DBMarkevich
{
    partial class CageForm
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchNo = new System.Windows.Forms.Button();
            this.textBoxNatureS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxTypeS = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.Label();
            this.textBoxSeasonS = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.textBoxSeason = new System.Windows.Forms.TextBox();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNature = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.textBoxNatureS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxTypeS);
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Controls.Add(this.textBoxSeasonS);
            this.groupBoxSearch.Controls.Add(this.label29);
            this.groupBoxSearch.Location = new System.Drawing.Point(346, 146);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(320, 241);
            this.groupBoxSearch.TabIndex = 27;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(175, 198);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            // 
            // textBoxNatureS
            // 
            this.textBoxNatureS.Location = new System.Drawing.Point(5, 109);
            this.textBoxNatureS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNatureS.Name = "textBoxNatureS";
            this.textBoxNatureS.Size = new System.Drawing.Size(309, 27);
            this.textBoxNatureS.TabIndex = 7;
            this.textBoxNatureS.TextChanged += new System.EventHandler(this.textBoxNatureS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 85);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Природа";
            // 
            // textBoxTypeS
            // 
            this.textBoxTypeS.Location = new System.Drawing.Point(5, 53);
            this.textBoxTypeS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxTypeS.Name = "textBoxTypeS";
            this.textBoxTypeS.Size = new System.Drawing.Size(309, 27);
            this.textBoxTypeS.TabIndex = 3;
            this.textBoxTypeS.TextChanged += new System.EventHandler(this.textBoxTypeS_TextChanged);
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(5, 29);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(38, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Тип";
            // 
            // textBoxSeasonS
            // 
            this.textBoxSeasonS.Location = new System.Drawing.Point(5, 165);
            this.textBoxSeasonS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSeasonS.Name = "textBoxSeasonS";
            this.textBoxSeasonS.Size = new System.Drawing.Size(309, 27);
            this.textBoxSeasonS.TabIndex = 5;
            this.textBoxSeasonS.TextChanged += new System.EventHandler(this.textBoxSeasonS_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 141);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 21);
            this.label29.TabIndex = 4;
            this.label29.Text = "Сезоны";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.textBoxSeason);
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.textBoxNature);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.comboBoxType);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Location = new System.Drawing.Point(14, 146);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(328, 302);
            this.groupBoxAdd.TabIndex = 26;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(0, 254);
            this.buttonAddOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(139, 33);
            this.buttonAddOk.TabIndex = 33;
            this.buttonAddOk.Text = "Добавить";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // textBoxSeason
            // 
            this.textBoxSeason.Location = new System.Drawing.Point(5, 221);
            this.textBoxSeason.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSeason.Name = "textBoxSeason";
            this.textBoxSeason.Size = new System.Drawing.Size(309, 27);
            this.textBoxSeason.TabIndex = 38;
            // 
            // buttonAddNo
            // 
            this.buttonAddNo.Location = new System.Drawing.Point(174, 254);
            this.buttonAddNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddNo.Name = "buttonAddNo";
            this.buttonAddNo.Size = new System.Drawing.Size(139, 33);
            this.buttonAddNo.TabIndex = 34;
            this.buttonAddNo.Text = "Отмена";
            this.buttonAddNo.UseVisualStyleBackColor = true;
            this.buttonAddNo.Click += new System.EventHandler(this.buttonAddNo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Сезоны";
            // 
            // textBoxNature
            // 
            this.textBoxNature.Location = new System.Drawing.Point(5, 164);
            this.textBoxNature.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNature.Name = "textBoxNature";
            this.textBoxNature.Size = new System.Drawing.Size(309, 27);
            this.textBoxNature.TabIndex = 36;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(4, 51);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(309, 27);
            this.textBoxName.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Природа\r\n";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Пастбище",
            "Вольер",
            "Террариум",
            "Аквариум",
            "Птичник"});
            this.comboBoxType.Location = new System.Drawing.Point(5, 105);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(309, 29);
            this.comboBoxType.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Тип";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Название";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcage,
            this.namecage,
            this.typecage,
            this.nature,
            this.season});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 126);
            this.dataGridView1.TabIndex = 24;
            // 
            // idcage
            // 
            this.idcage.DataPropertyName = "idcage";
            this.idcage.HeaderText = "Номер";
            this.idcage.MinimumWidth = 8;
            this.idcage.Name = "idcage";
            this.idcage.ReadOnly = true;
            // 
            // namecage
            // 
            this.namecage.DataPropertyName = "namecage";
            this.namecage.HeaderText = "Название";
            this.namecage.MinimumWidth = 8;
            this.namecage.Name = "namecage";
            this.namecage.ReadOnly = true;
            // 
            // typecage
            // 
            this.typecage.DataPropertyName = "typecage";
            this.typecage.HeaderText = "Тип";
            this.typecage.MinimumWidth = 8;
            this.typecage.Name = "typecage";
            this.typecage.ReadOnly = true;
            // 
            // nature
            // 
            this.nature.DataPropertyName = "nature";
            this.nature.HeaderText = "Природа";
            this.nature.MinimumWidth = 8;
            this.nature.Name = "nature";
            this.nature.ReadOnly = true;
            // 
            // season
            // 
            this.season.DataPropertyName = "season";
            this.season.HeaderText = "Сезоны";
            this.season.MinimumWidth = 8;
            this.season.Name = "season";
            this.season.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(670, 146);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 62);
            this.button5.TabIndex = 44;
            this.button5.Text = "Уборка клеток";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(841, 454);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "CageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CageForm";
            this.Load += new System.EventHandler(this.CageForm_Load);
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
        private System.Windows.Forms.TextBox textBoxNatureS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxSeasonS;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxTypeS;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox textBoxSeason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNature;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcage;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecage;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn season;
        private System.Windows.Forms.Button button5;
    }
}