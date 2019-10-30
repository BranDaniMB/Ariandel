namespace PL
{
    partial class Encriptar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Label();
            this.countText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.MenuText;
            this.Title.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(239, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(322, 41);
            this.Title.TabIndex = 0;
            this.Title.Text = "Project Ariandel";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Fira Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(42, 100);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBox.Size = new System.Drawing.Size(716, 251);
            this.TextBox.TabIndex = 2;
            this.TextBox.TextChanged += new System.EventHandler(this.check);
            // 
            // Done
            // 
            this.Done.AutoSize = true;
            this.Done.BackColor = System.Drawing.SystemColors.Control;
            this.Done.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Done.Location = new System.Drawing.Point(311, 438);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(179, 37);
            this.Done.TabIndex = 3;
            this.Done.Text = "Encriptar";
            this.Done.Click += new System.EventHandler(this.Encriptar_Click);
            // 
            // countText
            // 
            this.countText.AutoSize = true;
            this.countText.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countText.Location = new System.Drawing.Point(317, 351);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(166, 24);
            this.countText.TabIndex = 4;
            this.countText.Text = "Caracteres: 0";
            // 
            // Encriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PL.Properties.Resources._516683;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Title);
            this.Name = "Encriptar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ariandel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Done;
        private System.Windows.Forms.Label countText;
    }
}

