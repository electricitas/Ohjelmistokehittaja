namespace T12
{

    public partial class VastauksiaForm : Form
    {

        string[] oikeatVastaukset = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[]  vastaukset = new string[11];
        int laskuri = 0;
        int oikein = 0;

        public VastauksiaForm()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void Vastauksia_Load(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 1; j <= 10; j++)
                {
                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
