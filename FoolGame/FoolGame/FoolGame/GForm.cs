using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoolGame
{
    public partial class GForm : Form
    {
        public GForm()
        {
            InitializeComponent();
        }

        private void againbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




    }
}
