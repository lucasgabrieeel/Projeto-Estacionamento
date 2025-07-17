using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace estacionamento_2
{
    class carro
    {
        public string Carro { get; set; }

        public string placa { get; set; }

        public string cor { get; set; }

        public static DataTable GetCarros (bool carro) 
        {
            var dt = new DataTable();

            var sql = "SELECT carro, placa, cor FROM carros";

            try
            {
                using(var cn = new MySqlConnection(conn.strConn))
                {
                    cn.Open();
                    using(var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
