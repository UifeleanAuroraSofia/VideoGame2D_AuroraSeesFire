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
    public partial class Secventa : Form
    {
        public Secventa()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public bool ok = true;

        private void Secventa_Load(object sender, EventArgs e)
        {

        }

        private void Inchidere_Tick(object sender, EventArgs e)
        {
            Inchidere.Stop();
            this.Hide();
            MeniuJoc f = new MeniuJoc();
            f.Show();
        }
    }
}
