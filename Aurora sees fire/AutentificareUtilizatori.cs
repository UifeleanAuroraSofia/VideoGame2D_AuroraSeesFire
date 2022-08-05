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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
            CenterToScreen();

        }

        public string idu;

        private void nu_am_cont_Click(object sender, EventArgs e)
        {
            Inregistrare f = new Inregistrare();
            f.ShowDialog();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {

        }

        private void confirmare_logare_Click(object sender, EventArgs e)
        {
            string username = "", parola = "";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                username = textBox1.Text;
                parola = textBox2.Text;
                if (utilizatoriTableAdapter.ScalarQueryLogare(username, parola) != 0)
                {
                    MessageBox.Show("Bine ai venit, " + textBox1.Text + "!");
                    idu = utilizatoriTableAdapter.ScalarQueryGasireId(username, parola).ToString();
                    this.Close();
                }
                else
                    MessageBox.Show("Date de autentificare gresite");
            }
            else
                MessageBox.Show("Introduceti username si parola");
        }
    }
}
