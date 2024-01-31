using System.Drawing.Text;
using System.Windows.Forms;

namespace TT16
{
    public partial class CountDownForm : Form
    {
        private int kokonaisaika;
        public CountDownForm()
        {
           
            InitializeComponent();
        }

        private void CountDownForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60;  i++) 
            {
                MinuutitCB.Items.Add(i.ToString());
                SekunnitCB.Items.Add(i.ToString());
            }
            MinuutitCB.SelectedIndex = 1;
            SekunnitCB.SelectedIndex = 15;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int Minuutit = int.Parse(MinuutitCB.SelectedItem.ToString());
            int Sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString());
            kokonaisaika = (Minuutit * 60) + Sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0) 
            {
                kokonaisaika--;
                int Minuutit = kokonaisaika / 60;
                int Sekuntit = kokonaisaika - (Minuutit * 60);
                AikaLB.Text = Minuutit + ":" + Sekuntit;
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
