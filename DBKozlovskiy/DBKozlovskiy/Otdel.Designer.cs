namespace DBKozlovskiy
{
    partial class Otdel
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
            this.groupBoxPoisk = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxOpcii = new System.Windows.Forms.GroupBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBoxNew = new System.Windows.Forms.GroupBox();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMat = new System.Windows.Forms.DataGridView();
            this.idOtdel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOtdel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieOtdel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPoisk.SuspendLayout();
            this.groupBoxOpcii.SuspendLayout();
            this.groupBoxNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPoisk
            // 
            this.groupBoxPoisk.Controls.Add(this.label8);
            this.groupBoxPoisk.Controls.Add(this.textBox2);
            this.groupBoxPoisk.Controls.Add(this.label7);
            this.groupBoxPoisk.Controls.Add(this.textBox1);
            this.groupBoxPoisk.Location = new System.Drawing.Point(12, 168);
            this.groupBoxPoisk.Name = "groupBoxPoisk";
            this.groupBoxPoisk.Size = new System.Drawing.Size(776, 100);
            this.groupBoxPoisk.TabIndex = 20;
            this.groupBoxPoisk.TabStop = false;
            this.groupBoxPoisk.Text = "Поиск";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Описание";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(370, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxOpcii
            // 
            this.groupBoxOpcii.Controls.Add(this.buttonDel);
            this.groupBoxOpcii.Controls.Add(this.buttonEdit);
            this.groupBoxOpcii.Controls.Add(this.buttonNew);
            this.groupBoxOpcii.Location = new System.Drawing.Point(428, 275);
            this.groupBoxOpcii.Name = "groupBoxOpcii";
            this.groupBoxOpcii.Size = new System.Drawing.Size(360, 209);
            this.groupBoxOpcii.TabIndex = 19;
            this.groupBoxOpcii.TabStop = false;
            this.groupBoxOpcii.Text = "Управление";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(76, 143);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(214, 53);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(76, 84);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(214, 53);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить общие сведения";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(76, 25);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(214, 53);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Добавить";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.Controls.Add(this.textBoxChar);
            this.groupBoxNew.Controls.Add(this.label2);
            this.groupBoxNew.Controls.Add(this.textBoxName);
            this.groupBoxNew.Controls.Add(this.label1);
            this.groupBoxNew.Location = new System.Drawing.Point(12, 274);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(410, 148);
            this.groupBoxNew.TabIndex = 18;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "Просмотр записи";
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(11, 109);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(393, 26);
            this.textBoxChar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(393, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // dataGridViewMat
            // 
            this.dataGridViewMat.AllowUserToAddRows = false;
            this.dataGridViewMat.AllowUserToDeleteRows = false;
            this.dataGridViewMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOtdel,
            this.nameOtdel,
            this.opisanieOtdel});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMat.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMat.Name = "dataGridViewMat";
            this.dataGridViewMat.ReadOnly = true;
            this.dataGridViewMat.RowHeadersWidth = 62;
            this.dataGridViewMat.RowTemplate.Height = 28;
            this.dataGridViewMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMat.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewMat.TabIndex = 17;
            this.dataGridViewMat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMat_CellClick);
            // 
            // idOtdel
            // 
            this.idOtdel.DataPropertyName = "idOtdel";
            this.idOtdel.HeaderText = "idOtdel";
            this.idOtdel.MinimumWidth = 8;
            this.idOtdel.Name = "idOtdel";
            this.idOtdel.ReadOnly = true;
            this.idOtdel.Visible = false;
            // 
            // nameOtdel
            // 
            this.nameOtdel.DataPropertyName = "nameOtdel";
            this.nameOtdel.HeaderText = "Название";
            this.nameOtdel.MinimumWidth = 8;
            this.nameOtdel.Name = "nameOtdel";
            this.nameOtdel.ReadOnly = true;
            // 
            // opisanieOtdel
            // 
            this.opisanieOtdel.DataPropertyName = "opisanieOtdel";
            this.opisanieOtdel.HeaderText = "Описание";
            this.opisanieOtdel.MinimumWidth = 8;
            this.opisanieOtdel.Name = "opisanieOtdel";
            this.opisanieOtdel.ReadOnly = true;
            // 
            // Otdel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 495);
            this.Controls.Add(this.groupBoxPoisk);
            this.Controls.Add(this.groupBoxOpcii);
            this.Controls.Add(this.groupBoxNew);
            this.Controls.Add(this.dataGridViewMat);
            this.Name = "Otdel";
            this.Text = "Otdel";
            this.Load += new System.EventHandler(this.Otdel_Load);
            this.groupBoxPoisk.ResumeLayout(false);
            this.groupBoxPoisk.PerformLayout();
            this.groupBoxOpcii.ResumeLayout(false);
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPoisk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxOpcii;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOtdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOtdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieOtdel;
    }
}