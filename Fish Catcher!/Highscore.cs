using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish_Catcher_
{
    public partial class Highscore : Form
    {
        public int entrycounter = 0;
        List<Class1> scores = new List<Class1>();

        public Highscore()
        {
            InitializeComponent();
            txtHighscore.Text = File.ReadAllText(@"C:\\temp\\Highscore.txt");
        }
        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnZuruck_Click(object sender, EventArgs e)
        {    
            this.Close();
            Application.Restart();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(entrycounter == 0)
            {
                Class1 personen = new Class1();
                personen.person = txtName.Text;
                personen.scores = Convert.ToInt32(txtScore.Text);
                scores.Add(personen);

                foreach (Class1 player in scores)
                {
                    File.AppendAllText(@"C:\\temp\\Highscore.txt", personen.scores + "\t" + personen.person + Environment.NewLine);
                }

                txtHighscore.Text += personen.scores + "\t" + personen.person;
                txtName.ReadOnly = true;
                entrycounter++;
            }
            else
            {

            }
        }
    }
}
