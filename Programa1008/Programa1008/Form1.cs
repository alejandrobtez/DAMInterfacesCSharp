using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa1008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MiControl miBoton = new MiControl
            {
                Text = "Haz Hover",
                Size = new Size(100, 50),
                Location = new Point(50, 50),
                Gigante = true
            };
            this.Controls.Add(miBoton);
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
