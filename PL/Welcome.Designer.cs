namespace PL
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.encriptar = new System.Windows.Forms.Label();
            this.desencriptar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Fira Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Project Ariandel";
            // 
            // encriptar
            // 
            this.encriptar.AutoSize = true;
            this.encriptar.Font = new System.Drawing.Font("Fira Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriptar.Location = new System.Drawing.Point(87, 302);
            this.encriptar.Name = "encriptar";
            this.encriptar.Size = new System.Drawing.Size(207, 42);
            this.encriptar.TabIndex = 1;
            this.encriptar.Text = "Encriptar";
            this.encriptar.Click += new System.EventHandler(this.Encriptar_Click);
            // 
            // desencriptar
            // 
            this.desencriptar.AutoSize = true;
            this.desencriptar.Font = new System.Drawing.Font("Fira Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desencriptar.Location = new System.Drawing.Point(430, 302);
            this.desencriptar.Name = "desencriptar";
            this.desencriptar.Size = new System.Drawing.Size(270, 42);
            this.desencriptar.TabIndex = 2;
            this.desencriptar.Text = "Desencriptar";
            this.desencriptar.Click += new System.EventHandler(this.Desencriptar_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PL.Properties.Resources._545454;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desencriptar);
            this.Controls.Add(this.encriptar);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label encriptar;
        private System.Windows.Forms.Label desencriptar;
    }
}