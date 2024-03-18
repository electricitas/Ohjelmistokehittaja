using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellivarausjarjestelma
{
    public partial class Form2 : Form
    {
        HUONE huone = new HUONE();
        ASIAKAS asiakas = new ASIAKAS();
        VARAUS varaus = new VARAUS();
        public Form2()
        {
            InitializeComponent();
        }


        private void UusiVarausPainike_Click(object sender, EventArgs e)
        {
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTB.Value);

            if (varaus.lisaaVaraus(huonenro, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (huone.vaihdaHuoneenVapaus("Kyllä", huonenro))
                {
                    MessageBox.Show("Huoneen varaustilanne vaihdettu onnistuneesti");
                }
                else
                {
                    MessageBox.Show("Huoneen varaustilannetta ei pystytty vaihtamaan");
                }
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HuonetyyppiCB.DataSource = huone.huonetyyppilista();
            HuonetyyppiCB.DisplayMember = "Huonetyyppi";
            HuonetyyppiCB.ValueMember = "kategoriaId";

            AsiakasCB.DataSource = asiakas.asiakaslista();
            AsiakasCB.DisplayMember = "Kokonimi";
            AsiakasCB.ValueMember = "AsiakasId";
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void HuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int huonetype = HuonetyyppiCB.SelectedIndex + 1;

            HuoneNroCB.DataSource = huone.tyypillisetHuoneet(huonetype);
            HuoneNroCB.DisplayMember = "HuoneenNro";
            HuoneNroCB.ValueMember = "HuoneenNro";
        }

        private void MuokkaaVaraustaPainike_Click(object sender, EventArgs e)
        {
            int huone = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(SisaanDTP.Value);
            DateTime ulos = Convert.ToDateTime(UlosDTB.Value);
            try
            {
                int vara = Convert.ToInt32(VarausNroTB.Text);

                if (varaus.muokkaaVarausta(huone, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void VarauksetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            VarausNroTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            AsiakasCB.SelectedValue = VarauksetDG.CurrentRow.Cells[1].Value.ToString();
            HuoneNroCB.SelectedValue = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            SisaanDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[3].Value);
            UlosDTB.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[4].Value);

        }

        private void PoistaVarausPainike_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = VarausNroTB.Text;
                int huonenro = HuoneNroCB.SelectedIndex;
                if (varaus.poistaVaraus(varausnro))
                {
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Varausta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TyhjennaVarausPainike.PerformClick();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
    }
}
