using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace estacionamento_2
{
    class conxao
    {
        public MySqlConnection login = new MySqlConnection("Persist Security info = false; server=localhost;uid=root;pwd=lugsilva167;database=login");//conexão com o servidor


        public void conectar()
        {
            login.Open();
        }

        public void desconectar()
        {
            login.Close();
        }
    }

   
}
