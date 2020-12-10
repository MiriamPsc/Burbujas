using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloBubbles
{
    public partial class Form1 : Form
    {
        Ordenamiento O = new Ordenamiento();
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            O.Agregar(n);
            textBox1.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = O.Mostrar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            O.Ordenar();
            label2.Text = O.Mostrar();
            MessageBox.Show(O.Ordenar());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            O.VaciarLista();
        }
    }
}