using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli_asiakashallinta
{
    public partial class ahForm : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public ahForm()
        {
            InitializeComponent();
        }

        private void ahForm_Load(object sender, EventArgs e)
        {
            AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            enimiTB.Text = "";
            snimiTB.Text = "";
            lahioTB.Text = "";
            pnroTB.Text = "";
            ptpTB.Text = "";
            kayttajaTB.Text = "";
            salasTB.Text = "";
        }

        private void lisaauusiBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String osoite = lahioTB.Text;
            String pnro = pnroTB.Text;
            String ppaikka = ptpTB.Text;
            String kayttaja = kayttajaTB.Text;
            String ssana = salasTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, osoite, postinumero ja postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, pnro, ppaikka, kayttaja, ssana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String osoite = lahioTB.Text;
            String pnro = pnroTB.Text;
            String ppaikka = ptpTB.Text;
            String kayttaja = kayttajaTB.Text;
            String ssana = salasTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, osoite, postinumero ja postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, pnro, ppaikka, kayttaja);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas päivitetty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AsiakkaatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            enimiTB.Text = AsiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            snimiTB.Text = AsiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            lahioTB.Text = AsiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            pnroTB.Text = AsiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            ptpTB.Text = AsiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            kayttajaTB.Text = AsiakkaatDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = kayttajaTB.Text;
            if(asiakas.poistaAsiakas(ktunnus))
            {
                AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("asiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }
    }
}
