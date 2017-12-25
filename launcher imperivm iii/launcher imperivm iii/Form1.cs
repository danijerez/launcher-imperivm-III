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

namespace launcher_imperivm_iii
{
    public partial class Form1 : Form
    {

        IniParser parserSettings = new IniParser(@"Settings.ini");
        IniParser parserLauncher = new IniParser(@"Launcher.ini");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            changeLanguageResolution();
            
            Process.Start(@"gbr.exe");

            Application.Exit();

        }

        private void changeLanguageResolution()
        {
            parserSettings.AddSetting("Language", "Default", language.Text);
            parserSettings.AddSetting("Options", "Resolution", resolution.SelectedIndex.ToString());
            parserSettings.SaveSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            resolution.Items.Add("1440 x 900");
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

                labelLanguage.Text = parserLauncher.GetSetting(defaultLanguage, "LabelLanguage");
                labelResolution.Text = parserLauncher.GetSetting(defaultLanguage, "LabelResolution");
                playButton.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonPlay");
                saveButton.Text = parserLauncher.GetSetting(defaultLanguage, "ButtonSave");

                tabPage1.Text = parserLauncher.GetSetting(defaultLanguage, "Page1");
                tabPage2.Text = parserLauncher.GetSetting(defaultLanguage, "Page2");
                tabPage3.Text = parserLauncher.GetSetting(defaultLanguage, "Page3");
                tabPage4.Text = parserLauncher.GetSetting(defaultLanguage, "Page4");
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
    }
}
