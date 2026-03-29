namespace DBZhuk
{
    partial class AddSpmForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(987, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSportsman,
            this.sNameSportsman,
            this.nameSportsman,
            this.pNameSportsman,
            this.genderSportsman,
            this.ageSportsman});
            this.dataGridView2.Location = new System.Drawing.Point(12, 316);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(987, 250);
            this.dataGridView2.TabIndex = 1;
            // 
            // idSportsman
            // 
            this.idSportsman.DataPropertyName = "idSportsman";
            this.idSportsman.HeaderText = "idspm";
            this.idSportsman.MinimumWidth = 8;
            this.idSportsman.Name = "idSportsman";
            this.idSportsman.ReadOnly = true;
            this.idSportsman.Visible = false;
            // 
            // sNameSportsman
            // 
            this.sNameSportsman.DataPropertyName = "sNameSportsman";
            this.sNameSportsman.HeaderText = "Фамилия";
            this.sNameSportsman.MinimumWidth = 8;
            this.sNameSportsman.Name = "sNameSportsman";
            this.sNameSportsman.ReadOnly = true;
            // 
            // nameSportsman
            // 
            this.nameSportsman.DataPropertyName = "nameSportsman";
            this.nameSportsman.HeaderText = "Имя";
            this.nameSportsman.MinimumWidth = 8;
            this.nameSportsman.Name = "nameSportsman";
            this.nameSportsman.ReadOnly = true;
            // 
            // pNameSportsman
            // 
            this.pNameSportsman.DataPropertyName = "pNameSportsman";
            this.pNameSportsman.HeaderText = "Отчество";
            this.pNameSportsman.MinimumWidth = 8;
            this.pNameSportsman.Name = "pNameSportsman";
            this.pNameSportsman.ReadOnly = true;
            // 
            // genderSportsman
            // 
            this.genderSportsman.DataPropertyName = "genderSportsman";
            this.genderSportsman.HeaderText = "Пол";
            this.genderSportsman.MinimumWidth = 8;
            this.genderSportsman.Name = "genderSportsman";
            this.genderSportsman.ReadOnly = true;
            // 
            // ageSportsman
            // 
            this.ageSportsman.DataPropertyName = "ageSportsman";
            this.ageSportsman.HeaderText = "Возраст";
            this.ageSportsman.MinimumWidth = 8;
            this.ageSportsman.Name = "ageSportsman";
            this.ageSportsman.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Участники";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Общий список";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить участника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 572);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(325, 60);
            this.button4.TabIndex = 9;
            this.button4.Text = "Удалить участника";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddSpmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 636);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddSpmForm";
            this.Text = "-";
            this.Load += new System.EventHandler(this.AddSpmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageSportsman;
    }
}