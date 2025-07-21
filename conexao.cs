using System;
using System.IO;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace estacionamento_2
{

    class Conexao
    {
        private MySqlConnection login;

        public void Conectar()
        {
            // Lê o arquivo config.json
            string jsonString = File.ReadAllText("config.json");
            Config config = JsonSerializer.Deserialize<Config>(jsonString);

            // Monta a string de conexão
            string connStr = $"server={config.Servidor};uid={config.Usuario};pwd={config.Senha};database={config.Banco};";

            login = new MySqlConnection(connStr);
            login.Open();
        }

        public void Desconectar()
        {
            if (login != null && login.State == System.Data.ConnectionState.Open)
                login.Close();
        }
    }
}

