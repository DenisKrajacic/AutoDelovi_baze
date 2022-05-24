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
using System.Globalization;

namespace AutoDelovi
{

    public partial class Glavna : Form
    {
        DataTable delovi;
        int broj_sloga = 0;

        public Glavna()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Artikal", veza);
            delovi = new DataTable();
            adapter.Fill(delovi);
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            Load_Data();
            ComboFill();
        }

        private void ComboFill()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dt_jedmer, dt_katego, dt_proizv;

            adapter = new SqlDataAdapter("SELECT id, naziv as naziv FROM JedinicaMere", veza);
            dt_jedmer = new DataTable();
            adapter.Fill(dt_jedmer);

            adapter = new SqlDataAdapter("SELECT id, naziv as naziv FROM Kategorija", veza);
            dt_katego = new DataTable();
            adapter.Fill(dt_katego);

            adapter = new SqlDataAdapter("SELECT id, naziv as naziv FROM Proizvodjac", veza);
            dt_proizv = new DataTable();
            adapter.Fill(dt_proizv);
            
            cmb_jedmer.DataSource = dt_jedmer;
            cmb_jedmer.ValueMember = "id";
            cmb_jedmer.DisplayMember = "naziv";

            cmb_katego.DataSource = dt_katego;
            cmb_katego.ValueMember = "id";
            cmb_katego.DisplayMember = "naziv";

            cmb_proizv.DataSource = dt_proizv;
            cmb_proizv.ValueMember = "id";
            cmb_proizv.DisplayMember = "naziv";

            txt_id.Text = delovi.Rows[broj_sloga]["id"].ToString();
            txt_katbr.Text = delovi.Rows[broj_sloga]["KataloskiBroj"].ToString();
            txt_oebr.Text = delovi.Rows[broj_sloga]["OEBroj"].ToString();
            txt_naziv.Text = delovi.Rows[broj_sloga]["Naziv"].ToString();
            txt_kol.Text = delovi.Rows[broj_sloga]["Kolicina"].ToString();
            txt_bruto.Text = delovi.Rows[broj_sloga]["BrutoCena"].ToString();
            txt_rabat.Text = delovi.Rows[broj_sloga]["Rabat"].ToString();
            txt_pdv.Text = delovi.Rows[broj_sloga]["PDV"].ToString();
            txt_neto.Text = delovi.Rows[broj_sloga]["Neto"].ToString();
            txt_cena.Text = delovi.Rows[broj_sloga]["Cena"].ToString();

            if (delovi.Rows.Count == 0)
            {
                cmb_jedmer.SelectedValue = -1;
                cmb_katego.SelectedValue = -1;
                cmb_proizv.SelectedValue = -1;
            }
            else
            {
                cmb_jedmer.SelectedValue = delovi.Rows[broj_sloga]["JedinicaMere_id"];
                cmb_katego.SelectedValue = delovi.Rows[broj_sloga]["Kategorija_id"];
                cmb_proizv.SelectedValue = delovi.Rows[broj_sloga]["Proizvodjac_id"];
            }

            if (broj_sloga == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }

            if (broj_sloga == delovi.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            ComboFill();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            ComboFill();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            ComboFill();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = delovi.Rows.Count - 1;
            ComboFill();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM Artikal WHERE id = " + txt_id.Text;

            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);

            bool brisano = false;

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                brisano = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            if (brisano)
            {
                Load_Data();
                if (broj_sloga > 0) broj_sloga--;
                ComboFill();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("INSERT INTO Artikal (KataloskiBroj, OEBroj, Naziv, JedinicaMere_id, Kolicina, Kategorija_id, Proizvodjac_id, BrutoCena, Rabat, PDV) VALUES('");
            naredba.Append(txt_katbr.Text + "', '");
            naredba.Append(txt_oebr.Text + "', '");
            naredba.Append(txt_naziv.Text + "', '");
            naredba.Append(cmb_jedmer.SelectedValue + "', '");
            naredba.Append(Convert.ToInt32(txt_kol.Text) + "', '");
            naredba.Append(cmb_katego.SelectedValue + "', '");
            naredba.Append(cmb_proizv.SelectedValue + "', '");
            naredba.Append(txt_bruto.Text + "', '");
            naredba.Append(txt_rabat.Text + "', '");
            naredba.Append(txt_pdv.Text + "')");

            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            Load_Data();
            broj_sloga = delovi.Rows.Count - 1;
            ComboFill();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE Artikal SET ");
            naredba.Append("KataloskiBroj = '" + txt_katbr.Text + "', ");
            naredba.Append("OEBroj = '" + txt_oebr.Text + "', ");
            naredba.Append("Naziv = '" + txt_naziv.Text + "', ");
            naredba.Append("JedinicaMere_id = '" + cmb_jedmer.SelectedValue + "', ");
            naredba.Append("Kolicina = '" + Convert.ToInt32(txt_kol.Text) + "', ");
            naredba.Append("Kategorija_id = '" + cmb_katego.SelectedValue + "', ");
            naredba.Append("Proizvodjac_id = '" + cmb_proizv.SelectedValue + "', ");
            naredba.Append("BrutoCena = '" + txt_bruto.Text + "', ");
            naredba.Append("Rabat = '" + txt_rabat.Text + "', ");
            naredba.Append("PDV = '" + txt_pdv.Text + "' ");
            naredba.Append("WHERE id = " + Convert.ToInt32(txt_id.Text)); 

            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            Load_Data();
            ComboFill();
        }

        private void b_pregled_Click(object sender, EventArgs e)
        {
            Pregled frm_Pregled = new Pregled();
            frm_Pregled.Show();
        }
    }

    
}
