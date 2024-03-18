using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaenrique
{
    public partial class frm_items : Form
    {

        const double price_burger = 13;
        const double price_juusto = 15;
        const double price_hotdog = 10;
        const double price_opera = 18;
        const double price_julia = 16;
        const double price_cola = 3;
        const double price_lahde = 2;
        const double price_sprite = 3;
        const double price_vichy = 2;
        const double price_energia = 5;
        public frm_items()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Haluatko varmasti poistua järjestelmästä",
                "Toimitusjärjestelmä", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_items_Load(object sender, EventArgs e)
        {
            cmb_payment.Items.Add(" ");
            cmb_payment.Items.Add(" Käteinen");
            cmb_payment.Items.Add(" Käteinen toimituksen yhteydessä");
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void chk_burger_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_burger.Checked == true)
            {
                txt_burger.Enabled = true;
                txt_burger.Text = "";
                txt_burger.Focus();

            }
            else
            {
                txt_burger.Enabled = false;
                txt_burger.Text = "0";
            }
        }

        private void chk_juusto_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_juusto.Checked == true)
            {
                txt_juusto.Enabled = true;
                txt_juusto.Text = "";
                txt_juusto.Focus();

            }
            else
            {
                txt_juusto.Enabled = false;
                txt_juusto.Text = "0";
            }
        }

        private void chk_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hotdog.Checked == true)
            {
                txt_hotdog.Enabled = true;
                txt_hotdog.Text = "";
                txt_hotdog.Focus();

            }
            else
            {
                txt_hotdog.Enabled = false;
                txt_hotdog.Text = "0";
            }
        }

        private void chk_opera_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_opera.Checked == true)
            {
                txt_opera.Enabled = true;
                txt_opera.Text = "";
                txt_opera.Focus();

            }
            else
            {
                txt_opera.Enabled = false;
                txt_opera.Text = "0";
            }
        }

        private void chk_julia_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_julia.Checked == true)
            {
                txt_julia.Enabled = true;
                txt_julia.Text = "";
                txt_julia.Focus();

            }
            else
            {
                txt_julia.Enabled = false;
                txt_julia.Text = "0";
            }
        }

        private void chk_cola_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cola.Checked == true)
            {
                txt_cola.Enabled = true;
                txt_cola.Text = "";
                txt_cola.Focus();

            }
            else
            {
                txt_cola.Enabled = false;
                txt_cola.Text = "0";
            }
        }

        private void chk_lahde_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lahde.Checked == true)
            {
                txt_lahde.Enabled = true;
                txt_lahde.Text = "";
                txt_lahde.Focus();

            }
            else
            {
                txt_lahde.Enabled = false;
                txt_lahde.Text = "0";
            }
        }

        private void chk_sprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sprite.Checked == true)
            {
                txt_sprite.Enabled = true;
                txt_sprite.Text = "";
                txt_sprite.Focus();

            }
            else
            {
                txt_sprite.Enabled = false;
                txt_sprite.Text = "0";
            }
        }

        private void chk_energia_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_energia.Checked == true)
            {
                txt_energia.Enabled = true;
                txt_energia.Text = "";
                txt_energia.Focus();

            }
            else
            {
                txt_energia.Enabled = false;
                txt_energia.Text = "0";
            }
        }

        private void chk_vichy_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_vichy.Checked == true)
            {
                txt_vichy.Enabled = true;
                txt_vichy.Text = "";
                txt_vichy.Focus();

            }
            else
            {
                txt_vichy.Enabled = false;
                txt_vichy.Text = "0";
            }
        }

        private void cmb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmb_payment.Text == "Käteinen")
            {
                txt_payment.Enabled = true;
                txt_payment.Text = "";
                txt_payment.Focus();
            }
            else if (cmb_payment.Text == "Käteinen toimituksen yhteydessä")
            {
                txt_name.Enabled = true;
                txt_address.Enabled = true;
                txt_number.Enabled = true;
                txt_name.Text = "";
                txt_number.Text = "";
                txt_address.Text = "";
                txt_name.Focus();
                txt_address.Focus();
                txt_number.Focus();
            }
            else
            {
                txt_payment.Enabled = false;
                txt_payment.Text = "0";
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {

            double[] itemcost = new double[10]; // Varmista, että arrayn koko vastaa tuotteiden määrää
            double.TryParse(txt_burger.Text, out itemcost[0]);
            double.TryParse(txt_juusto.Text, out itemcost[1]);
            double.TryParse(txt_hotdog.Text, out itemcost[2]);
            double.TryParse(txt_opera.Text, out itemcost[3]);
            double.TryParse(txt_julia.Text, out itemcost[4]);
            double.TryParse(txt_cola.Text, out itemcost[5]);
            double.TryParse(txt_lahde.Text, out itemcost[6]);
            double.TryParse(txt_energia.Text, out itemcost[7]);
            double.TryParse(txt_vichy.Text, out itemcost[8]);
            double.TryParse(txt_sprite.Text, out itemcost[9]);

            double total = itemcost[0] * price_burger + itemcost[1] * price_juusto + itemcost[2] * price_hotdog
                         + itemcost[3] * price_opera + itemcost[4] * price_julia + itemcost[5] * price_cola
                         + itemcost[6] * price_lahde + itemcost[7] * price_energia + itemcost[8] * price_vichy
                         + itemcost[9] * price_sprite;

            lbl_result.Text = total.ToString();

            double payment;
            if (double.TryParse(txt_payment.Text, out payment))
            {
                double change = payment - total;
                lbl_changeresult.Text = change.ToString(); // Näytä vaihtoraha
            }
            else
            {
                lbl_changeresult.Text = "Syötä kelvollinen maksumäärä"; // Näytä virheilmoitus, jos maksun määrä on virheellinen
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            RestTextBox();
            RestCheckBox();
        }

        private void RestTextBox()
        {
            txt_burger.Text = "";
            txt_juusto.Text = "";
            txt_hotdog.Text = "";
            txt_opera.Text = "";
            txt_julia.Text = "";
            txt_cola.Text = "";
            txt_lahde.Text = "";
            txt_sprite.Text = "";
            txt_vichy.Text = "";
            txt_energia.Text = "";
        }

        private void RestCheckBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    var ctrl = control; // Kopioidaan control-muuttuja lambda-lausekkeen sisään
                    if (ctrl is CheckBox)
                    {
                        (ctrl as CheckBox).Checked = false; // Aseta Checked-arvo pois päältä
                    }
                    else if (ctrl is TextBox)
                    {
                        (ctrl as TextBox).Text = "";
                    }
                }
            };
            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kiitos kun valitsit pizza Enriquen " + txt_name.Text + " Toimitamme tilauksenne osoitteeseen " + txt_address.Text + " Soitamme ennen toimitusta numeroon " + txt_number.Text);
        }
    }
}
