using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    internal class HUONE
    {
        Yhdista yhteys = new Yhdista();

        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonekategoria", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public bool lisaaHuone(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO huoneet" +
                "(Huoneennro, Huonetyyppi, Puhelin, Vapaa) " +
                "VALUES (@hno, @hty, @puh, @vap) ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.Int32).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.Int32).Value = vapaa;

            yhteys.avaaYhteys();
            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }
            }

        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaaHuonetta(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE 'huoneet' SET 'Huonetyyppi'= @hty," +
                "'Puhelin'= @puh, 'Vapaa'= @vap" +
                " WHERE Huoneennro = @hno";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.Int32).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.Int32).Value = vapaa;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1) 
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool poistaHuone(String hnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM huoneet WHERE Huoneennro = @hno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

        komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery()==1) 
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        }
    }

