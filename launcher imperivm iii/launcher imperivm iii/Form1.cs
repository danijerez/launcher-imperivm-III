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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IniParser parser = new IniParser(@"Settings.ini");

            parser.AddSetting("Language", "Default", language.Text);
            parser.AddSetting("Options", "Resolution", resolution.SelectedIndex.ToString());

            parser.SaveSettings();

            Process.Start(@"gbr.exe");

            Application.Exit();

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
            IniParser parser = new IniParser(@"Launcher.ini");

            if (parser!=null)
            {
                parser.AddSetting("Default", "Language", language.Text);
                parser.SaveSettings();

                String defaultLanguage = parser.GetSetting("Default", "Language");

                labelLanguage.Text = parser.GetSetting(defaultLanguage, "LabelLanguage");
                labelResolution.Text = parser.GetSetting(defaultLanguage, "LabelResolution");
                playButton.Text = parser.GetSetting(defaultLanguage, "ButtonPlay");
            } 
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLanguageLauncher();
        }
    }
}
