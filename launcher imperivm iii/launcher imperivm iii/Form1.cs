using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            IniParser parser = new IniParser(@"Settings.ini");
            parser.AddSetting("Language", "Default", "English");
            parser.SaveSettings();
            String  languaje = parser.GetSetting("Language", "Default");
            
            labelLanguage.Text = languaje;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"gbr.exe");
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
