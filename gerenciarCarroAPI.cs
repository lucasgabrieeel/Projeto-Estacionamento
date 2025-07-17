using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace estacionamento_2
{
    public partial class gerenciarCarroAPI : Form
    {
        public gerenciarCarroAPI()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var carros = new carros();
            var listarCarro = await carros.ObtercarrosAsync();

            dataGridView1.DataSource = listarCarro;
        }
    }
}
