using System.Data;

namespace TT18
{
    public partial class AvainhenkilotForm : Form
    {
        DataTable oppilaitos = new DataTable();
        DataTable vastuuhHenkilot = new DataTable();
        DataTable yhteys = new DataTable();
        public AvainhenkilotForm()
        {
            InitializeComponent();
        }

        private void AvainhenkilotForm_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            oppilaitosCB.DataSource = oppilaitos;
            oppilaitosCB.DisplayMember = "ONimi";
            taytaVastuuHenkilotTaulukko();
        }

        private void oppilaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OID"].ToString();
            osoiteLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OOsoite"].ToString();
            postinumeroLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OPostinumero"].ToString();
            postitoimipaikkaLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndexIndex]["OPostitoimipaikka"].ToString();
            puhelinLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OPuhelin"].ToString();

            yhteys = vastuuhHenkilot.Select("OID =" + viite).CopyToDataTable();
            vastuuhloCB.DataSource = yhteys;
            vastuuhloCB.DisplayMember = "VNimi";
        }

     

        private void vastuuhloCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            titteliLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VTitteli"].ToString();
            osastoLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VOsasto"].ToString();
            emailLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VSahkoposti"].ToString();
            puhelinLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VPuhelin"].ToString();
        }

        private void taytaOppilaitosTaulukko()
        {
            oppilaitos.Columns.Add("OID", typeof(int));
            oppilaitos.Columns.Add("ONimi");
            oppilaitos.Columns.Add("OKatuosoite");
            oppilaitos.Columns.Add("OPostinumero");
            oppilaitos.Columns.Add("OPostitoimipaikka");
            oppilaitos.Columns.Add("OPuhelin");
        }
    }
}