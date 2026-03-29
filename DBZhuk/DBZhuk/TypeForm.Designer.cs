namespace DBZhuk
{
    partial class TypeForm
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
            this.idType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.idType,
            this.nameType,
            this.opisanieType});
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
            this.dataGridView1.Size = new System.Drawing.Size(791, 132);
            this.dataGridView1.TabIndex = 2;
            // 
            // idType
            // 
            this.idType.DataPropertyName = "idType";
            this.idType.HeaderText = "idtypesor";
            this.idType.MinimumWidth = 8;
            this.idType.Name = "idType";
            this.idType.ReadOnly = true;
            this.idType.Visible = false;
            // 
            // nameType
            // 
            this.nameType.DataPropertyName = "nameType";
            this.nameType.HeaderText = "Название";
            this.nameType.MinimumWidth = 8;
            this.nameType.Name = "nameType";
            this.nameType.ReadOnly = true;
            // 
            // opisanieType
            // 
            this.opisanieType.DataPropertyName = "opisanieType";
            this.opisanieType.HeaderText = "Описание";
            this.opisanieType.MinimumWidth = 8;
            this.opisanieType.Name = "opisanieType";
            this.opisanieType.ReadOnly = true;
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 155);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TypeForm";
            this.Text = "TypeForm";
            this.Load += new System.EventHandler(this.TypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idType;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieType;
    }
}