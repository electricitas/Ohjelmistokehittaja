using System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotelli_asiakashallinta
{
    internal class Yhdista
    {
        public string yhteyslause()
        {
            return "DataSource=localhost; port=3306;username=root;password=;database=hotel_management";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=hotel_management");
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}