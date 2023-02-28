using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.GUI;

namespace PROYECTO.GUI
{
    public partial class BOTON : Form
    {
        public BOTON()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new NuevoReporte_GUI();
            form.Show();
        }

        private void BOTON2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new HistorialDeReportes_GUI();
            form.Show();
        }
    }




}
