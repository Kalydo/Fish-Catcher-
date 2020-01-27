using System;
using System.Media;
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
    public partial class MainScreen : Form
    {
        // Random Variable
        public int x;
        // Punkte Variable 
        public int score;
        // Leben
        public int lives = 3;
        // Effective Punktzahl
        public int sco;
        // Score von nächstem fisch 
        public int presco;
        // Beschleunigung der Fische
        public int speed = 1;
        public MainScreen()
        {
            InitializeComponent();
        }

        // Programm Beenden
        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Spiel Pausieren
        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrGame.Stop();
        }

        // Game 
        private void tmrGame_Tick(object sender, EventArgs e)
        {
            
            int CurrentX = picFall1.Location.X;
            int CurrentY = picFall1.Location.Y;
            int newX = Convert.ToInt32(pnlSpiel.Width / 100.0 * scbKorbController.Value);
            int SubtractX = Convert.ToInt32(70.0 / 100.0 * scbKorbController.Value);
            txtHighscore.Text = Convert.ToString(score);
            
            if (pnlSpiel.Location.X > pnlSpiel.Width)
            {
                int lenge = picKorb.Location.X;
                lenge = 551;
                picKorb.Location = new Point(lenge, scbKorbController.Location.Y - picKorb.Height);
            }
            else
            {
                picKorb.Location = new Point(newX - SubtractX, scbKorbController.Location.Y - picKorb.Height);
            }

            if (picFall1.Visible == false)
            {
                picFall1.Image = pictureBox4.Image;
                pictureBox4.Image = RandomFischimage(presco = FishRandom());
            }
            else
            {
                picFall1.Location = new Point(CurrentX, CurrentY + speed);
            }

            if (picFall1.Bottom - 30 >= picKorb.Top &&
                picFall1.Right - 70 >= picKorb.Left &&
                picFall1.Left + 70 <= picKorb.Right)
            {
                speed++;
                givethescore(sco);
                sco = presco;
                picFall1.Visible = false;
            }

            // Fisch erreicht das Out
            if (picFall1.Location.Y > 700)
            {
                picFall1.Visible = false;

                if (sco == -25)
                {
                    speed = 5;
                }
                else
                {
                    if (--speed <= 0)
                    {
                        speed++;
                    }
                    else
                    {
                        --speed;
                    }
                    --lives; 
                }

                sco = presco;

                switch (lives)
                {
                    case 0:
                        pictureBox1.Visible = false;
                        break;
                    case 1:
                        pictureBox3.Visible = false;
                        break;
                    case 2:
                        pictureBox2.Visible = false;
                        break;
                }
                if (lives == 0)
                {
                    SoundPlayer bubble = new SoundPlayer(Properties.Resources.Game___Over_Text);
                    bubble.Play();
                    tmrGame.Stop();
                    Highscore hit = new Highscore();
                    hit.Show();
                    hit.txtScore.Text = Convert.ToString(score);
                    btnPause.Visible = false;
                    btnStarten.Visible = false;
                    btnBeenden.Visible = false;
                }
            }
        }

        // Starten des Spiels
        private void btnStarten_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = RandomFischimage(sco = 1);
            SoundPlayer bubble = new SoundPlayer(Properties.Resources.The_Little_Mermaid___Under_the_Sea);
            bubble.Play();
            tmrGame.Start();
        }

        // Neuen Fisch Generieren
        public Image RandomFischimage(int punktzahl)
        {
            switch (punktzahl)
            {
                case 4:
                    return Properties.Resources.Barsch;
                case 1:
                    return Properties.Resources.Goldfisch;
                case 10:
                    return Properties.Resources.Hai;
                case 7:
                    return Properties.Resources.Karpfen;
                case 5:
                    return Properties.Resources.KoiKarpfen;
                case 6:
                    return Properties.Resources.Lachs;
                case 2:
                    return Properties.Resources.Stint;
                case 20:
                    return Properties.Resources.Wal;
                case 8:
                    return Properties.Resources.Thunfisch;
                case -25:
                    return Properties.Resources.Mine;
                default:
                    return Properties.Resources.Mine;
            }
        }

        public int FishRandom()
        {
            Random RandomFish = new Random();
            int Fish = RandomFish.Next(0, 10);
            picFall1.Visible = true;
            int ra = RandomPos();
            picFall1.Location = new Point(ra, -20);

            switch (Fish)
            {
                case 0:
                    return 4;
                case 1:
                    return 1;
                case 2:
                    return 10;
                case 3:
                    return 7;
                case 4:
                    return 5;
                case 5:
                    return 6;
                case 6:
                    return 2;
                case 7:
                    return 20;
                case 8:
                    return 8;
                case 9:
                    return -25;
            }
            return 0;
        }

        // Random Position vom näschten Fisch bestimmen
        public int RandomPos()
        {
            Random RandomPosition = new Random();
            x = RandomPosition.Next(0, 613);
            return x;
        }

        // Den effektiven Score übertragen
        public void givethescore(int sco)
        {
                score += sco;
        }

    }
}
