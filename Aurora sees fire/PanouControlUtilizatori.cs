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
    public partial class PanouControl : Form
    {
        int puncte;
        int puncte_initiale;
        string idu, ida;
        public PanouControl(int punctaj, string idutilizator, string idadministrator)
        {
            InitializeComponent();
            CenterToScreen();
            puncte = punctaj;
            idu = idutilizator;
            ida = idadministrator;
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void PanouControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
            // TODO: This line of code loads data into the 'database1DataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.database1DataSet.Utilizatori);
            if (idu != null)
            {
                puncte_initiale = (int)utilizatoriTableAdapter1.ScalarQueryGasireScorInitial(int.Parse(idu));
                if (puncte > puncte_initiale)
                {
                    utilizatoriTableAdapter1.UpdateQueryScor(puncte, int.Parse(idu));
                }
            }
            if (ida != null)
            {
                puncte_initiale = (int)utilizatoriTableAdapter1.ScalarQueryGasireScorInitial(int.Parse(ida));
                if (puncte > puncte_initiale)
                {
                    utilizatoriTableAdapter1.UpdateQueryScor(puncte, int.Parse(ida));
                }
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void schimbareFunctieUtilizatoriToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(22, 29, 47);
        }

        private void schimbareFunctieUtilizatoriToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(22, 29, 47);
        }

        private void utilizatoriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inOrdineAlfabeticaDupaNumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilizatoriTableAdapter1.FillByAlfabeticNume(database1DataSet1.Utilizatori);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void inOrdineAlfabeticaDupaUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilizatoriTableAdapter1.FillByAlfabeticUsername(database1DataSet1.Utilizatori);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void doarUtilizatoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilizatoriTableAdapter1.FillByDoarUtilizatorii(database1DataSet1.Utilizatori);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void doarAdminiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilizatoriTableAdapter1.FillByDoarAdministratorii(database1DataSet1.Utilizatori);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = "", prenume = "", username = "", parola = "", varsta = "";
            bool admin = false;
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                nume = textBox1.Text;
                prenume = textBox2.Text;
                username = textBox3.Text;
                varsta = textBox4.Text;
                parola = textBox5.Text;
                admin = checkBox1.Checked;
                utilizatoriTableAdapter1.InsertQueryAdaugaUtilizatori(nume, prenume, username, varsta, parola, admin);
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adaugareUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void schimbareParolaUtilizatoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
        }

        private void schimbareFunctieUtilizatoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void stergereUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dupaNumeSiPrenumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true; 
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void dupaUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nume = "", prenume = "";
            if(textBox6.Text != "" && textBox7.Text != "")
            {
                nume = textBox6.Text;
                prenume = textBox7.Text;
                utilizatoriTableAdapter1.DeleteQueryStergeUtilizatoriDupaNumePrenume(nume, prenume);
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = "";
            if (textBox8.Text != "")
            {
                username = textBox8.Text;
                utilizatoriTableAdapter1.DeleteQueryStergeUtilizatoriDupaUsername(username);
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = 0;
            string parola = "";
            if(textBox9.Text != "" && textBox11.Text != "")
            {
                id = int.Parse(textBox9.Text);
                parola = textBox11.Text;
                utilizatoriTableAdapter1.UpdateQuerySchimbareParola(parola, id);
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
        }

        private void dupaScorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilizatoriTableAdapter1.FillByDupaScor(database1DataSet1.Utilizatori);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool admin = false;
            if (textBox10.Text != "")
            {
                id = int.Parse(textBox10.Text);
                admin = checkBox2.Checked;
                utilizatoriTableAdapter1.UpdateQuerySchimbareFunctie(admin, id);
            }
            this.utilizatoriTableAdapter1.Fill(this.database1DataSet1.Utilizatori);
        }
    }
}
