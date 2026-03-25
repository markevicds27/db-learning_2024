namespace DBMarkevich
{
    partial class DostForm
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
            this.textBoxTypePostS = new System.Windows.Forms.TextBox();
            this.buttonSearchNo = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxTypeFoodS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxPostS = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxFoodS = new System.Windows.Forms.TextBox();
            this.Еда = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typefood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typepost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countdost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxTypePostS);
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.label27);
            this.groupBoxSearch.Controls.Add(this.textBoxTypeFoodS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxPostS);
            this.groupBoxSearch.Controls.Add(this.label29);
            this.groupBoxSearch.Controls.Add(this.textBoxFoodS);
            this.groupBoxSearch.Controls.Add(this.Еда);
            this.groupBoxSearch.Location = new System.Drawing.Point(343, 173);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(323, 290);
            this.groupBoxSearch.TabIndex = 27;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // textBoxTypePostS
            // 
            this.textBoxTypePostS.Location = new System.Drawing.Point(5, 214);
            this.textBoxTypePostS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxTypePostS.Name = "textBoxTypePostS";
            this.textBoxTypePostS.Size = new System.Drawing.Size(309, 27);
            this.textBoxTypePostS.TabIndex = 36;
            this.textBoxTypePostS.TextChanged += new System.EventHandler(this.textBoxTypePostS_TextChanged);
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(175, 247);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            this.buttonSearchNo.Click += new System.EventHandler(this.buttonSearchNo_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 191);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(141, 21);
            this.label27.TabIndex = 8;
            this.label27.Text = "Тип поставщика";
            // 
            // textBoxTypeFoodS
            // 
            this.textBoxTypeFoodS.Location = new System.Drawing.Point(5, 109);
            this.textBoxTypeFoodS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxTypeFoodS.Name = "textBoxTypeFoodS";
            this.textBoxTypeFoodS.Size = new System.Drawing.Size(309, 27);
            this.textBoxTypeFoodS.TabIndex = 7;
            this.textBoxTypeFoodS.TextChanged += new System.EventHandler(this.textBoxTypeFoodS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 85);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Тип еды";
            // 
            // textBoxPostS
            // 
            this.textBoxPostS.Location = new System.Drawing.Point(5, 159);
            this.textBoxPostS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPostS.Name = "textBoxPostS";
            this.textBoxPostS.Size = new System.Drawing.Size(309, 27);
            this.textBoxPostS.TabIndex = 5;
            this.textBoxPostS.TextChanged += new System.EventHandler(this.textBoxPostS_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 135);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(99, 21);
            this.label29.TabIndex = 4;
            this.label29.Text = "Поставщик";
            // 
            // textBoxFoodS
            // 
            this.textBoxFoodS.Location = new System.Drawing.Point(5, 53);
            this.textBoxFoodS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxFoodS.Name = "textBoxFoodS";
            this.textBoxFoodS.Size = new System.Drawing.Size(309, 27);
            this.textBoxFoodS.TabIndex = 3;
            this.textBoxFoodS.TextChanged += new System.EventHandler(this.textBoxFoodS_TextChanged);
            // 
            // Еда
            // 
            this.Еда.AutoSize = true;
            this.Еда.Location = new System.Drawing.Point(5, 29);
            this.Еда.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Еда.Name = "Еда";
            this.Еда.Size = new System.Drawing.Size(85, 21);
            this.Еда.TabIndex = 2;
            this.Еда.Text = "Фамилия";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.textBoxCount);
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.comboBoxPost);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.comboBoxFood);
            this.groupBoxAdd.Controls.Add(this.textBoxPrice);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Location = new System.Drawing.Point(14, 173);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxAdd.Size = new System.Drawing.Size(325, 290);
            this.groupBoxAdd.TabIndex = 26;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(5, 248);
            this.buttonAddOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(139, 33);
            this.buttonAddOk.TabIndex = 33;
            this.buttonAddOk.Text = "Добавить";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(5, 215);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(309, 27);
            this.textBoxCount.TabIndex = 40;
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
            // comboBoxPost
            // 
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(5, 105);
            this.comboBoxPost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(309, 29);
            this.comboBoxPost.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Поставщик";
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(5, 51);
            this.comboBoxFood.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(309, 29);
            this.comboBoxFood.TabIndex = 30;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(5, 159);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(309, 27);
            this.textBoxPrice.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Еда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Цена";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(676, 173);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 62);
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
            this.iddost,
            this.namefood,
            this.typefood,
            this.namepost,
            this.typepost,
            this.price,
            this.countdost});
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
            this.dataGridView1.Size = new System.Drawing.Size(820, 153);
            this.dataGridView1.TabIndex = 24;
            // 
            // iddost
            // 
            this.iddost.DataPropertyName = "iddost";
            this.iddost.HeaderText = "iddost";
            this.iddost.MinimumWidth = 8;
            this.iddost.Name = "iddost";
            this.iddost.ReadOnly = true;
            this.iddost.Visible = false;
            // 
            // namefood
            // 
            this.namefood.DataPropertyName = "namefood";
            this.namefood.HeaderText = "Название еды";
            this.namefood.MinimumWidth = 8;
            this.namefood.Name = "namefood";
            this.namefood.ReadOnly = true;
            // 
            // typefood
            // 
            this.typefood.DataPropertyName = "typefood";
            this.typefood.HeaderText = "Тип еды";
            this.typefood.MinimumWidth = 8;
            this.typefood.Name = "typefood";
            this.typefood.ReadOnly = true;
            // 
            // namepost
            // 
            this.namepost.DataPropertyName = "namepost";
            this.namepost.HeaderText = "Поставщик";
            this.namepost.MinimumWidth = 8;
            this.namepost.Name = "namepost";
            this.namepost.ReadOnly = true;
            // 
            // typepost
            // 
            this.typepost.DataPropertyName = "typepost";
            this.typepost.HeaderText = "Тип поставщика";
            this.typepost.MinimumWidth = 8;
            this.typepost.Name = "typepost";
            this.typepost.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // countdost
            // 
            this.countdost.DataPropertyName = "countdost";
            this.countdost.HeaderText = "Количество";
            this.countdost.MinimumWidth = 8;
            this.countdost.Name = "countdost";
            this.countdost.ReadOnly = true;
            // 
            // DostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(847, 473);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "DostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DostForm";
            this.Load += new System.EventHandler(this.DostForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxTypePostS;
        private System.Windows.Forms.Button buttonSearchNo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxTypeFoodS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxPostS;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxFoodS;
        private System.Windows.Forms.Label Еда;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddost;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefood;
        private System.Windows.Forms.DataGridViewTextBoxColumn typefood;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepost;
        private System.Windows.Forms.DataGridViewTextBoxColumn typepost;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn countdost;
    }
}