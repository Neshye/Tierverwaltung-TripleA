namespace TripleA
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblform2 = new System.Windows.Forms.Label();
            this.lblTierpfleger = new System.Windows.Forms.Label();
            this.btnFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblform2
            // 
            this.lblform2.AutoSize = true;
            this.lblform2.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblform2.Location = new System.Drawing.Point(24, 26);
            this.lblform2.Name = "lblform2";
            this.lblform2.Size = new System.Drawing.Size(84, 27);
            this.lblform2.TabIndex = 2;
            this.lblform2.Text = "label1";
            // 
            // lblTierpfleger
            // 
            this.lblTierpfleger.AutoSize = true;
            this.lblTierpfleger.Location = new System.Drawing.Point(630, 12);
            this.lblTierpfleger.Name = "lblTierpfleger";
            this.lblTierpfleger.Size = new System.Drawing.Size(35, 13);
            this.lblTierpfleger.TabIndex = 3;
            this.lblTierpfleger.Text = "label1";
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(631, 28);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(91, 29);
            this.btnFeed.TabIndex = 4;
            this.btnFeed.Text = "Füttern";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.lblTierpfleger);
            this.Controls.Add(this.lblform2);
            this.Controls.Add(this.btnClose);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tierverwaltung";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblform2;
        private System.Windows.Forms.Label lblTierpfleger;
        private System.Windows.Forms.Button btnFeed;
    }
}