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
using MySql.Data;

namespace estacionamento_2
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string carro = txtCarro.Text;
            string cor = txtCor.Text;
            string placa = txtPlaca.Text;

            if (string.IsNullOrEmpty(carro) ||
                string.IsNullOrEmpty(cor) ||
                string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            string sqconexao = conn.strConn;

            string conexao = "INSERT INTO carros (carro, cor, placa ) VALUE (@carro, @cor, @placa)";

            using (MySqlConnection conn = new MySqlConnection(sqconexao))
            {
                try
                {
                    conn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(conexao, conn))
                    {
                        cmd.Parameters.AddWithValue("@carro", carro);
                        cmd.Parameters.AddWithValue("@cor", cor);
                        cmd.Parameters.AddWithValue("@placa", placa);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("carro cadastrado com sucesso!");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("erro ao cadastrar carro" + ex.Message);
                }
            }
                

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerenciarCarros gerenciar = new GerenciarCarros();
            gerenciar.Show();

            this.Hide();
        }
    }
}
