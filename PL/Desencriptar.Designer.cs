namespace PL
{
    partial class Desencriptar
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
            this.Title = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.MenuText;
            this.Title.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(239, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(322, 41);
            this.Title.TabIndex = 1;
            this.Title.Text = "Project Ariandel";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Done
            // 
            this.Done.AutoSize = true;
            this.Done.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(277, 377);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(246, 41);
            this.Done.TabIndex = 3;
            this.Done.Text = "Desencriptar";
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Desencriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PL.Properties.Resources._519519;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Title);
            this.Name = "Desencriptar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desencriptar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Done;
    }
}