namespace DBZhuk
{
    partial class AddSclForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citySportcub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportSportclub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(325, 60);
            this.button4.TabIndex = 16;
            this.button4.Text = "Удалить участника";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Общий список";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Участники";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить участника";
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
            this.idSportclub,
            this.nameSportclub,
            this.citySportcub,
            this.sportSportclub});
            this.dataGridView2.Location = new System.Drawing.Point(12, 312);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(987, 250);
            this.dataGridView2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(987, 250);
            this.dataGridView1.TabIndex = 11;
            // 
            // idSportclub
            // 
            this.idSportclub.DataPropertyName = "idSportclub";
            this.idSportclub.HeaderText = "idscl";
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
            this.sportSportclub.HeaderText = "sportscl";
            this.sportSportclub.MinimumWidth = 8;
            this.sportSportclub.Name = "sportSportclub";
            this.sportSportclub.ReadOnly = true;
            this.sportSportclub.Visible = false;
            // 
            // AddSclForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 639);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddSclForm";
            this.Text = "AddSclForm";
            this.Load += new System.EventHandler(this.AddSclForm_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSportclub;
        private System.Windows.Forms.DataGridViewTextBoxColumn citySportcub;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportSportclub;
    }
}