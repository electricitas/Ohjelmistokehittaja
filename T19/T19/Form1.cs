namespace T19
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 v�lituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka p�iv� maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa l�mpimien \n";
            meistaLB.Text += "juomien lis�ksi virvokkeita sek� pient� purtavaa ja makeisia\n";
            meistaLB.Text += "Tervetuloa tutustumaan!\n";
            meistaLB.Font = new Font("Arial", 12);
        }
    }
}