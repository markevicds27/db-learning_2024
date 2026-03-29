namespace DBZhuk
{
    partial class SportForm
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
            this.idSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pravilaSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSport,
            this.nameSport,
            this.opisanieSport,
            this.pravilaSport});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // idSport
            // 
            this.idSport.DataPropertyName = "idSport";
            this.idSport.HeaderText = "idSport";
            this.idSport.MinimumWidth = 8;
            this.idSport.Name = "idSport";
            this.idSport.ReadOnly = true;
            this.idSport.Visible = false;
            // 
            // nameSport
            // 
            this.nameSport.DataPropertyName = "nameSport";
            this.nameSport.HeaderText = "Вид спорта";
            this.nameSport.MinimumWidth = 8;
            this.nameSport.Name = "nameSport";
            this.nameSport.ReadOnly = true;
            // 
            // opisanieSport
            // 
            this.opisanieSport.DataPropertyName = "opisanieSport";
            this.opisanieSport.HeaderText = "Описание";
            this.opisanieSport.MinimumWidth = 8;
            this.opisanieSport.Name = "opisanieSport";
            this.opisanieSport.ReadOnly = true;
            // 
            // pravilaSport
            // 
            this.pravilaSport.DataPropertyName = "pravilaSport";
            this.pravilaSport.HeaderText = "Правила";
            this.pravilaSport.MinimumWidth = 8;
            this.pravilaSport.Name = "pravilaSport";
            this.pravilaSport.ReadOnly = true;
            // 
            // SportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SportForm";
            this.Text = "SportForm";
            this.Load += new System.EventHandler(this.SportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn pravilaSport;
    }
}