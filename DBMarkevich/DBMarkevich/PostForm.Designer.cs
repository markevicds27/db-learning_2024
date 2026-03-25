namespace DBMarkevich
{
    partial class PostForm
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
            this.textBoxDostS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchNo = new System.Windows.Forms.Button();
            this.textBoxTypeS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxNameS = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxSrok = new System.Windows.Forms.TextBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDost = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ензузщые = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostavka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxDostS);
            this.groupBoxSearch.Controls.Add(this.label3);
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.textBoxTypeS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxNameS);
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Location = new System.Drawing.Point(343, 181);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(320, 250);
            this.groupBoxSearch.TabIndex = 32;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // textBoxDostS
            // 
            this.textBoxDostS.Location = new System.Drawing.Point(7, 170);
            this.textBoxDostS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDostS.Name = "textBoxDostS";
            this.textBoxDostS.Size = new System.Drawing.Size(309, 27);
            this.textBoxDostS.TabIndex = 36;
            this.textBoxDostS.TextChanged += new System.EventHandler(this.textBoxDostS_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Срок выполнения";
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(177, 203);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            // 
            // textBoxTypeS
            // 
            this.textBoxTypeS.Location = new System.Drawing.Point(6, 114);
            this.textBoxTypeS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxTypeS.Name = "textBoxTypeS";
            this.textBoxTypeS.Size = new System.Drawing.Size(309, 27);
            this.textBoxTypeS.TabIndex = 7;
            this.textBoxTypeS.TextChanged += new System.EventHandler(this.textBoxTypeS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 89);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Тип";
            // 
            // textBoxNameS
            // 
            this.textBoxNameS.Location = new System.Drawing.Point(6, 56);
            this.textBoxNameS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNameS.Name = "textBoxNameS";
            this.textBoxNameS.Size = new System.Drawing.Size(309, 27);
            this.textBoxNameS.TabIndex = 3;
            this.textBoxNameS.TextChanged += new System.EventHandler(this.textBoxNameS_TextChanged);
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(6, 30);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(87, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Название";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxSrok);
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.comboBoxType);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.comboBoxDost);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Location = new System.Drawing.Point(15, 181);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(324, 317);
            this.groupBoxAdd.TabIndex = 31;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // textBoxSrok
            // 
            this.textBoxSrok.Location = new System.Drawing.Point(6, 234);
            this.textBoxSrok.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSrok.Name = "textBoxSrok";
            this.textBoxSrok.Size = new System.Drawing.Size(309, 27);
            this.textBoxSrok.TabIndex = 36;
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(4, 267);
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
            this.buttonAddNo.Location = new System.Drawing.Point(176, 267);
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
            this.label2.Location = new System.Drawing.Point(6, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Срок выполнения";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(4, 53);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(309, 27);
            this.textBoxName.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Наличие лоставки";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Ферма",
            "Завод",
            "ИП"});
            this.comboBoxType.Location = new System.Drawing.Point(6, 110);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(309, 29);
            this.comboBoxType.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Тип";
            // 
            // comboBoxDost
            // 
            this.comboBoxDost.FormattingEnabled = true;
            this.comboBoxDost.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxDost.Location = new System.Drawing.Point(6, 171);
            this.comboBoxDost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxDost.Name = "comboBoxDost";
            this.comboBoxDost.Size = new System.Drawing.Size(309, 29);
            this.comboBoxDost.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Название";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(667, 181);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(176, 65);
            this.buttonDel.TabIndex = 30;
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
            this.idpost,
            this.namepost,
            this.ензузщые,
            this.dostavka,
            this.srok});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(828, 161);
            this.dataGridView1.TabIndex = 29;
            // 
            // idpost
            // 
            this.idpost.DataPropertyName = "idpost";
            this.idpost.HeaderText = "idpost";
            this.idpost.MinimumWidth = 8;
            this.idpost.Name = "idpost";
            this.idpost.ReadOnly = true;
            this.idpost.Visible = false;
            // 
            // namepost
            // 
            this.namepost.DataPropertyName = "namepost";
            this.namepost.HeaderText = "Название";
            this.namepost.MinimumWidth = 8;
            this.namepost.Name = "namepost";
            this.namepost.ReadOnly = true;
            // 
            // ензузщые
            // 
            this.ензузщые.DataPropertyName = "typepost";
            this.ензузщые.HeaderText = "Тип";
            this.ензузщые.MinimumWidth = 8;
            this.ензузщые.Name = "ензузщые";
            this.ензузщые.ReadOnly = true;
            // 
            // dostavka
            // 
            this.dostavka.DataPropertyName = "dostavka";
            this.dostavka.HeaderText = "Наличие доставки";
            this.dostavka.MinimumWidth = 8;
            this.dostavka.Name = "dostavka";
            this.dostavka.ReadOnly = true;
            // 
            // srok
            // 
            this.srok.DataPropertyName = "srok";
            this.srok.HeaderText = "Срок выполнения";
            this.srok.MinimumWidth = 8;
            this.srok.Name = "srok";
            this.srok.ReadOnly = true;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(854, 507);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostForm";
            this.Load += new System.EventHandler(this.PostForm_Load);
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
        private System.Windows.Forms.TextBox textBoxTypeS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxNameS;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpost;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ензузщые;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn srok;
        private System.Windows.Forms.TextBox textBoxDostS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSrok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
    }
}