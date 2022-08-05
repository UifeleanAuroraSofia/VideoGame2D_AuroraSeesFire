using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Joc
{
    public partial class Joc : Form
    {

        WindowsMediaPlayer muzicafundal;
        WindowsMediaPlayer muzicamunitie;
        WindowsMediaPlayer muzicaexplozie;
        WindowsMediaPlayer muzicainima;
        WindowsMediaPlayer muzicaaipierdut;

        PictureBox[] stele_de_fundal;
        PictureBox[] inamici;
        PictureBox[] gloante;
        PictureBox[] gloante_inamici;

        int viteza_de_background;
        int viteza_jucator;
        int viteza_glont;
        int viteza_inamic;
        int viteza_glont_inamici;

        public string idut;
        public string idad;
        public int puncte_initiale;

        int hard;
        public int scor;
        int level;
        int glontok = 0;
        int pauza = 0;
        int sunetmuzicaglont = 0;
        int miscarejucatorstop = 1;
        int sunet = 0;
        int aipierdut = 0;
        int dr = 1;
        int st = 0;
        public int inimi = 0;

        Random rnd;

        public Joc(int punctaj, string idutilizator, string idadministrator)
        {
            InitializeComponent();
            idut = idutilizator;
            idad = idadministrator;
        }

        private void Joc_Load(object sender, EventArgs e)
        {
            viteza_de_background = 4;
            viteza_jucator = 8;
            viteza_inamic = 5;
            viteza_glont = 10;
            viteza_glont_inamici = 4;

            hard = 7;
            scor = 0;
            level = 1;

            gloante = new PictureBox[1];
            stele_de_fundal = new PictureBox[30];

            rnd = new Random();

            for (int i = 0; i < stele_de_fundal.Length; i++)
            {
                stele_de_fundal[i] = new PictureBox();
                stele_de_fundal[i].BorderStyle = BorderStyle.None;
                stele_de_fundal[i].Location = new Point(rnd.Next(20, 885), rnd.Next(-10, 865));
                if (i % 2 == 1)
                {
                    stele_de_fundal[i].Size = new Size(1, 1);
                    stele_de_fundal[i].BackColor = Color.Wheat;
                }
                else
                {
                    stele_de_fundal[i].Size = new Size(2, 2);
                    stele_de_fundal[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stele_de_fundal[i]);
            }

            Image energybullet = Image.FromFile(@"asserts\glont-materie.png");

            for (int i = 0; i < gloante.Length; i++)
            {
                gloante[i] = new PictureBox();
                gloante[i].Size = new Size(12, 32);
                gloante[i].Image = energybullet;
                gloante[i].BackColor = Color.Transparent;
                gloante[i].SizeMode = PictureBoxSizeMode.Zoom;
                gloante[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(gloante[i]);
            }

            Image inamic = Image.FromFile("asserts\\inamic.png");
            Image inamic2 = Image.FromFile("asserts\\inamic2.png");
            Image inamic3 = Image.FromFile("asserts\\inamic3.png");
            Image inamic4 = Image.FromFile("asserts\\inamic4.png");
            Image inamic5 = Image.FromFile("asserts\\inamic5.png");
            Image inamic6 = Image.FromFile("asserts\\inamic6.png");
            Image inamic7 = Image.FromFile("asserts\\inamic7.png");
            Image inamic8 = Image.FromFile("asserts\\inamic8.png");

            inamici = new PictureBox[8];

            for (int i = 0; i < inamici.Length; i++)
            {
                inamici[i] = new PictureBox();
                inamici[i].Size = new Size(30, 50);
                inamici[i].SizeMode = PictureBoxSizeMode.Zoom;
                inamici[i].Location = new Point((i + 1) * 92, rnd.Next(-30, -10));
                inamici[i].BackColor = Color.Transparent;
                inamici[i].BorderStyle = BorderStyle.None;
                inamici[i].Visible = false;
                this.Controls.Add(inamici[i]);
            }

            inamici[0].Image = inamic;
            inamici[1].Image = inamic6;
            inamici[2].Image = inamic7;
            inamici[3].Image = inamic8;
            inamici[4].Image = inamic5;
            inamici[5].Image = inamic4;
            inamici[6].Image = inamic3;
            inamici[7].Image = inamic2;

            Image fireball = Image.FromFile("asserts\\fireball.png");

            gloante_inamici = new PictureBox[8];

            for (int i = 0; i < gloante_inamici.Length; i++)
            {
                gloante_inamici[i] = new PictureBox();
                gloante_inamici[i].Size = new Size(10, 18);
                gloante_inamici[i].Visible = false;
                gloante_inamici[i].Image = fireball;
                gloante_inamici[i].SizeMode = PictureBoxSizeMode.Zoom;
                gloante_inamici[i].BackColor = Color.Transparent;
                gloante_inamici[i].BorderStyle = BorderStyle.None;
                int x = rnd.Next(0, 8);
                gloante_inamici[i].Location = new Point(inamici[x].Location.X + 10, inamici[x].Location.Y - 20);
                this.Controls.Add(gloante_inamici[i]);
            }

            muzicafundal = new WindowsMediaPlayer();
            muzicamunitie = new WindowsMediaPlayer();
            muzicaexplozie = new WindowsMediaPlayer();
            muzicainima = new WindowsMediaPlayer();

            muzicafundal.URL = "songs\\muzicadefundal";
            muzicamunitie.URL = "songs\\sunetenergybullet";
            muzicaexplozie.URL = "songs\\sunetexplozie";
            muzicainima.URL = "songs\\sunetinima";

            muzicafundal.settings.setMode("loop", true);
            muzicafundal.settings.volume = 6;
            muzicamunitie.settings.volume = 10;
            muzicaexplozie.settings.volume = 6;
            muzicainima.settings.volume = 8;


            muzicafundal.controls.play();

            CenterToScreen();

        }
        private void Miscare_Background_Tick(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < stele_de_fundal.Length / 2; i++)
                {
                    stele_de_fundal[i].Top += viteza_de_background;
                    if (stele_de_fundal[i].Top >= this.Height)
                    {
                        stele_de_fundal[i].Top = -stele_de_fundal[i].Height;
                    }
                }

                for (int i = stele_de_fundal.Length / 2; i < stele_de_fundal.Length / 3; i++)
                {
                    stele_de_fundal[i].Top += viteza_de_background - 1;
                    if (stele_de_fundal[i].Top >= this.Height)
                    {
                        stele_de_fundal[i].Top = -stele_de_fundal[i].Height;
                    }
                }

                for (int i = stele_de_fundal.Length / 3; i < stele_de_fundal.Length; i++)
                {
                    stele_de_fundal[i].Top += viteza_de_background - 2;
                    if (stele_de_fundal[i].Top >= this.Height)
                    {
                        stele_de_fundal[i].Top = -stele_de_fundal[i].Height;
                    }
                }
            }
        }

        private void Miscare_Stanga_Tick(object sender, EventArgs e)
        {
            if (Jucator.Left > 10)
            {
                Jucator.Left -= viteza_jucator;
                st = 1;
                dr = 0;
                Jucator.Image = Image.FromFile(@"asserts\jucator-stanga.gif");
            }
        }

        private void Miscare_Dreapta_Tick(object sender, EventArgs e)
        {
            if (Jucator.Left < 800)
            {
                Jucator.Left += viteza_jucator;
                st = 0;
                dr = 1;
                Jucator.Image = Image.FromFile(@"asserts\jucator-dreapta.gif");
            }
        }

        private void Miscare_Sus_Tick(object sender, EventArgs e)
         {
             if (Jucator.Top > 10)
             {
                 Jucator.Top -= viteza_jucator;
             }
         }

        private void Miscare_Jos_Tick(object sender, EventArgs e)
        {
            if (Jucator.Top < 400)
            {
                Jucator.Top += viteza_jucator;
            }
        }

        private void Joc_KeyDown(object sender, KeyEventArgs e)
        {
            if (miscarejucatorstop == 1)
            {
                if (e.KeyCode == Keys.Right)
                {
                    Miscare_Dreapta.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    Miscare_Stanga.Start();
                }
                /*if (e.KeyCode == Keys.Down)
                {
                    Miscare_Jos.Start();
                }*/
                /*if (e.KeyCode == Keys.Up)
                {
                    Miscare_Sus.Start();
                }*/
            }

            if (e.KeyCode == Keys.Space && muzicafundal.playState == WMPPlayState.wmppsPlaying)
            {
                glontok = 1;
                if (sunetmuzicaglont == 0)
                {
                    muzicamunitie.controls.play();
                    sunetmuzicaglont = 1;
                }
            }

            if (e.KeyCode == Keys.M && sunet == 0 && muzicafundal.playState == WMPPlayState.wmppsPlaying)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                muzicafundal.settings.volume = 4;
                sunet = 1;
            }
            else
            if (e.KeyCode == Keys.M && sunet == 1 && muzicafundal.playState == WMPPlayState.wmppsPlaying)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                muzicafundal.settings.volume = 2;
                sunet = 2;
            }
            else
            if (e.KeyCode == Keys.M && sunet == 2 && muzicafundal.playState == WMPPlayState.wmppsPlaying)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                muzicafundal.settings.volume = 0;
                sunet = 3;
            }
            else
            if (e.KeyCode == Keys.M && sunet == 3 && muzicafundal.playState == WMPPlayState.wmppsPlaying)
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                muzicafundal.settings.volume = 6;
                sunet = 0;
            }
        }

        private void Joc_KeyUp(object sender, KeyEventArgs e)
        {
            Miscare_Dreapta.Stop();
            Miscare_Stanga.Stop();
            /*Miscare_Jos.Stop();
            Miscare_Sus.Stop();*/
            if (e.KeyCode == Keys.Escape && pauza % 2 == 0 && aipierdut == 0 )
            {
                groupBox1.Visible = true;
                button1.Visible = true;
                pauza++;
                miscarejucatorstop = 0;
                Miscare_inamici.Stop();
                Miscare_background.Stop();
                Miscare_glont_inamici.Stop();
            }
            else
            if (e.KeyCode == Keys.Escape && pauza % 2 != 0 && aipierdut == 0 )
            {
                groupBox1.Visible = false;
                button1.Visible = false;
                pauza++;
                miscarejucatorstop = 1;
                Miscare_inamici.Start();
                Miscare_background.Start();
                Miscare_glont_inamici.Start();
            }
        }

        private void Miscare_glont_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < gloante.Length; i++)
            {
                Coliziune();
                if (gloante[i].Top > 0 && glontok == 1)
                {
                    gloante[i].Visible = true;
                    gloante[i].Top -= viteza_glont;
                }
                else
                {
                    gloante[i].Visible = false;
                    if (dr == 1)
                    {
                        gloante[i].Location = new Point(Jucator.Location.X + 46, Jucator.Location.Y + 20);
                    }
                    if (st == 1)
                    {
                        gloante[i].Location = new Point(Jucator.Location.X + 1, Jucator.Location.Y + 20);
                    }
                    gloante[i].BringToFront();
                    glontok = 0;
                    sunetmuzicaglont = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idut != null)
            {
                puncte_initiale = (int)utilizatoriTableAdapter1.ScalarQueryGasireScorInitial(int.Parse(idut));
                if (scor > puncte_initiale)
                {
                    utilizatoriTableAdapter1.UpdateQueryScor(scor, int.Parse(idut));
                }
            }
            if (idad != null)
            {
                puncte_initiale = (int)utilizatoriTableAdapter1.ScalarQueryGasireScorInitial(int.Parse(idad));
                if (scor > puncte_initiale)
                {
                    utilizatoriTableAdapter1.UpdateQueryScor(scor, int.Parse(idad));
                }
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(@"asserts//buton-iesire-joc.png");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(@"asserts//buton-iesire-joc.png");
        }

        private void Miscare_inamici_Tick(object sender, EventArgs e)
        {
            Miscare_inamic(inamici, viteza_inamic);
        }

        private void Miscare_inamic(PictureBox[] zona, int viteza)
        {
            for(int i=0; i<zona.Length; i++)
            {
                zona[i].Visible = true;
                zona[i].Top += viteza;

                if(zona[i].Top > this.Height)
                {
                    zona[i].Location = new Point((i + 1) * 92, -200);
                    zona[i].BackColor = Color.Transparent;
                }
            }
        }

        private void Coliziune()
        {
            for(int i = 0; i < inamici.Length; i++)
            {
                if (gloante[0].Bounds.IntersectsWith(inamici[i].Bounds))
                {
                    gloante[0].Visible = false;

                    muzicaexplozie.controls.play();
                    scor++;
                    scorelbl.Text = scor.ToString();

                    levelbl.Text = "0" + level.ToString();

                    if (scor % 25 == 0)
                    {
                        level++;
                        levelbl.Text = "0" + level.ToString();

                        if (viteza_inamic <= 8 && viteza_glont_inamici <= 8 && hard >= 0)
                        {
                            hard--;
                            viteza_inamic++;
                            viteza_glont_inamici++;
                        }

                        if (level == 8)
                        {
                            GameWon("");
                        }
                    }

                    inamici[i].Location = new Point((i + 1) * 92, -100);
                }
                if (Jucator.Bounds.IntersectsWith(inamici[i].Bounds))
                {
                    inimi++;
                    muzicainima.controls.play();
                    inamici[i].Location = new Point((i + 1) * 92, -100);
                    muzicaexplozie.settings.volume = 5;
                    GameOver("");
                }
            }
        }

        private void GameWon(String str)
        {
            muzicafundal.controls.stop();
            StopTimers();
            aipierdut = 1;
            groupBox2.Text = "GAME WON";
            groupBox2.Visible = true;
            button4.Visible = true;
            Jucator.Visible = false;
        }

        private void GameOver(String str)
        {
            Viata();
            if (inimi == 3)
            {
                muzicafundal.controls.stop();
                StopTimers();
                aipierdut = 1;
                groupBox2.Visible = true;
                button4.Visible = true;
                Jucator.Visible = false;
            }
        }

        private void StopTimers()
        {
            muzicaaipierdut = new WindowsMediaPlayer();
            muzicaaipierdut.URL = "songs\\sunetaipierdut";
            muzicaaipierdut.settings.volume = 1;
            muzicaaipierdut.controls.play();
            Miscare_background.Stop();
            Miscare_inamici.Stop();
            Miscare_glont.Stop();
            Miscare_glont_inamici.Stop();
        }

        private void StartTimers()
        {
            Miscare_background.Start();
            Miscare_inamici.Start();
            Miscare_glont.Start();
            Miscare_glont_inamici.Start();
        }
        private void Viata()
        {
            if (inimi == 1)
            {
                pictureBox3.Visible = false;
            }
            if (inimi == 2)
            {
                pictureBox2.Visible = false;
            }
            if (inimi == 3)
            {
                pictureBox1.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idut != null)
            {
                puncte_initiale = (int)utilizatoriTableAdapter1.ScalarQueryGasireScorInitial(int.Parse(idut));
                if (scor > puncte_initiale)
                {
                    utilizatoriTableAdapter1.UpdateQueryScor(scor, int.Parse(idut));
                }
            }
            if (idad != null)
            {
                puncte_initiale = (int)utilizatoriTableAdapter1.ScalarQueryGasireScorInitial(int.Parse(idad));
                if (scor > puncte_initiale)
                {
                    utilizatoriTableAdapter1.UpdateQueryScor(scor, int.Parse(idad));
                }
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
            this.Close();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Image.FromFile(@"asserts//buton-iesire-joc.png");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackgroundImage = Image.FromFile(@"asserts//buton-iesire-joc.png");
        }

        private void Miscare_glont_inamici_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (gloante_inamici.Length - hard); i++)
            {
                if (gloante_inamici[i].Top < this.Height)
                {
                    gloante_inamici[i].Visible = true;
                    gloante_inamici[i].Top += viteza_glont_inamici;
                    Coliziune_cu_gloantele();
                }
                else
                {
                    gloante_inamici[i].Visible = false;
                    int x = rnd.Next(0, 8);
                    gloante_inamici[i].Location = new Point(inamici[x].Location.X + 10, inamici[x].Location.Y + 30);
                }
            }
        }

        private void Coliziune_cu_gloantele()
        {
            for (int i = 0; i < gloante_inamici.Length; i++)
            {
                if (gloante_inamici[i].Bounds.IntersectsWith(Jucator.Bounds))
                {
                    inimi++;
                    muzicainima.controls.play();
                    int x = rnd.Next(0, 8);
                    gloante_inamici[i].Location = new Point(inamici[x].Location.X + 10, inamici[x].Location.Y + 30);
                    muzicaexplozie.settings.volume = 5;
                    gloante_inamici[i].Visible = false;
                    GameOver("");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Location = new Point(100, 50);
            InitializeComponent();
            Joc_Load(e, e);
        }
    }
}