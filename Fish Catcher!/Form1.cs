using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Fish_Catcher_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Spiel Starten
        private void btnStart_Click(object sender, EventArgs e)
        {
            MainScreen GameStart = new MainScreen();
            GameStart.Show();
            this.Hide();
        }

        // Highscore-Fenster öffnen
        private void btnHighscore_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.EnableRaisingEvents = false;
            process.StartInfo.FileName = "C:\\temp\\Readme.txt";
            process.Start();
        }
    }
}
