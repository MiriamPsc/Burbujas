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

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            int tam = Convert.ToInt32(textBox1.Text);
            int may = Convert.ToInt32(textBox2.Text);
            int men = Convert.ToInt32(textBox3.Text);
            O.Agregar(tam, may, men);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            label2.Text = O.Mostrar();
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            O.Ordenar();
            label2.Text = O.Mostrar();
            MessageBox.Show(O.Ordenar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            O.VaciarLista();
        }
    }
}