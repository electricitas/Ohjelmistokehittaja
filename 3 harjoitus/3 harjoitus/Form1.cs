namespace _3_harjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float luku1, luku2, vastaus;
            string merkki;
            luku1 = float.Parse(LukuYksiTB.Text);
            luku2 = float.Parse(LukuKaksiTB.Text);
            merkki = LaskutoimitusCB.Text;
           
            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                    case "-":
                    vastaus = luku1 - luku2;
                    break;
                    case "*":
                    vastaus = luku1 * luku2;
                    break;
                    case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastaus = 0;
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }
    }
}
