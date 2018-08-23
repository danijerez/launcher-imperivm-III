using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Media;

namespace launcher_imperivm_iii
{
    public partial class Form1 : MaterialForm
    {


        IniParser parserSettings = new IniParser(@"Settings.ini");
        IniParser parserLauncher = new IniParser(@"Launcher.ini");
        SoundPlayer simpleSound;
        bool isSoundPlay = true;



        public Form1()
        {

            


            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey700, Primary.Grey700, Primary.Grey500, Accent.Amber200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            changeLanguageResolution();
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
            if (checkBox1.Checked)
            {
                processStartInfo.Verb = "runas";
            }
            processStartInfo.FileName = @"gbr.exe";
            System.Diagnostics.Process.Start(processStartInfo);
            //Process.Start(@"gbr.exe");

            Application.Exit();

        }

        private void changeLanguageResolution()
        {
            parserSettings.AddSetting("Language", "Default", language.Text);
            //parserSettings.AddSetting("Options", "Resolution", resolution.SelectedIndex.ToString());
            parserSettings.SaveSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            simpleSound = new SoundPlayer(@"Music/launcher.wav");
            simpleSound.Play();

            var pakLanguages = new DirectoryInfo("local").GetFiles("*.pak");
            for(int i = 0; i < pakLanguages.Length; i++)
            {
                language.Items.Add(FirstCharToUpper(pakLanguages[i].Name.Split('.')[0]));
            }

            IniParser parser = new IniParser(@"Settings.ini");
            String languageDefault = (parser.GetSetting("Language", "Default")).ToUpper();

            language.SelectedIndex = language.FindStringExact(languageDefault);

            String resolutionDefault = (parser.GetSetting("Options", "Resolution"));

            resolution.Items.Add("1024 x 768");
            resolution.Items.Add("1152 x 864");
            resolution.Items.Add("1280 x 1024");
            resolution.Items.Add("1280 x 720");
            resolution.Items.Add("1366 x 768");
            resolution.Items.Add("1920 x 1080");

            resolution.SelectedIndex = int.Parse(resolutionDefault);

            loadLanguageLauncher();

            loadFolderMods();


        }


        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:daniel.jerez@fxgamestudio.com");
        }

        private void loadLanguageLauncher()
        {
            

            if (parserLauncher != null)
            {
                parserLauncher.AddSetting("Default", "Language", language.Text);
                parserLauncher.SaveSettings();

                String defaultLanguage = parserLauncher.GetSetting("Default", "Language");

                //labelLanguage.Text = parserLauncher.GetSetting(defaultLanguage, "LabelLanguage");
                playButton.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonPlay");
                saveButton.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonSave");
                buttonAdventures.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonAdventures");
                buttonScenarios.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonScenarios");
                buttonProfiles.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonProfiles");
                buttonConquest.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonConquest");

                tabPage1.Text = parserLauncher.GetSetting(defaultLanguage, "Page1");
                tabPage2.Text = parserLauncher.GetSetting(defaultLanguage, "Page2");
                tabPage3.Text = parserLauncher.GetSetting(defaultLanguage, "Page3");
                tabPage4.Text = parserLauncher.GetSetting(defaultLanguage, "Page4");

                if(parserLauncher.GetSetting("Default", "Admin") == "1")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            } 
        }

        private void loadFolderMods()
        {
            List<string> noMods = new List<string> { "AdditionalArt", "Buildings", "data", "emptyadv", "emptyconquest", "emptyscn", "Fonts", "MapObjects", "Minimap", "newmap", "Outlines", "randommap", "RandomMap", "RandomMapSettlements", "Sounds", "Terrain", "UI", "Units", "Visuals" };
            var pakMods = new DirectoryInfo("Packs").GetFiles("*.pak");
            for (int i = 0; i < pakMods.Length; i++)
            {
                String name = pakMods[i].Name.Split('.')[0];
                if (!noMods.Contains(name))
                {
                    listMods.Items.Add(name.ToLower());
                    if (name!=name.ToUpper())
                    {
                        listMods.SetItemChecked(listMods.FindStringExact(name.ToLower()), true);
                    }
                    
                }
            }
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLanguageLauncher();
        }

        private void listMods_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            String item = listMods.Items[e.Index].ToString();
            if (listMods.GetItemChecked(listMods.FindStringExact(item)))
            {
                System.IO.File.Move(@"Packs/" + item + ".pak", @"Packs/" + item.ToUpper() + ".pak");
            }
            else
            { 
                System.IO.File.Move(@"Packs/" + item.ToUpper() + ".pak", @"Packs/" + item + ".pak");
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            changeLanguageResolution();
            parserLauncher.SaveSettings();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                parserLauncher.AddSetting("Default", "Admin", "1");
            }
            else
            {
                parserLauncher.AddSetting("Default", "Admin", "0");
            }
            parserLauncher.SaveSettings();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.fxgamestudio.com/");
        }

        private void buttonScenarios_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"Scenarios");
        }

        private void buttonAdventures_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"Adventures");
        }

        private void buttonConquest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"Conquests");
        }

        private void buttonProfiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"Profiles");
        }

        private void buttonPacks_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"Packs"); 
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            changeLanguageResolution();
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
            if (checkBox1.Checked)
            {
                processStartInfo.Verb = "runas";
            }
            processStartInfo.FileName = @"gbr.exe";
            System.Diagnostics.Process.Start(processStartInfo);
            //Process.Start(@"gbr.exe");

            Application.Exit();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            changeLanguageResolution();
            parserLauncher.SaveSettings();
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            changeLanguageResolution();
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
            if (checkBox1.Checked)
            {
                processStartInfo.Verb = "runas";
            }
            processStartInfo.FileName = @"gbr.exe";
            System.Diagnostics.Process.Start(processStartInfo);
            //Process.Start(@"gbr.exe");

            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (isSoundPlay)
            {
                isSoundPlay = false;
                simpleSound.Stop();
            }
            else
            {
                simpleSound.Play();
                isSoundPlay = true;
            }
            
        }
    }
}
