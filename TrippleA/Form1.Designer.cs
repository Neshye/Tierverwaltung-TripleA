namespace TripleA
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.asiaButton = new System.Windows.Forms.Button();
            this.afrikaButton = new System.Windows.Forms.Button();
            this.alaskaButton = new System.Windows.Forms.Button();
            this.rdbKevin = new System.Windows.Forms.RadioButton();
            this.rdbJaqueline = new System.Windows.Forms.RadioButton();
            this.lblKevinFeedCounter = new System.Windows.Forms.Label();
            this.lblJaquelineFeedCounter = new System.Windows.Forms.Label();
            this.pbKevin = new System.Windows.Forms.ProgressBar();
            this.lblStatusKev = new System.Windows.Forms.Label();
            this.btnLagerKevin = new System.Windows.Forms.Button();
            this.pbJaqueline = new System.Windows.Forms.ProgressBar();
            this.btnLagerJaq = new System.Windows.Forms.Button();
            this.lblStatusJaq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asiaButton
            // 
            this.asiaButton.Location = new System.Drawing.Point(12, 139);
            this.asiaButton.Name = "asiaButton";
            this.asiaButton.Size = new System.Drawing.Size(162, 201);
            this.asiaButton.TabIndex = 0;
            this.asiaButton.Tag = "asiaButton";
            this.asiaButton.UseVisualStyleBackColor = true;
            this.asiaButton.Click += new System.EventHandler(this.btnAsia_Click);
            // 
            // afrikaButton
            // 
            this.afrikaButton.Location = new System.Drawing.Point(195, 139);
            this.afrikaButton.Name = "afrikaButton";
            this.afrikaButton.Size = new System.Drawing.Size(161, 201);
            this.afrikaButton.TabIndex = 1;
            this.afrikaButton.Tag = "afrikaButton";
            this.afrikaButton.UseVisualStyleBackColor = true;
            this.afrikaButton.Click += new System.EventHandler(this.btnAfrika_Click);
            // 
            // alaskaButton
            // 
            this.alaskaButton.Location = new System.Drawing.Point(376, 139);
            this.alaskaButton.Name = "alaskaButton";
            this.alaskaButton.Size = new System.Drawing.Size(166, 201);
            this.alaskaButton.TabIndex = 2;
            this.alaskaButton.Tag = "alaskaButton";
            this.alaskaButton.UseVisualStyleBackColor = true;
            this.alaskaButton.Click += new System.EventHandler(this.btnAlaska_Click);
            // 
            // rdbKevin
            // 
            this.rdbKevin.AutoSize = true;
            this.rdbKevin.Checked = true;
            this.rdbKevin.Location = new System.Drawing.Point(624, 139);
            this.rdbKevin.Name = "rdbKevin";
            this.rdbKevin.Size = new System.Drawing.Size(85, 17);
            this.rdbKevin.TabIndex = 4;
            this.rdbKevin.TabStop = true;
            this.rdbKevin.Text = "radioButton1";
            this.rdbKevin.UseVisualStyleBackColor = true;
            // 
            // rdbJaqueline
            // 
            this.rdbJaqueline.AutoSize = true;
            this.rdbJaqueline.Location = new System.Drawing.Point(624, 254);
            this.rdbJaqueline.Name = "rdbJaqueline";
            this.rdbJaqueline.Size = new System.Drawing.Size(85, 17);
            this.rdbJaqueline.TabIndex = 5;
            this.rdbJaqueline.Text = "radioButton2";
            this.rdbJaqueline.UseVisualStyleBackColor = true;
            // 
            // lblKevinFeedCounter
            // 
            this.lblKevinFeedCounter.AutoSize = true;
            this.lblKevinFeedCounter.Location = new System.Drawing.Point(621, 159);
            this.lblKevinFeedCounter.Name = "lblKevinFeedCounter";
            this.lblKevinFeedCounter.Size = new System.Drawing.Size(35, 13);
            this.lblKevinFeedCounter.TabIndex = 6;
            this.lblKevinFeedCounter.Text = "label1";
            // 
            // lblJaquelineFeedCounter
            // 
            this.lblJaquelineFeedCounter.AutoSize = true;
            this.lblJaquelineFeedCounter.Location = new System.Drawing.Point(621, 274);
            this.lblJaquelineFeedCounter.Name = "lblJaquelineFeedCounter";
            this.lblJaquelineFeedCounter.Size = new System.Drawing.Size(35, 13);
            this.lblJaquelineFeedCounter.TabIndex = 7;
            this.lblJaquelineFeedCounter.Text = "label1";
            // 
            // pbKevin
            // 
            this.pbKevin.Location = new System.Drawing.Point(624, 175);
            this.pbKevin.Name = "pbKevin";
            this.pbKevin.Size = new System.Drawing.Size(123, 23);
            this.pbKevin.TabIndex = 8;
            // 
            // lblStatusKev
            // 
            this.lblStatusKev.AutoSize = true;
            this.lblStatusKev.Location = new System.Drawing.Point(753, 185);
            this.lblStatusKev.Name = "lblStatusKev";
            this.lblStatusKev.Size = new System.Drawing.Size(35, 13);
            this.lblStatusKev.TabIndex = 9;
            this.lblStatusKev.Text = "label1";
            // 
            // btnLagerKevin
            // 
            this.btnLagerKevin.Location = new System.Drawing.Point(624, 205);
            this.btnLagerKevin.Name = "btnLagerKevin";
            this.btnLagerKevin.Size = new System.Drawing.Size(75, 23);
            this.btnLagerKevin.TabIndex = 10;
            this.btnLagerKevin.Text = "Lager";
            this.btnLagerKevin.UseVisualStyleBackColor = true;
            this.btnLagerKevin.Click += new System.EventHandler(this.btnLagerKevin_Click);
            // 
            // pbJaqueline
            // 
            this.pbJaqueline.Location = new System.Drawing.Point(624, 291);
            this.pbJaqueline.Name = "pbJaqueline";
            this.pbJaqueline.Size = new System.Drawing.Size(123, 23);
            this.pbJaqueline.TabIndex = 11;
            // 
            // btnLagerJaq
            // 
            this.btnLagerJaq.Location = new System.Drawing.Point(624, 321);
            this.btnLagerJaq.Name = "btnLagerJaq";
            this.btnLagerJaq.Size = new System.Drawing.Size(75, 23);
            this.btnLagerJaq.TabIndex = 12;
            this.btnLagerJaq.Text = "Lager";
            this.btnLagerJaq.UseVisualStyleBackColor = true;
            this.btnLagerJaq.Click += new System.EventHandler(this.btnLagerJaq_Click);
            // 
            // lblStatusJaq
            // 
            this.lblStatusJaq.AutoSize = true;
            this.lblStatusJaq.Location = new System.Drawing.Point(754, 300);
            this.lblStatusJaq.Name = "lblStatusJaq";
            this.lblStatusJaq.Size = new System.Drawing.Size(35, 13);
            this.lblStatusJaq.TabIndex = 13;
            this.lblStatusJaq.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusJaq);
            this.Controls.Add(this.btnLagerJaq);
            this.Controls.Add(this.pbJaqueline);
            this.Controls.Add(this.btnLagerKevin);
            this.Controls.Add(this.lblStatusKev);
            this.Controls.Add(this.pbKevin);
            this.Controls.Add(this.lblJaquelineFeedCounter);
            this.Controls.Add(this.lblKevinFeedCounter);
            this.Controls.Add(this.rdbJaqueline);
            this.Controls.Add(this.rdbKevin);
            this.Controls.Add(this.alaskaButton);
            this.Controls.Add(this.afrikaButton);
            this.Controls.Add(this.asiaButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripleA Zooverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button asiaButton;
        private System.Windows.Forms.Button afrikaButton;
        private System.Windows.Forms.Button alaskaButton;
        private System.Windows.Forms.Label lblKevinFeedCounter;
        private System.Windows.Forms.Label lblJaquelineFeedCounter;
        private System.Windows.Forms.Label lblStatusKev;
        public System.Windows.Forms.ProgressBar pbKevin;
        private System.Windows.Forms.Label lblStatusJaq;
        public System.Windows.Forms.RadioButton rdbKevin;
        public System.Windows.Forms.RadioButton rdbJaqueline;
        public System.Windows.Forms.ProgressBar pbJaqueline;
        public System.Windows.Forms.Button btnLagerKevin;
        public System.Windows.Forms.Button btnLagerJaq;
    }
}

