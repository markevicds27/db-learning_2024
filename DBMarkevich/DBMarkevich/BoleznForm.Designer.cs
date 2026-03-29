namespace DBMarkevich
{
    partial class BoleznForm
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
            this.textBoxSimptomS = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxNameS = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddNo = new System.Windows.Forms.Button();
            this.textBoxLech = new System.Windows.Forms.TextBox();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSimptom = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbolezn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebolezn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lechenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearchNo);
            this.groupBoxSearch.Controls.Add(this.textBoxSimptomS);
            this.groupBoxSearch.Controls.Add(this.label28);
            this.groupBoxSearch.Controls.Add(this.textBoxNameS);
            this.groupBoxSearch.Controls.Add(this.Название);
            this.groupBoxSearch.Location = new System.Drawing.Point(341, 140);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSearch.Size = new System.Drawing.Size(320, 184);
            this.groupBoxSearch.TabIndex = 31;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // buttonSearchNo
            // 
            this.buttonSearchNo.Location = new System.Drawing.Point(175, 140);
            this.buttonSearchNo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchNo.Name = "buttonSearchNo";
            this.buttonSearchNo.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchNo.TabIndex = 34;
            this.buttonSearchNo.Text = "Сброс";
            this.buttonSearchNo.UseVisualStyleBackColor = true;
            this.buttonSearchNo.Click += new System.EventHandler(this.buttonSearchNo_Click);
            // 
            // textBoxSimptomS
            // 
            this.textBoxSimptomS.Location = new System.Drawing.Point(5, 109);
            this.textBoxSimptomS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSimptomS.Name = "textBoxSimptomS";
            this.textBoxSimptomS.Size = new System.Drawing.Size(309, 27);
            this.textBoxSimptomS.TabIndex = 7;
            this.textBoxSimptomS.TextChanged += new System.EventHandler(this.textBoxSimptomS_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 85);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "Симптомы";
            // 
            // textBoxNameS
            // 
            this.textBoxNameS.Location = new System.Drawing.Point(5, 53);
            this.textBoxNameS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameS.Name = "textBoxNameS";
            this.textBoxNameS.Size = new System.Drawing.Size(309, 27);
            this.textBoxNameS.TabIndex = 3;
            this.textBoxNameS.TextChanged += new System.EventHandler(this.textBoxNameS_TextChanged);
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(5, 29);
            this.Название.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(87, 21);
            this.Название.TabIndex = 2;
            this.Название.Text = "Название";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddNo);
            this.groupBoxAdd.Controls.Add(this.textBoxLech);
            this.groupBoxAdd.Controls.Add(this.buttonAddOk);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.textBoxSimptom);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Location = new System.Drawing.Point(9, 140);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAdd.Size = new System.Drawing.Size(325, 236);
            this.groupBoxAdd.TabIndex = 30;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление записи";
            // 
            // buttonAddNo
            // 
            this.buttonAddNo.Location = new System.Drawing.Point(175, 192);
            this.buttonAddNo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNo.Name = "buttonAddNo";
            this.buttonAddNo.Size = new System.Drawing.Size(139, 33);
            this.buttonAddNo.TabIndex = 36;
            this.buttonAddNo.Text = "Отмена";
            this.buttonAddNo.UseVisualStyleBackColor = true;
            this.buttonAddNo.Click += new System.EventHandler(this.buttonAddNo_Click);
            // 
            // textBoxLech
            // 
            this.textBoxLech.Location = new System.Drawing.Point(5, 161);
            this.textBoxLech.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLech.Name = "textBoxLech";
            this.textBoxLech.Size = new System.Drawing.Size(309, 27);
            this.textBoxLech.TabIndex = 35;
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(4, 192);
            this.buttonAddOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(139, 33);
            this.buttonAddOk.TabIndex = 35;
            this.buttonAddOk.Text = "Добавить";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Лечение";
            // 
            // textBoxSimptom
            // 
            this.textBoxSimptom.Location = new System.Drawing.Point(5, 105);
            this.textBoxSimptom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSimptom.Name = "textBoxSimptom";
            this.textBoxSimptom.Size = new System.Drawing.Size(309, 27);
            this.textBoxSimptom.TabIndex = 33;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(5, 52);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(309, 27);
            this.textBoxName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Симптомы";
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
            this.idbolezn,
            this.namebolezn,
            this.simptom,
            this.lechenie});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 126);
            this.dataGridView1.TabIndex = 26;
            // 
            // idbolezn
            // 
            this.idbolezn.DataPropertyName = "idbolezn";
            this.idbolezn.HeaderText = "idbolezn";
            this.idbolezn.MinimumWidth = 8;
            this.idbolezn.Name = "idbolezn";
            this.idbolezn.ReadOnly = true;
            this.idbolezn.Visible = false;
            // 
            // namebolezn
            // 
            this.namebolezn.DataPropertyName = "namebolezn";
            this.namebolezn.HeaderText = "Название";
            this.namebolezn.MinimumWidth = 8;
            this.namebolezn.Name = "namebolezn";
            this.namebolezn.ReadOnly = true;
            // 
            // simptom
            // 
            this.simptom.DataPropertyName = "simptom";
            this.simptom.HeaderText = "Симптомы";
            this.simptom.MinimumWidth = 8;
            this.simptom.Name = "simptom";
            this.simptom.ReadOnly = true;
            // 
            // lechenie
            // 
            this.lechenie.DataPropertyName = "lechenie";
            this.lechenie.HeaderText = "Рекомендуемое лечение";
            this.lechenie.MinimumWidth = 8;
            this.lechenie.Name = "lechenie";
            this.lechenie.ReadOnly = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(665, 140);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 62);
            this.buttonDel.TabIndex = 32;
            this.buttonDel.Text = "Удалить запись";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // BoleznForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(837, 387);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "BoleznForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoleznForm";
            this.Load += new System.EventHandler(this.BoleznForm_Load);
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
        private System.Windows.Forms.TextBox textBoxNameS;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.Button buttonAddNo;
        private System.Windows.Forms.TextBox textBoxSimptom;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSimptomS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxLech;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbolezn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebolezn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simptom;
        private System.Windows.Forms.DataGridViewTextBoxColumn lechenie;
        private System.Windows.Forms.Button buttonDel;
    }
}