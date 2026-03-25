namespace DBMarkevich
{
    partial class FoodForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typefood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charfood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.Название = new System.Windows.Forms.Label();
            this.buttonSearchNo = new System.Windows.Forms.Button();
            this.textBoxNameS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxTypeS = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfood,
            this.namefood,
            this.typefood,
            this.charfood});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(813, 126);
            this.dataGridView1.TabIndex = 33;
            // 
            // idfood
            // 
            this.idfood.DataPropertyName = "idfood";
            this.idfood.HeaderText = "idfood";
            this.idfood.MinimumWidth = 8;
            this.idfood.Name = "idfood";
            this.idfood.ReadOnly = true;
            this.idfood.Visible = false;
            // 
            // namefood
            // 
            this.namefood.DataPropertyName = "namefood";
            this.namefood.HeaderText = "Название";
            this.namefood.MinimumWidth = 8;
            this.namefood.Name = "namefood";
            this.namefood.ReadOnly = true;
            // 
            // typefood
            // 
            this.typefood.DataPropertyName = "typefood";
            this.typefood.HeaderText = "Тип";
            this.typefood.MinimumWidth = 8;
            this.typefood.Name = "typefood";
            this.typefood.ReadOnly = true;
            // 
            // charfood
            // 
            this.charfood.DataPropertyName = "charfood";
            this.charfood.HeaderText = "Описание";
            this.charfood.MinimumWidth = 8;
            this.charfood.Name = "charfood";
            this.charfood.ReadOnly = true;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.comboBoxType);
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.textBoxChar);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Location = new System.Drawing.Point(9, 141);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(325, 238);
            this.groupBoxAdd.TabIndex = 35;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Сухой корм",
            "Живой корм",
            "Комбикорм",
            "Замороженный корм"});
            this.comboBoxType.Location = new System.Drawing.Point(6, 106);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(309, 29);
            this.comboBoxType.TabIndex = 37;
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(5, 192);
            this.buttonAddOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(139, 33);
            this.buttonAddOk.TabIndex = 35;
            this.buttonAddOk.Text = "Добавить";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // buttonAddNo
            // 
            this.buttonAddNo.Location = new System.Drawing.Point(176, 192);
            this.buttonAddNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddNo.Name = "buttonAddNo";
            this.buttonAddNo.Size = new System.Drawing.Size(139, 33);
            this.buttonAddNo.TabIndex = 36;
            this.buttonAddNo.Text = "Отмена";
            this.buttonAddNo.UseVisualStyleBackColor = true;
            this.buttonAddNo.Click += new System.EventHandler(this.buttonAddNo_Click);
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(5, 159);
            this.textBoxChar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(309, 27);
            this.textBoxChar.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Описание";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(5, 52);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(309, 27);
            this.textBoxName.TabIndex = 32;
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
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.textBoxNameS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxTypeS);
            this.groupBoxSearch.Location = new System.Drawing.Point(338, 142);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(322, 186);
            this.groupBoxSearch.TabIndex = 37;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(5, 28);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(87, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Название";
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(178, 141);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            this.buttonSearchNo.Click += new System.EventHandler(this.buttonSearchNo_Click);
            // 
            // textBoxNameS
            // 
            this.textBoxNameS.Location = new System.Drawing.Point(5, 52);
            this.textBoxNameS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNameS.Name = "textBoxNameS";
            this.textBoxNameS.Size = new System.Drawing.Size(309, 27);
            this.textBoxNameS.TabIndex = 3;
            this.textBoxNameS.TextChanged += new System.EventHandler(this.textBoxNameS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 84);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Тип";
            // 
            // textBoxTypeS
            // 
            this.textBoxTypeS.Location = new System.Drawing.Point(5, 108);
            this.textBoxTypeS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxTypeS.Name = "textBoxTypeS";
            this.textBoxTypeS.Size = new System.Drawing.Size(309, 27);
            this.textBoxTypeS.TabIndex = 7;
            this.textBoxTypeS.TextChanged += new System.EventHandler(this.textBoxTypeS_TextChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(664, 142);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 62);
            this.buttonDel.TabIndex = 38;
            this.buttonDel.Text = "Удалить запись";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(833, 390);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "FoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodForm";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearchNo;
        private System.Windows.Forms.TextBox textBoxTypeS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxNameS;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfood;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefood;
        private System.Windows.Forms.DataGridViewTextBoxColumn typefood;
        private System.Windows.Forms.DataGridViewTextBoxColumn charfood;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}