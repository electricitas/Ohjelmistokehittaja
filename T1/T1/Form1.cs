namespace T1
{
    public partial class T1FORM : Form
    {
        public T1FORM()
        {
            InitializeComponent();
        }
        int laskuri = 0;
        private void VaihdaBT_Click(object sender, EventArgs e)
        {
           
            if (OtsikkoLB.Text == "Otsikko")
            {
                OtsikkoLB.Text = "Heippa maailma";
            }
            else
            {
                OtsikkoLB.Text = "Otsikko";
            }
            laskuri++;
            LaskuriLB.Text = laskuri.ToString();
        }
    }
}