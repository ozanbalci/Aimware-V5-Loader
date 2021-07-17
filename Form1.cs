using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimWare_V5_Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moveform.move.ReleaseCapture();
            moveform.move.PostMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
