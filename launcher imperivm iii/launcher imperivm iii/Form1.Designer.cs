namespace launcher_imperivm_iii
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
            this.resolution = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // resolution
            // 
            this.resolution.FormattingEnabled = true;
            this.resolution.Location = new System.Drawing.Point(74, 39);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(121, 21);
            this.resolution.TabIndex = 0;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(11, 42);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(57, 13);
            this.labelResolution.TabIndex = 1;
            this.labelResolution.Text = "Resolution";
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(212, 37);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(11, 15);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "Language";
            // 
            // language
            // 
            this.language.FormattingEnabled = true;
            this.language.Location = new System.Drawing.Point(74, 12);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(121, 21);
            this.language.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(71, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "daniel.jerez@fxgamestudio.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 100);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.language);
            this.Controls.Add(this.play);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.resolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imperivm III HD - Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

