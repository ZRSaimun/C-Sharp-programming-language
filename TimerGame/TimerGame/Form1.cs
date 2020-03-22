using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGame
{
    public partial class Form1 : Form
    {
        double score = 0;
        Timer t;
        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = 1100;
            t.Tick += t_Tick;
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
             Button[] button = new Button[10] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10 };
           // button1.BackColor = new Color(rd.Next("Green"), rd.Next("Green"));
            //Color c = Color.FromArgb(255, Color.FromArgb(Convert.ToInt32(rd.Next(0x1000000))));
           // button1.Color = new Point(rd.Next(720), rd.Next(420));
            
            Random r = new Random();

            int x = r.Next(0,10);
            string y = Convert.ToString(x);
           // MessageBox.Show(y);
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn8.BackColor = Color.Red;
            btn9.BackColor = Color.Red;
            btn10.BackColor = Color.Red;
 
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i].Text.Equals(y))
                {
                    if (button[i].BackColor == Color.Red)
                    {
                        button[i].BackColor = Color.Green;
                    }
                    else
                    {
                        button[i].BackColor = Color.Red;
                    }   
                }
            }  
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else 
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.Red)
            {
                score -= 5;
                ScoreLB.Text = Convert.ToString(score);
            }
            else
            {
                score += 5;
                ScoreLB.Text = Convert.ToString(score);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
