using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamento_2
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnCadas_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.Show();

            this.Hide();
        }

        private void btnCadas_MouseMove(object sender, MouseEventArgs e)
        {
            btnCadas.BackColor = Color.White;
            btnCadas.ForeColor = Color.Black;

            btnLog.BackColor = Color.Gray;
            btnLog.ForeColor = Color.White;
        }

        private void inicio_MouseMove(object sender, MouseEventArgs e)
        {
            btnCadas.BackColor = Color.Gray;
            btnCadas.ForeColor = Color.White;

            btnLog.BackColor = Color.Gray;
            btnLog.ForeColor = Color.White;

        }

        private void btnLog_MouseMove(object sender, MouseEventArgs e)
        {
            btnLog.BackColor = Color.White;
            btnLog.ForeColor = Color.Black;

            btnCadas.BackColor = Color.Gray;
            btnCadas.ForeColor = Color.White;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
             login login = new login();
            login.Show();

            this.Hide();
        }
    }
}
