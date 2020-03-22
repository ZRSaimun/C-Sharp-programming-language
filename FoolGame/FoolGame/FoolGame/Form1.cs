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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            GForm g = new GForm();
            this.Visible =false;
            g.Visible = true;
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            LForm l = new LForm();
            this.Visible = false;
            l.Visible = true;
        }

        private void MouseEnter(object sender, EventArgs e)
        {
           /* int x = new Random().Next(700);
            int y = new Random().Next(400);
            nobtn.Location = new Point(x, y);
            */
            //2nd way to try Random
            int i;
             Random x = new Random();
             for (i = 0; i < 10; i++)
             {
                 Point pt = new Point
                   (
                         int.Parse(x.Next(700).ToString()),
                         int.Parse(x.Next(400).ToString())
                    );

                 nobtn.Location = pt;
             }
        }
    }
}
