namespace DBZhuk
{
    partial class StForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idSorevnovanieStadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSorevnovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSport = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAddType = new System.Windows.Forms.TextBox();
            this.textBoxAddChar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStadion,
            this.typeStadion,
            this.nameStadion,
            this.namedport,
            this.charStadion});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(3, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 239);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idStadion
            // 
            this.idStadion.DataPropertyName = "idStadion";
            this.idStadion.HeaderText = "idStadion";
            this.idStadion.MinimumWidth = 8;
            this.idStadion.Name = "idStadion";
            this.idStadion.ReadOnly = true;
            this.idStadion.Visible = false;
            // 
            // typeStadion
            // 
            this.typeStadion.DataPropertyName = "typeStadion";
            this.typeStadion.HeaderText = "Тип";
            this.typeStadion.MinimumWidth = 8;
            this.typeStadion.Name = "typeStadion";
            this.typeStadion.ReadOnly = true;
            // 
            // nameStadion
            // 
            this.nameStadion.DataPropertyName = "nameStadion";
            this.nameStadion.HeaderText = "Название";
            this.nameStadion.MinimumWidth = 8;
            this.nameStadion.Name = "nameStadion";
            this.nameStadion.ReadOnly = true;
            // 
            // namedport
            // 
            this.namedport.DataPropertyName = "nameSport";
            this.namedport.HeaderText = "Вид спорта";
            this.namedport.MinimumWidth = 8;
            this.namedport.Name = "namedport";
            this.namedport.ReadOnly = true;
            // 
            // charStadion
            // 
            this.charStadion.DataPropertyName = "charStadion";
            this.charStadion.HeaderText = "Характеристика";
            this.charStadion.MinimumWidth = 8;
            this.charStadion.Name = "charStadion";
            this.charStadion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxChar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxType);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(936, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сброс";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Характеристика";
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(777, 49);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(250, 26);
            this.textBoxChar.TabIndex = 6;
            this.textBoxChar.TextChanged += new System.EventHandler(this.textBoxChar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вид спорта";
            // 
            // textBoxSport
            // 
            this.textBoxSport.Location = new System.Drawing.Point(521, 49);
            this.textBoxSport.Name = "textBoxSport";
            this.textBoxSport.Size = new System.Drawing.Size(250, 26);
            this.textBoxSport.TabIndex = 4;
            this.textBoxSport.TextChanged += new System.EventHandler(this.textBoxSport_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(265, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 26);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(9, 49);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(250, 26);
            this.textBoxType.TabIndex = 0;
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxType_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSorevnovanieStadion,
            this.idSorevnovanie,
            this.nameSorevnovanie,
            this.date});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(3, 383);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1042, 239);
            this.dataGridView2.TabIndex = 3;
            // 
            // idSorevnovanieStadion
            // 
            this.idSorevnovanieStadion.DataPropertyName = "idSorevnovanieStadion";
            this.idSorevnovanieStadion.HeaderText = "idSorevnovanieStadion";
            this.idSorevnovanieStadion.MinimumWidth = 8;
            this.idSorevnovanieStadion.Name = "idSorevnovanieStadion";
            this.idSorevnovanieStadion.ReadOnly = true;
            this.idSorevnovanieStadion.Visible = false;
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
            this.nameSorevnovanie.HeaderText = "Сореванование";
            this.nameSorevnovanie.MinimumWidth = 8;
            this.nameSorevnovanie.Name = "nameSorevnovanie";
            this.nameSorevnovanie.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата проведения";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSport);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBoxAddType);
            this.groupBox2.Controls.Add(this.textBoxAddChar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxAddName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(3, 628);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные стадиона";
            // 
            // comboBoxSport
            // 
            this.comboBoxSport.FormattingEnabled = true;
            this.comboBoxSport.Location = new System.Drawing.Point(514, 48);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(248, 28);
            this.comboBoxSport.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(936, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxAddType
            // 
            this.textBoxAddType.Location = new System.Drawing.Point(4, 50);
            this.textBoxAddType.Name = "textBoxAddType";
            this.textBoxAddType.Size = new System.Drawing.Size(250, 26);
            this.textBoxAddType.TabIndex = 1;
            // 
            // textBoxAddChar
            // 
            this.textBoxAddChar.Location = new System.Drawing.Point(768, 50);
            this.textBoxAddChar.Name = "textBoxAddChar";
            this.textBoxAddChar.Size = new System.Drawing.Size(248, 26);
            this.textBoxAddChar.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Тип";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(776, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Характеристика";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(260, 50);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(248, 26);
            this.textBoxAddName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Вид спорта";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 70);
            this.button3.TabIndex = 18;
            this.button3.Text = "Удалить данные о стадионе";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 628);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(256, 70);
            this.button9.TabIndex = 17;
            this.button9.Text = "Добавить стадион";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // StForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 759);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StForm";
            this.Text = "StForm";
            this.Load += new System.EventHandler(this.StForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeStadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedport;
        private System.Windows.Forms.DataGridViewTextBoxColumn charStadion;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSorevnovanieStadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSorevnovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSorevnovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSport;
        private System.Windows.Forms.TextBox textBoxAddChar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
    }
}