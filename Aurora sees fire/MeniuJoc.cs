using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora_sees_fire
{
    public partial class MeniuJoc : Form
    {
        int ok = 0, login = 0;
        int admin = 0;
        public int punctaj;
        public int puncte_initiale;
        public string idutilizator;
        public string idadministrator;
        public MeniuJoc()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                login = 1;
                Joc.Joc f = new Joc.Joc(punctaj, idutilizator, idadministrator);
                this.Location = new Point(100, 50);
                f.ShowDialog();
                punctaj = f.scor;
                //this.Hide();
            }
            else
                MessageBox.Show("Mai intai trebuie sa te autentifici.");
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructiuni_Click(object sender, EventArgs e)
        {
            Instructiuni f = new Instructiuni();
            this.Location = new Point(100, 50);
            f.Show();
        }

        private void despre_Click(object sender, EventArgs e)
        {
            Despre f = new Despre();
            this.Location = new Point(100, 50);
            f.Show();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            
        }

        private void panou_control_utilizatori_Click(object sender, EventArgs e)
        {
            PanouControl f = new PanouControl(punctaj, idutilizator, idadministrator);
            this.Location = new Point(100, 50);
            f.Show();
        }

        private void autentificare_administratori_Click(object sender, EventArgs e)
        {
            if (login == 0)
            {
                ok = 1;
                AutentificareAdmin f2 = new AutentificareAdmin();
                f2.ShowDialog();
                idadministrator = f2.ida;
                login = 1;
                admin = 1;
            }
            else
                MessageBox.Show("Esti deja autentificat. Nu te mai poti autentifica.");
            if (admin == 1)
            {
                panou_control_utilizatori.Visible = true;
            }
        }

        private void autentificare_utilizatori_Click(object sender, EventArgs e)
        {
            if (login == 0)
            {
                ok = 1;
                Autentificare f2 = new Autentificare();
                f2.ShowDialog();
                idutilizator = f2.idu;
                login = 1;
            }
            else
                MessageBox.Show("Esti deja autentificat. Nu te mai poti autentifica.");
        }
    }
}
