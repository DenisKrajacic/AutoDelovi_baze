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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Niste uneli potrebne podatke.");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM Osoba WHERE email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_name.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int brojac = tabela.Rows.Count;

                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), txt_pass.Text) == 0)
                        {
                            MessageBox.Show("Login uspesan. Dobro dosli.");

                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];

                            if (Program.user_uloga == 1)
                            {
                                Glavna frm_Glavna = new Glavna();
                                frm_Glavna.Show();
                            }
                            else
                            {
                                Pregled frm_Pregled = new Pregled();
                                frm_Pregled.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Pogresna lozinka. Pokusajte ponovo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uneti e-mail ne postoji. Pokusajte ponovo.");
                    }
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
