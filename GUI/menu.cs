using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.GUI;
using PROYECTO.GUI;

namespace Interface.GUI
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new BOTON());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new BOTONES());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new departamento());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
