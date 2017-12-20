namespace OculusSpudControl
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.eBtn = new System.Windows.Forms.Button();
            this.dBtn = new System.Windows.Forms.Button();
            this.sLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current status:";
            // 
            // eBtn
            // 
            this.eBtn.Enabled = false;
            this.eBtn.Location = new System.Drawing.Point(15, 36);
            this.eBtn.Name = "eBtn";
            this.eBtn.Size = new System.Drawing.Size(75, 23);
            this.eBtn.TabIndex = 1;
            this.eBtn.Text = "Enable";
            this.eBtn.UseVisualStyleBackColor = true;
            this.eBtn.Click += new System.EventHandler(this.eBtn_Click);
            // 
            // dBtn
            // 
            this.dBtn.Enabled = false;
            this.dBtn.Location = new System.Drawing.Point(96, 36);
            this.dBtn.Name = "dBtn";
            this.dBtn.Size = new System.Drawing.Size(75, 23);
            this.dBtn.TabIndex = 2;
            this.dBtn.Text = "Disable";
            this.dBtn.UseVisualStyleBackColor = true;
            this.dBtn.Click += new System.EventHandler(this.dBtn_Click);
            // 
            // sLbl
            // 
            this.sLbl.AutoSize = true;
            this.sLbl.Location = new System.Drawing.Point(93, 9);
            this.sLbl.Name = "sLbl";
            this.sLbl.Size = new System.Drawing.Size(53, 13);
            this.sLbl.TabIndex = 3;
            this.sLbl.Text = "Unknown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 71);
            this.Controls.Add(this.sLbl);
            this.Controls.Add(this.dBtn);
            this.Controls.Add(this.eBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Oculus SPUD control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eBtn;
        private System.Windows.Forms.Button dBtn;
        private System.Windows.Forms.Label sLbl;
    }
}

