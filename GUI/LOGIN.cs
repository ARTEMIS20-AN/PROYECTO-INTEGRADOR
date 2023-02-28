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
namespace Interface
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form t = new MENU();
            t.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
