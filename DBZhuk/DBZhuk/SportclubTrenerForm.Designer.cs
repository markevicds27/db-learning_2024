namespace DBZhuk
{
    partial class SportclubTrenerForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stazTrener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 565);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(325, 60);
            this.button4.TabIndex = 23;
            this.button4.Text = "Удалить тренера";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Общий список тренеров";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Тренера";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 60);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить тренера";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrener,
            this.sNameTrener,
            this.nameTrener,
            this.pNameTrener,
            this.genderTrener,
            this.ageTrener,
            this.stazTrener});
            this.dataGridView2.Location = new System.Drawing.Point(12, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(987, 250);
            this.dataGridView2.TabIndex = 19;
            // 
            // idTrener
            // 
            this.idTrener.DataPropertyName = "idTrener";
            this.idTrener.HeaderText = "idTrener";
            this.idTrener.MinimumWidth = 8;
            this.idTrener.Name = "idTrener";
            this.idTrener.ReadOnly = true;
            this.idTrener.Visible = false;
            // 
            // sNameTrener
            // 
            this.sNameTrener.DataPropertyName = "sNameTrener";
            this.sNameTrener.HeaderText = "Фамилия";
            this.sNameTrener.MinimumWidth = 8;
            this.sNameTrener.Name = "sNameTrener";
            this.sNameTrener.ReadOnly = true;
            // 
            // nameTrener
            // 
            this.nameTrener.DataPropertyName = "nameTrener";
            this.nameTrener.HeaderText = "Имя";
            this.nameTrener.MinimumWidth = 8;
            this.nameTrener.Name = "nameTrener";
            this.nameTrener.ReadOnly = true;
            // 
            // pNameTrener
            // 
            this.pNameTrener.DataPropertyName = "pNameTrener";
            this.pNameTrener.HeaderText = "Отчество";
            this.pNameTrener.MinimumWidth = 8;
            this.pNameTrener.Name = "pNameTrener";
            this.pNameTrener.ReadOnly = true;
            // 
            // genderTrener
            // 
            this.genderTrener.DataPropertyName = "genderTrener";
            this.genderTrener.HeaderText = "Пол";
            this.genderTrener.MinimumWidth = 8;
            this.genderTrener.Name = "genderTrener";
            this.genderTrener.ReadOnly = true;
            // 
            // ageTrener
            // 
            this.ageTrener.DataPropertyName = "ageTrener";
            this.ageTrener.HeaderText = "Возраст";
            this.ageTrener.MinimumWidth = 8;
            this.ageTrener.Name = "ageTrener";
            this.ageTrener.ReadOnly = true;
            // 
            // stazTrener
            // 
            this.stazTrener.DataPropertyName = "stazTrener";
            this.stazTrener.HeaderText = "Стаж";
            this.stazTrener.MinimumWidth = 8;
            this.stazTrener.Name = "stazTrener";
            this.stazTrener.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(987, 250);
            this.dataGridView1.TabIndex = 18;
            // 
            // SportclubTrenerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 632);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SportclubTrenerForm";
            this.Text = "SportclubTrenerForm";
            this.Load += new System.EventHandler(this.SportclubTrenerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageTrener;
        private System.Windows.Forms.DataGridViewTextBoxColumn stazTrener;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}