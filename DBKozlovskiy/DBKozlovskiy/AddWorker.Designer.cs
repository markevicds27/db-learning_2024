namespace DBKozlovskiy
{
    partial class AddWorker
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.idWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stazWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDolznost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOtdel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1206, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите выполняемую работу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите работника";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWorker,
            this.surnameWorker,
            this.nameWorker,
            this.patronWorker,
            this.ageWorker,
            this.stazWorker,
            this.nameDolznost,
            this.nameOtdel});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1205, 26);
            this.textBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите должность";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1205, 26);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // idWorker
            // 
            this.idWorker.DataPropertyName = "idWorker";
            this.idWorker.HeaderText = "idWorker";
            this.idWorker.MinimumWidth = 8;
            this.idWorker.Name = "idWorker";
            this.idWorker.ReadOnly = true;
            this.idWorker.Visible = false;
            // 
            // surnameWorker
            // 
            this.surnameWorker.DataPropertyName = "surnameWorker";
            this.surnameWorker.HeaderText = "Фамилия";
            this.surnameWorker.MinimumWidth = 8;
            this.surnameWorker.Name = "surnameWorker";
            this.surnameWorker.ReadOnly = true;
            // 
            // nameWorker
            // 
            this.nameWorker.DataPropertyName = "nameWorker";
            this.nameWorker.HeaderText = "Имя";
            this.nameWorker.MinimumWidth = 8;
            this.nameWorker.Name = "nameWorker";
            this.nameWorker.ReadOnly = true;
            // 
            // patronWorker
            // 
            this.patronWorker.DataPropertyName = "patronWorker";
            this.patronWorker.HeaderText = "Отчество";
            this.patronWorker.MinimumWidth = 8;
            this.patronWorker.Name = "patronWorker";
            this.patronWorker.ReadOnly = true;
            // 
            // ageWorker
            // 
            this.ageWorker.DataPropertyName = "ageWorker";
            this.ageWorker.HeaderText = "Возраст";
            this.ageWorker.MinimumWidth = 8;
            this.ageWorker.Name = "ageWorker";
            this.ageWorker.ReadOnly = true;
            // 
            // stazWorker
            // 
            this.stazWorker.DataPropertyName = "stazWorker";
            this.stazWorker.HeaderText = "Стаж";
            this.stazWorker.MinimumWidth = 8;
            this.stazWorker.Name = "stazWorker";
            this.stazWorker.ReadOnly = true;
            // 
            // nameDolznost
            // 
            this.nameDolznost.DataPropertyName = "nameDolznost";
            this.nameDolznost.HeaderText = "Должность";
            this.nameDolznost.MinimumWidth = 8;
            this.nameDolznost.Name = "nameDolznost";
            this.nameDolznost.ReadOnly = true;
            // 
            // nameOtdel
            // 
            this.nameOtdel.DataPropertyName = "nameOtdel";
            this.nameOtdel.HeaderText = "Отдел";
            this.nameOtdel.MinimumWidth = 8;
            this.nameOtdel.Name = "nameOtdel";
            this.nameOtdel.ReadOnly = true;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 344);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn stazWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDolznost;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOtdel;
    }
}