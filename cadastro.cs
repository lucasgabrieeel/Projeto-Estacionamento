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

namespace estacionamento_2
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nome = txtNo.Text;
            string senha = txtSen.Text;
            string cpf = txtCpf.Text;
            string telefone = txtTel.Text;
            string endereco = txtEnd.Text;


            if (string.IsNullOrEmpty(nome) ||
                string.IsNullOrEmpty(senha) ||
                string.IsNullOrEmpty(cpf) ||
                string.IsNullOrEmpty(telefone) ||
                string.IsNullOrEmpty(endereco))
            {

                MessageBox.Show("caixas de textos vazia");
                return;
            }

            string strconexao = conn.strConn;

            string sql = "INSERT INTO cadastro (nome, senha, cpf, telefone, endereço) VALUE (@nome, @senha, @CPF, @telefone, @endereço)";



            using (MySqlConnection conn = new MySqlConnection(strconexao))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        //evita  injeção  DDos
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@endereço", endereco);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("cadastro relaizado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao cadastrar " + ex.Message);
                }

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();

            this.Hide();

        }
    }
}
