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
            this.components = new System.ComponentModel.Container();
            this.playButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listMods = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.resolution = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(154, 241);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(73, 241);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.linkLabel3);
            this.tabPage4.Controls.Add(this.linkLabel2);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(267, 194);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Credits";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(46, 57);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(173, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "imperivm-world.forumcommunity.net";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(46, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "daniel.jerez@fxgamestudio.com";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listMods);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(267, 194);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MODs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listMods
            // 
            this.listMods.FormattingEnabled = true;
            this.listMods.Location = new System.Drawing.Point(3, 12);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(261, 169);
            this.listMods.TabIndex = 0;
            this.listMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listMods_ItemCheck);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.resolution);
            this.tabPage1.Controls.Add(this.labelResolution);
            this.tabPage1.Controls.Add(this.labelLanguage);
            this.tabPage1.Controls.Add(this.language);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // resolution
            // 
            this.resolution.FormattingEnabled = true;
            this.resolution.Location = new System.Drawing.Point(104, 147);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(121, 21);
            this.resolution.TabIndex = 0;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(41, 150);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(57, 13);
            this.labelResolution.TabIndex = 1;
            this.labelResolution.Text = "Resolution";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(41, 123);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "Language";
            // 
            // language
            // 
            this.language.FormattingEnabled = true;
            this.language.Location = new System.Drawing.Point(104, 120);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(121, 21);
            this.language.TabIndex = 3;
            this.language.SelectedIndexChanged += new System.EventHandler(this.language_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 220);
            this.tabControl1.TabIndex = 6;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(46, 116);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(96, 13);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Haemimont Games";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 276);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imperivm III HD - Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox listMods;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ImageList imageList1;
    }
}

