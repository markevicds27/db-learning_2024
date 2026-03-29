namespace DBZhuk
{
    partial class SclFrom
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonEditYes = new System.Windows.Forms.Button();
            this.buttonEditNo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView111 = new System.Windows.Forms.DataGridView();
            this.idSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citySportcub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView111)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Просмотр состава";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выберите вид спорта";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSname);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Город";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(539, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(496, 26);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(9, 49);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(524, 26);
            this.textBoxSname.TabIndex = 0;
            this.textBoxSname.TextChanged += new System.EventHandler(this.textBoxSname_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 70);
            this.button4.TabIndex = 18;
            this.button4.Text = "Изменить данные о спортклубе";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 70);
            this.button3.TabIndex = 17;
            this.button3.Text = "Удалить данные о спортклубе";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 70);
            this.button2.TabIndex = 16;
            this.button2.Text = "Оформить спортклуб";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.label3);
            this.groupBoxEdit.Controls.Add(this.textBox1);
            this.groupBoxEdit.Controls.Add(this.label4);
            this.groupBoxEdit.Controls.Add(this.textBox2);
            this.groupBoxEdit.Controls.Add(this.buttonEditYes);
            this.groupBoxEdit.Controls.Add(this.buttonEditNo);
            this.groupBoxEdit.Location = new System.Drawing.Point(12, 432);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(1041, 129);
            this.groupBoxEdit.TabIndex = 19;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Город";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(538, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 26);
            this.textBox1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Название";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(524, 26);
            this.textBox2.TabIndex = 28;
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(827, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 70);
            this.button5.TabIndex = 20;
            this.button5.Text = "Тренера";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1041, 26);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView111
            // 
            this.dataGridView111.AllowUserToAddRows = false;
            this.dataGridView111.AllowUserToDeleteRows = false;
            this.dataGridView111.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView111.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView111.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSportclub,
            this.nameSportclub,
            this.citySportcub,
            this.sportSportclub,
            this.nameSport});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView111.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView111.Location = new System.Drawing.Point(11, 168);
            this.dataGridView111.Name = "dataGridView111";
            this.dataGridView111.ReadOnly = true;
            this.dataGridView111.RowHeadersWidth = 62;
            this.dataGridView111.RowTemplate.Height = 28;
            this.dataGridView111.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView111.Size = new System.Drawing.Size(1042, 258);
            this.dataGridView111.TabIndex = 22;
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
            // citySportcub
            // 
            this.citySportcub.DataPropertyName = "citySportcub";
            this.citySportcub.HeaderText = "Город";
            this.citySportcub.MinimumWidth = 8;
            this.citySportcub.Name = "citySportcub";
            this.citySportcub.ReadOnly = true;
            // 
            // sportSportclub
            // 
            this.sportSportclub.DataPropertyName = "sportSportclub";
            this.sportSportclub.HeaderText = "sportSportclub";
            this.sportSportclub.MinimumWidth = 8;
            this.sportSportclub.Name = "sportSportclub";
            this.sportSportclub.ReadOnly = true;
            this.sportSportclub.Visible = false;
            // 
            // nameSport
            // 
            this.nameSport.DataPropertyName = "nameSport";
            this.nameSport.HeaderText = "Вид спорта";
            this.nameSport.MinimumWidth = 8;
            this.nameSport.Name = "nameSport";
            this.nameSport.ReadOnly = true;
            // 
            // SclFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 573);
            this.Controls.Add(this.dataGridView111);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Name = "SclFrom";
            this.Text = "SclFrom";
            this.Load += new System.EventHandler(this.SclFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView111)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonEditYes;
        private System.Windows.Forms.Button buttonEditNo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView111;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn citySportcub;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportSportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSport;
    }
}