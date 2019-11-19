using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dsemana cunha = new dsemana();
        private void Button1_Click(object sender, EventArgs e)
        {
            cunha.recebe = textBox1.Text;
            label1.Text = cunha.envia;
            label1.Text = ("O dia da semana em que você nasceu é " + cunha.envia);
        }
    }
}
