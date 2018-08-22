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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.language = new System.Windows.Forms.ComboBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listMods = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.version = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonScenarios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonConquest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonProfiles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAdventures = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonPacks = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // language
            // 
            this.language.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language.FormattingEnabled = true;
            this.language.Location = new System.Drawing.Point(21, 191);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(86, 22);
            this.language.TabIndex = 3;
            this.language.SelectedIndexChanged += new System.EventHandler(this.language_SelectedIndexChanged);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(400, 244);
            this.materialTabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.playButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.language);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Depth = 0;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(110, 186);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(70, 30);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAdventures);
            this.tabPage2.Controls.Add(this.buttonProfiles);
            this.tabPage2.Controls.Add(this.buttonConquest);
            this.tabPage2.Controls.Add(this.buttonScenarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Utilities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonPacks);
            this.tabPage3.Controls.Add(this.listMods);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 218);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MODs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listMods
            // 
            this.listMods.BackColor = System.Drawing.Color.DimGray;
            this.listMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMods.ForeColor = System.Drawing.Color.White;
            this.listMods.FormattingEnabled = true;
            this.listMods.Location = new System.Drawing.Point(6, 6);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(383, 199);
            this.listMods.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialLabel4);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.linkLabel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 218);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CREDITS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(79, 217);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(219, 29);
            this.linkLabel4.TabIndex = 14;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Haemimont Games";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 28);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(401, 33);
            this.materialTabSelector1.TabIndex = 8;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Depth = 0;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.version.Location = new System.Drawing.Point(126, 314);
            this.version.MouseState = MaterialSkin.MouseState.HOVER;
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(161, 18);
            this.version.TabIndex = 19;
            this.version.Text = "GBR Steam Beta v1.51";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(147, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 18);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Imperivm World";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click_2);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(140, 45);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 54);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Razor\r\nThe Master\r\nRicky96Highlander";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(168, 152);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 18);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "@d4nijerez\r\n";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(141, 125);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(146, 18);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "fxgamestudio.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::launcher_imperivm_iii.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.AutoSize = true;
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.Depth = 0;
            this.playButton.Icon = global::launcher_imperivm_iii.Properties.Resources.run;
            this.playButton.Location = new System.Drawing.Point(275, 181);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.playButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.playButton.Name = "playButton";
            this.playButton.Primary = false;
            this.playButton.Size = new System.Drawing.Size(83, 36);
            this.playButton.TabIndex = 16;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.Icon = global::launcher_imperivm_iii.Properties.Resources.save;
            this.saveButton.Location = new System.Drawing.Point(184, 182);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = false;
            this.saveButton.Size = new System.Drawing.Size(83, 36);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // buttonScenarios
            // 
            this.buttonScenarios.AutoSize = true;
            this.buttonScenarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonScenarios.Depth = 0;
            this.buttonScenarios.Icon = null;
            this.buttonScenarios.Location = new System.Drawing.Point(19, 61);
            this.buttonScenarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonScenarios.Name = "buttonScenarios";
            this.buttonScenarios.Primary = true;
            this.buttonScenarios.Size = new System.Drawing.Size(103, 36);
            this.buttonScenarios.TabIndex = 18;
            this.buttonScenarios.Text = "ESCENARIOS";
            this.buttonScenarios.UseVisualStyleBackColor = true;
            this.buttonScenarios.Click += new System.EventHandler(this.buttonScenarios_Click_2);
            // 
            // buttonConquest
            // 
            this.buttonConquest.AutoSize = true;
            this.buttonConquest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConquest.Depth = 0;
            this.buttonConquest.Icon = null;
            this.buttonConquest.Location = new System.Drawing.Point(19, 103);
            this.buttonConquest.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonConquest.Name = "buttonConquest";
            this.buttonConquest.Primary = true;
            this.buttonConquest.Size = new System.Drawing.Size(92, 36);
            this.buttonConquest.TabIndex = 19;
            this.buttonConquest.Text = "CONQUEST";
            this.buttonConquest.UseVisualStyleBackColor = true;
            this.buttonConquest.Click += new System.EventHandler(this.buttonConquest_Click_1);
            // 
            // buttonProfiles
            // 
            this.buttonProfiles.AutoSize = true;
            this.buttonProfiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProfiles.Depth = 0;
            this.buttonProfiles.Icon = null;
            this.buttonProfiles.Location = new System.Drawing.Point(220, 103);
            this.buttonProfiles.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProfiles.Name = "buttonProfiles";
            this.buttonProfiles.Primary = true;
            this.buttonProfiles.Size = new System.Drawing.Size(81, 36);
            this.buttonProfiles.TabIndex = 20;
            this.buttonProfiles.Text = "PERFILES";
            this.buttonProfiles.UseVisualStyleBackColor = true;
            this.buttonProfiles.Click += new System.EventHandler(this.buttonProfiles_Click_1);
            // 
            // buttonAdventures
            // 
            this.buttonAdventures.AutoSize = true;
            this.buttonAdventures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdventures.Depth = 0;
            this.buttonAdventures.Icon = null;
            this.buttonAdventures.Location = new System.Drawing.Point(220, 61);
            this.buttonAdventures.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdventures.Name = "buttonAdventures";
            this.buttonAdventures.Primary = true;
            this.buttonAdventures.Size = new System.Drawing.Size(107, 36);
            this.buttonAdventures.TabIndex = 21;
            this.buttonAdventures.Text = "ADVENTURES";
            this.buttonAdventures.UseVisualStyleBackColor = true;
            this.buttonAdventures.Click += new System.EventHandler(this.buttonAdventures_Click_2);
            // 
            // buttonPacks
            // 
            this.buttonPacks.AutoSize = true;
            this.buttonPacks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPacks.Depth = 0;
            this.buttonPacks.Icon = null;
            this.buttonPacks.Location = new System.Drawing.Point(328, 165);
            this.buttonPacks.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPacks.Name = "buttonPacks";
            this.buttonPacks.Primary = true;
            this.buttonPacks.Size = new System.Drawing.Size(56, 36);
            this.buttonPacks.TabIndex = 14;
            this.buttonPacks.Text = "PAKs";
            this.buttonPacks.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 341);
            this.Controls.Add(this.version);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox language;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox listMods;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private MaterialSkin.Controls.MaterialCheckBox checkBox1;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private MaterialSkin.Controls.MaterialFlatButton playButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel version;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonScenarios;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdventures;
        private MaterialSkin.Controls.MaterialRaisedButton buttonProfiles;
        private MaterialSkin.Controls.MaterialRaisedButton buttonConquest;
        private MaterialSkin.Controls.MaterialRaisedButton buttonPacks;
    }
}

