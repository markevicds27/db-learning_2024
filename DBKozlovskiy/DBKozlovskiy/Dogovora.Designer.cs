namespace DBKozlovskiy
{
    partial class Dogovora
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
            this.idDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameZakaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFibishDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.idDogovor,
            this.nameDogovor,
            this.nameZakaz,
            this.statusDogovor,
            this.dateStartDogovor,
            this.dateFibishDogovor});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDogovor
            // 
            this.idDogovor.DataPropertyName = "idDogovor";
            this.idDogovor.HeaderText = "idDogovor";
            this.idDogovor.MinimumWidth = 8;
            this.idDogovor.Name = "idDogovor";
            this.idDogovor.ReadOnly = true;
            this.idDogovor.Visible = false;
            // 
            // nameDogovor
            // 
            this.nameDogovor.DataPropertyName = "nameDogovor";
            this.nameDogovor.HeaderText = "Название";
            this.nameDogovor.MinimumWidth = 8;
            this.nameDogovor.Name = "nameDogovor";
            this.nameDogovor.ReadOnly = true;
            // 
            // nameZakaz
            // 
            this.nameZakaz.DataPropertyName = "nameZakaz";
            this.nameZakaz.HeaderText = "Заказчик";
            this.nameZakaz.MinimumWidth = 8;
            this.nameZakaz.Name = "nameZakaz";
            this.nameZakaz.ReadOnly = true;
            // 
            // statusDogovor
            // 
            this.statusDogovor.DataPropertyName = "statusDogovor";
            this.statusDogovor.HeaderText = "Статус";
            this.statusDogovor.MinimumWidth = 8;
            this.statusDogovor.Name = "statusDogovor";
            this.statusDogovor.ReadOnly = true;
            // 
            // dateStartDogovor
            // 
            this.dateStartDogovor.DataPropertyName = "dateStartDogovor";
            this.dateStartDogovor.HeaderText = "Дата заключения";
            this.dateStartDogovor.MinimumWidth = 8;
            this.dateStartDogovor.Name = "dateStartDogovor";
            this.dateStartDogovor.ReadOnly = true;
            // 
            // dateFibishDogovor
            // 
            this.dateFibishDogovor.DataPropertyName = "dateFibishDogovor";
            this.dateFibishDogovor.HeaderText = "Срок выполнения";
            this.dateFibishDogovor.MinimumWidth = 8;
            this.dateFibishDogovor.Name = "dateFibishDogovor";
            this.dateFibishDogovor.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просмотр данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменение статуса";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удаление записи";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(269, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение статуса";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(381, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Активен",
            "Приостановлен\t",
            "Выполнен"});
            this.comboBox1.Location = new System.Drawing.Point(7, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // Dogovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Name = "Dogovora";
            this.Text = "Dogovora";
            this.Load += new System.EventHandler(this.Dogovora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDogovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDogovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameZakaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDogovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDogovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFibishDogovor;
    }
}