using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TT20
{

    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            PuhTB.Text = "";
            EmailTB.Text = "";
            ONroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                     MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                     MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                 MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu. ja sukunimi, puhelin, sähköposti, ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                     MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                     MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }


        private void TietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            EmailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            ONroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                 MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

    }
}



