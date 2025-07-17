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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string conexao = conn.strConn;

            var connection = new MySqlConnection(conexao);

            var command = connection.CreateCommand();

            MySqlCommand query = new MySqlCommand("SELECT count(*) FROM cadastro where Nome ='" + txtNome.Text + "' and senha ='" + txtSenha.Text + "'", connection);

            connection.Open();

            DataTable datatable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(datatable);

            foreach (DataRow list in datatable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    menu menu = new menu();
                    menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario invalido, verifique se você digitou a senha correta e o nome correto");
                }


            }

            connection.Close();
        }
    }
}
