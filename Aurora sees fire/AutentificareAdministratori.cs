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
    public partial class AutentificareAdmin : Form
    {
        public AutentificareAdmin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public string ida;

        private void confirmare_Click(object sender, EventArgs e)
        {
            string username = "", parola = "";
            bool admin = false;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                username = textBox1.Text; //preiau datele introduse
                parola = textBox2.Text;
                admin = checkBox1.Checked;
                //aplic interogarea pentru cautarea in tabela
                if (utilizatoriTableAdapter.ScalarQueryLogare(username, parola) != 0)
                {
                    if (utilizatoriTableAdapter.ScalarQueryAdmin(username, parola, admin) == 0 && checkBox1.Checked == false)
                    {
                        MessageBox.Show("Esti administrator, dar trebuie sa bifezi casuta!!");
                    }
                    else
                    if (utilizatoriTableAdapter.ScalarQueryAdmin(username, parola, admin) == 0 && checkBox1.Checked == true)
                    {
                        MessageBox.Show("Nu esti administrator!");
                    }
                    else
                    if (utilizatoriTableAdapter.ScalarQueryAdmin(username, parola, admin) == 1 && checkBox1.Checked == false)
                    {
                        MessageBox.Show("Nu esti administrator!");
                    }
                    else
                    if (checkBox1.Checked == true)
                    {
                        MessageBox.Show("Bine ai venit, admin " + textBox1.Text + "!");
                        ida = utilizatoriTableAdapter.ScalarQueryGasireId(username, parola).ToString();
                        this.Close(); //inchid forma de autentificare;
                    }
                }
                else
                    MessageBox.Show("Date de autentificare gresite!");
            }
            else
                MessageBox.Show("Introduceti username si parola!");
        }

        private void AutentificareAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}