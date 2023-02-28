using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO.GUI
{
    public partial class departamento : Form
    {
        public departamento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AgregarDepartamento_GUI();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form t = new BuscarDepartamento();
            t.Show();
        }
    }
}
