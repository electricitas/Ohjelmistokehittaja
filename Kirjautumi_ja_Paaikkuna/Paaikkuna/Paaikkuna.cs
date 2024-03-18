using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Paaikkuna
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        private void Paaikkuna_FormClosing(object sender, FormClosingEventArgs e)
        {   
            //Raksia painamalla sulkee ikkunat
            Application.Exit();
        }

        private void hallisteAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //Avaa asiakkaidenhallinta ikkunan
            AsiakaidenHallinta ahlomake = new AsiakaidenHallinta();
            ahlomake.ShowDialog(); 
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Avaa varaustenhallinta ikkunan
            VaraustenHallinta vhlomake = new VaraustenHallinta(); 
            vhlomake.ShowDialog();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Avaa huoneidenhallinta ikkunan
            HuoneidenHallinta hhlomake = new HuoneidenHallinta(); 
            hhlomake.ShowDialog();
        }
    }
}
