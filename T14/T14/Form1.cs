using System.IO;
namespace T14
{
    public partial class KirjaForm : Form
    {
        public KirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\panu.eklund\\source\\repos\\Ohjelmistokehittaja\\T14\\paivakirja.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\panu.eklund\\source\\repos\\Ohjelmistokehittaja\\T14\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}