namespace tt6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Panu" && SalasanaTB.Text == "Ja@kk0Ku1ta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "K�ytt�j�tunnus tai salasana virheellinen!";
                VirheviestiLB.Visible= true;
            }


        }
    }
}