using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Windows.Forms;

namespace estacionamento_2
{
    static class conn
    {
        public static string strConn;

        static conn()
        {
            var config = Config.Carregar();
            strConn = $"server={config.Servidor};uid={config.Usuario};pwd={config.Senha};database={config.Banco}";
        }
    }

    public class Config
    {
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public static Config Carregar()
        {
            try
            {
                string path = "config.json";

                if (!File.Exists(path))
                {
                    MessageBox.Show($"Arquivo '{path}' não encontrado em: {Directory.GetCurrentDirectory()}");
                    throw new FileNotFoundException("config.json não encontrado.");
                }

                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<Config>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar config.json: " + ex.Message);
                throw;
            }
        }
    }



}
