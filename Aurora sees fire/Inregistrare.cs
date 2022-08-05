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
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void inchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.database1DataSet.Utilizatori);

        }

        private void cont_creat_Click(object sender, EventArgs e)
        {
            string nume = "", prenume = "", username = "", parola = "", varsta = "";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                nume = textBox1.Text;
                prenume = textBox2.Text;
                username = textBox3.Text;
                varsta = textBox4.Text;
                parola = textBox5.Text;
                try
                {
                    utilizatoriTableAdapter.InsertQueryUtilizatori(nume, prenume, username, varsta, parola);
                    MessageBox.Show("Contul a fost creat cu succes!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("A aparut o eroare la adaugarea contului!");
                }
            }
            else
                MessageBox.Show("Toate campurile sunt obligatorii!");
        }
    }
}
