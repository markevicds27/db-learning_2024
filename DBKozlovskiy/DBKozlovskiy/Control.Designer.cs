namespace DBKozlovskiy
{
    partial class Control
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTex = new System.Windows.Forms.DataGridView();
            this.groupBoxOpcii = new System.Windows.Forms.GroupBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBoxNew = new System.Windows.Forms.GroupBox();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPoisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTex)).BeginInit();
            this.groupBoxOpcii.SuspendLayout();
            this.groupBoxNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPoisk
            // 
            this.groupBoxPoisk.Controls.Add(this.label7);
            this.groupBoxPoisk.Controls.Add(this.textBox1);
            this.groupBoxPoisk.Location = new System.Drawing.Point(12, 168);
            this.groupBoxPoisk.Name = "groupBoxPoisk";
            this.groupBoxPoisk.Size = new System.Drawing.Size(776, 100);
            this.groupBoxPoisk.TabIndex = 17;
            this.groupBoxPoisk.TabStop = false;
            this.groupBoxPoisk.Text = "Поиск";
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
            // dataGridViewTex
            // 
            this.dataGridViewTex.AllowUserToAddRows = false;
            this.dataGridViewTex.AllowUserToDeleteRows = false;
            this.dataGridViewTex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idControl,
            this.nameControl,
            this.opisanieControl});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTex.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTex.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTex.Name = "dataGridViewTex";
            this.dataGridViewTex.ReadOnly = true;
            this.dataGridViewTex.RowHeadersWidth = 62;
            this.dataGridViewTex.RowTemplate.Height = 28;
            this.dataGridViewTex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTex.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewTex.TabIndex = 16;
            this.dataGridViewTex.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTex_CellClick);
            // 
            // groupBoxOpcii
            // 
            this.groupBoxOpcii.Controls.Add(this.buttonDel);
            this.groupBoxOpcii.Controls.Add(this.buttonEdit);
            this.groupBoxOpcii.Controls.Add(this.buttonNew);
            this.groupBoxOpcii.Location = new System.Drawing.Point(428, 275);
            this.groupBoxOpcii.Name = "groupBoxOpcii";
            this.groupBoxOpcii.Size = new System.Drawing.Size(360, 209);
            this.groupBoxOpcii.TabIndex = 15;
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
            this.groupBoxNew.TabIndex = 14;
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
            // idControl
            // 
            this.idControl.DataPropertyName = "idControl";
            this.idControl.HeaderText = "idControl";
            this.idControl.MinimumWidth = 8;
            this.idControl.Name = "idControl";
            this.idControl.ReadOnly = true;
            this.idControl.Visible = false;
            // 
            // nameControl
            // 
            this.nameControl.DataPropertyName = "nameControl";
            this.nameControl.HeaderText = "Название";
            this.nameControl.MinimumWidth = 8;
            this.nameControl.Name = "nameControl";
            this.nameControl.ReadOnly = true;
            // 
            // opisanieControl
            // 
            this.opisanieControl.DataPropertyName = "opisanieControl";
            this.opisanieControl.HeaderText = "Описание";
            this.opisanieControl.MinimumWidth = 8;
            this.opisanieControl.Name = "opisanieControl";
            this.opisanieControl.ReadOnly = true;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 492);
            this.Controls.Add(this.groupBoxPoisk);
            this.Controls.Add(this.dataGridViewTex);
            this.Controls.Add(this.groupBoxOpcii);
            this.Controls.Add(this.groupBoxNew);
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.groupBoxPoisk.ResumeLayout(false);
            this.groupBoxPoisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTex)).EndInit();
            this.groupBoxOpcii.ResumeLayout(false);
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPoisk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewTex;
        private System.Windows.Forms.GroupBox groupBoxOpcii;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieControl;
    }
}