﻿namespace launcher_imperivm_iii
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.checkBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonProfiles = new System.Windows.Forms.Button();
            this.buttonAdventures = new System.Windows.Forms.Button();
            this.buttonConquest = new System.Windows.Forms.Button();
            this.buttonScenarios = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonPacks = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listMods = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.version = new MaterialSkin.Controls.MaterialLabel();
            this.resolution = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // language
            // 
            this.language.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language.FormattingEnabled = true;
            this.language.Location = new System.Drawing.Point(39, 313);
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
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.playButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::launcher_imperivm_iii.Properties.Resources.adm;
            this.pictureBox2.Location = new System.Drawing.Point(13, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
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
            this.playButton.Location = new System.Drawing.Point(293, 182);
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
            this.saveButton.Location = new System.Drawing.Point(67, 182);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Depth = 0;
            this.checkBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBox1.Location = new System.Drawing.Point(37, 186);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(26, 30);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox9);
            this.tabPage2.Controls.Add(this.pictureBox8);
            this.tabPage2.Controls.Add(this.pictureBox7);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Controls.Add(this.buttonProfiles);
            this.tabPage2.Controls.Add(this.buttonAdventures);
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
            // pictureBox9
            // 
            this.pictureBox9.Image = global::launcher_imperivm_iii.Properties.Resources.reanudar;
            this.pictureBox9.Location = new System.Drawing.Point(203, 126);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(52, 51);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 29;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::launcher_imperivm_iii.Properties.Resources.bandera_en_un_planeta_bajo_las_estrellas;
            this.pictureBox8.Location = new System.Drawing.Point(19, 126);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(52, 51);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::launcher_imperivm_iii.Properties.Resources.casco_romano;
            this.pictureBox7.Location = new System.Drawing.Point(203, 53);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::launcher_imperivm_iii.Properties.Resources.mapa;
            this.pictureBox6.Location = new System.Drawing.Point(19, 53);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // buttonProfiles
            // 
            this.buttonProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfiles.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.buttonProfiles.ForeColor = System.Drawing.Color.DimGray;
            this.buttonProfiles.Location = new System.Drawing.Point(261, 126);
            this.buttonProfiles.Name = "buttonProfiles";
            this.buttonProfiles.Size = new System.Drawing.Size(116, 51);
            this.buttonProfiles.TabIndex = 25;
            this.buttonProfiles.Text = "button4";
            this.buttonProfiles.UseVisualStyleBackColor = true;
            this.buttonProfiles.Click += new System.EventHandler(this.buttonProfiles_Click);
            // 
            // buttonAdventures
            // 
            this.buttonAdventures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdventures.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.buttonAdventures.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAdventures.Location = new System.Drawing.Point(261, 53);
            this.buttonAdventures.Name = "buttonAdventures";
            this.buttonAdventures.Size = new System.Drawing.Size(116, 51);
            this.buttonAdventures.TabIndex = 24;
            this.buttonAdventures.Text = "button3";
            this.buttonAdventures.UseVisualStyleBackColor = true;
            this.buttonAdventures.Click += new System.EventHandler(this.buttonAdventures_Click);
            // 
            // buttonConquest
            // 
            this.buttonConquest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConquest.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.buttonConquest.ForeColor = System.Drawing.Color.DimGray;
            this.buttonConquest.Location = new System.Drawing.Point(77, 126);
            this.buttonConquest.Name = "buttonConquest";
            this.buttonConquest.Size = new System.Drawing.Size(114, 51);
            this.buttonConquest.TabIndex = 23;
            this.buttonConquest.Text = "button2";
            this.buttonConquest.UseVisualStyleBackColor = true;
            this.buttonConquest.Click += new System.EventHandler(this.buttonConquest_Click);
            // 
            // buttonScenarios
            // 
            this.buttonScenarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScenarios.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScenarios.ForeColor = System.Drawing.Color.DimGray;
            this.buttonScenarios.Location = new System.Drawing.Point(77, 53);
            this.buttonScenarios.Name = "buttonScenarios";
            this.buttonScenarios.Size = new System.Drawing.Size(114, 51);
            this.buttonScenarios.TabIndex = 22;
            this.buttonScenarios.Text = "buttonScenarios";
            this.buttonScenarios.UseVisualStyleBackColor = true;
            this.buttonScenarios.Click += new System.EventHandler(this.buttonScenarios_Click);
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
            // buttonPacks
            // 
            this.buttonPacks.AutoSize = true;
            this.buttonPacks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPacks.Depth = 0;
            this.buttonPacks.Icon = null;
            this.buttonPacks.Location = new System.Drawing.Point(329, 179);
            this.buttonPacks.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPacks.Name = "buttonPacks";
            this.buttonPacks.Primary = true;
            this.buttonPacks.Size = new System.Drawing.Size(56, 36);
            this.buttonPacks.TabIndex = 14;
            this.buttonPacks.Text = "PAKs";
            this.buttonPacks.UseVisualStyleBackColor = true;
            this.buttonPacks.Click += new System.EventHandler(this.buttonPacks_Click);
            // 
            // listMods
            // 
            this.listMods.BackColor = System.Drawing.Color.DimGray;
            this.listMods.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMods.ForeColor = System.Drawing.Color.White;
            this.listMods.FormattingEnabled = true;
            this.listMods.Location = new System.Drawing.Point(6, 6);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(383, 212);
            this.listMods.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox13);
            this.tabPage4.Controls.Add(this.pictureBox12);
            this.tabPage4.Controls.Add(this.pictureBox11);
            this.tabPage4.Controls.Add(this.pictureBox10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 218);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(304, 168);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(64, 34);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 30;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(154, 168);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 34);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 29;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::launcher_imperivm_iii.Properties.Resources.logo_de_aplicacion_de_facebook;
            this.pictureBox11.Location = new System.Drawing.Point(104, 168);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 34);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 28;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::launcher_imperivm_iii.Properties.Resources.discord1;
            this.pictureBox10.Location = new System.Drawing.Point(57, 168);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 34);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(5, 28);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(407, 33);
            this.materialTabSelector1.TabIndex = 8;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Depth = 0;
            this.version.Font = new System.Drawing.Font("Roboto", 11F);
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.version.Location = new System.Drawing.Point(274, 314);
            this.version.MouseState = MaterialSkin.MouseState.HOVER;
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(135, 19);
            this.version.TabIndex = 19;
            this.version.Text = "GBR HD Beta v1.51";
            // 
            // resolution
            // 
            this.resolution.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolution.FormattingEnabled = true;
            this.resolution.Location = new System.Drawing.Point(159, 313);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(86, 22);
            this.resolution.TabIndex = 20;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::launcher_imperivm_iii.Properties.Resources.indicador_del_volumen_apagado;
            this.pictureBox5.Location = new System.Drawing.Point(251, 313);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::launcher_imperivm_iii.Properties.Resources.lan;
            this.pictureBox4.Location = new System.Drawing.Point(16, 313);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::launcher_imperivm_iii.Properties.Resources.res;
            this.pictureBox3.Location = new System.Drawing.Point(131, 314);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 341);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.version);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.language);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.CheckedListBox listMods;
        private MaterialSkin.Controls.MaterialCheckBox checkBox1;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private MaterialSkin.Controls.MaterialFlatButton playButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel version;
        private MaterialSkin.Controls.MaterialRaisedButton buttonPacks;
        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonScenarios;
        private System.Windows.Forms.Button buttonProfiles;
        private System.Windows.Forms.Button buttonAdventures;
        private System.Windows.Forms.Button buttonConquest;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}

