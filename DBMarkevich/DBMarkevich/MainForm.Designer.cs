namespace DBMarkevich
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAnimal = new System.Windows.Forms.Button();
            this.buttonWorker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DBMarkevich.Properties.Resources.zoo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAnimal
            // 
            this.buttonAnimal.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAnimal.Location = new System.Drawing.Point(306, 66);
            this.buttonAnimal.Name = "buttonAnimal";
            this.buttonAnimal.Size = new System.Drawing.Size(160, 71);
            this.buttonAnimal.TabIndex = 3;
            this.buttonAnimal.Text = "Животные";
            this.buttonAnimal.UseVisualStyleBackColor = false;
            this.buttonAnimal.Click += new System.EventHandler(this.buttonAnimal_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonWorker.Location = new System.Drawing.Point(306, 143);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(160, 71);
            this.buttonWorker.TabIndex = 4;
            this.buttonWorker.Text = "Рабочие";
            this.buttonWorker.UseVisualStyleBackColor = false;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 294);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.buttonAnimal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAnimal;
        private System.Windows.Forms.Button buttonWorker;
    }
}