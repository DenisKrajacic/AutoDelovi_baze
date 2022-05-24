using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoDelovi
{
    public partial class Pregled : Form
    {
        DataTable tabela;
        SqlDataAdapter Adapter;

        public Pregled()
        {
            InitializeComponent();
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("Select Artikal.id, Artikal.KataloskiBroj, Artikal.OEBroj, Artikal.Naziv, JedinicaMere.naziv AS 'Jedinica mere', Artikal.Kolicina, Proizvodjac.naziv AS 'Proizvodjac', Artikal.Cena FROM Artikal INNER JOIN JedinicaMere ON Artikal.JedinicaMere_id = JedinicaMere.id  INNER JOIN Proizvodjac ON Artikal.Proizvodjac_id = Proizvodjac.id ", Konekcija.Connect());
            tabela = new DataTable();
            Adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
            dataGridView1.Columns["KataloskiBroj"].ReadOnly = true;
            dataGridView1.Columns["OEBroj"].ReadOnly = true;
            dataGridView1.Columns["Naziv"].ReadOnly = true;
            dataGridView1.Columns["Kolicina"].ReadOnly = true;
            dataGridView1.Columns["Cena"].ReadOnly = true;

            cb_kateg.Enabled = false;
            txt_katbr.Enabled = false;
            b_search.Enabled = false;

            DataTable dt_katego;
            Adapter = new SqlDataAdapter("SELECT id, naziv as naziv FROM Kategorija", Konekcija.Connect());
            dt_katego = new DataTable();
            Adapter.Fill(dt_katego);

            cb_kateg.DataSource = dt_katego;
            cb_kateg.ValueMember = "id";
            cb_kateg.DisplayMember = "naziv";
        }

        private void Rb_katbr_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_katbr.Checked)
            {
                txt_katbr.Enabled = true;
                b_search.Enabled = true;
                cb_kateg.Enabled = false;
            }
        }

        private void Rb_kateg_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_kateg.Checked)
            {
                cb_kateg.Enabled = true;
                b_search.Enabled = true;
                txt_katbr.Enabled = false;
            }
        }

        private void B_search_Click(object sender, EventArgs e)
        {
            if (rb_kateg.Checked)
            {
                Adapter = new SqlDataAdapter("Select Artikal.id, Artikal.KataloskiBroj, Artikal.OEBroj, Artikal.Naziv, JedinicaMere.naziv AS 'Jedinica mere', Artikal.Kolicina, Proizvodjac.naziv AS 'Proizvodjac', Artikal.Cena FROM Artikal INNER JOIN JedinicaMere ON Artikal.JedinicaMere_id = JedinicaMere.id  INNER JOIN Proizvodjac ON Artikal.Proizvodjac_id = Proizvodjac.id  WHERE Artikal.Kategorija_id = '" + cb_kateg.SelectedValue + "'", Konekcija.Connect());
                tabela = new DataTable();
                Adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataGridView1.Columns["id"].ReadOnly = true;
                dataGridView1.Columns["KataloskiBroj"].ReadOnly = true;
                dataGridView1.Columns["OEBroj"].ReadOnly = true;
                dataGridView1.Columns["Naziv"].ReadOnly = true;
                dataGridView1.Columns["Kolicina"].ReadOnly = true;
                dataGridView1.Columns["Cena"].ReadOnly = true;
            }

            if (rb_katbr.Checked)
            {
                Adapter = new SqlDataAdapter("Select Artikal.id, Artikal.KataloskiBroj, Artikal.OEBroj, Artikal.Naziv, JedinicaMere.naziv AS 'Jedinica mere', Artikal.Kolicina, Proizvodjac.naziv AS 'Proizvodjac', Artikal.Cena FROM Artikal INNER JOIN JedinicaMere ON Artikal.JedinicaMere_id = JedinicaMere.id  INNER JOIN Proizvodjac ON Artikal.Proizvodjac_id = Proizvodjac.id WHERE Artikal.KataloskiBroj = '" + txt_katbr.Text + "'", Konekcija.Connect());
                tabela = new DataTable();
                Adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataGridView1.Columns["id"].ReadOnly = true;
                dataGridView1.Columns["KataloskiBroj"].ReadOnly = true;
                dataGridView1.Columns["OEBroj"].ReadOnly = true;
                dataGridView1.Columns["Naziv"].ReadOnly = true;
                dataGridView1.Columns["Kolicina"].ReadOnly = true;
                dataGridView1.Columns["Cena"].ReadOnly = true;
            }
        }
    }
}
