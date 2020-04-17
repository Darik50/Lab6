using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Laba6
{    
    public partial class Form1 : Form
    {
        int oper = 0;
        int opernum = 0;
        float x;
        float y;
        int obn = 0;
        int Fh = 444;
        int Fw = 318;
        int Bh = 55;
        int Bw = 56;
        Size But;

        public Form1()
        {
            InitializeComponent();
            Form1_Resize(new object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "7";
            }
            else
            {
                label2.Text = "7";
                obn = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "1";
            }
            else
            {
                label2.Text = "1";
                obn = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "2";
            }
            else
            {
                label2.Text = "2";
                obn = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "0";
            }
            else
            {
                label2.Text = "0";
                obn = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "3";
            }
            else
            {
                label2.Text = "3";
                obn = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "4";
            }
            else
            {
                label2.Text = "4";
                obn = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "5";
            }
            else
            {
                label2.Text = "5";
                obn = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "6";
            }
            else
            {
                label2.Text = "6";
                obn = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "8";
            }
            else
            {
                label2.Text = "8";
                obn = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (obn == 0)
            {
                label2.Text = label2.Text + "9";
            }
            else
            {
                label2.Text = "9";
                obn = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int n = 0;
            for(int i = 0; i < label2.Text.Length; i++)
            {
                if(label2.Text.Substring(i, 1) == ",")
                {
                    n++;
                }
            }
            if(label2.Text == "" || obn == 1)
            {
                label2.Text = "0,";
                obn = 0;
            }
            else
            {
                if(n == 0)
                {
                    label2.Text = label2.Text + ",";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            oper = 0;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (obn != 1)
            {
                if (oper == 0)
                {
                    x = float.Parse(label2.Text);
                    label1.Text = label2.Text + "+";
                    oper++;
                }
                else
                {
                    if (opernum == 1)
                    {
                        y = float.Parse(label2.Text);
                        x = x + y;
                        label1.Text = label1.Text + label2.Text + "+";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 2)
                    {
                        y = float.Parse(label2.Text);
                        x = x - y;
                        label1.Text = label1.Text + label2.Text + "+";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 3)
                    {
                        y = float.Parse(label2.Text);
                        x = x * y;
                        label1.Text = label1.Text + label2.Text + "+";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 4)
                    {
                        y = float.Parse(label2.Text);
                        x = x / y;
                        label1.Text = label1.Text + label2.Text + "+";
                        label2.Text = x.ToString();
                    }

                }
            }
            else
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1) + "+";
            }
            opernum = 1;
            obn = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (obn != 1)
            {
                if (oper == 0)
                {
                    x = float.Parse(label2.Text);
                    label1.Text = label2.Text + "-";
                    oper++;
                }
                else
                {
                    if (opernum == 1)
                    {
                        y = float.Parse(label2.Text);
                        x = x + y;
                        label1.Text = label1.Text + label2.Text + "-";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 2)
                    {
                        y = float.Parse(label2.Text);
                        x = x - y;
                        label1.Text = label1.Text + label2.Text + "-";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 3)
                    {
                        y = float.Parse(label2.Text);
                        x = x * y;
                        label1.Text = label1.Text + label2.Text + "-";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 4)
                    {
                        y = float.Parse(label2.Text);
                        x = x / y;
                        label1.Text = label1.Text + label2.Text + "-";
                        label2.Text = x.ToString();
                    }

                }
            }
            else
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1) + "-";
            }
            opernum = 2;
            obn = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (obn != 1)
            {
                if (oper == 0)
                {
                    x = float.Parse(label2.Text);
                    label1.Text = label2.Text + "*";
                    oper++;
                }
                else
                {
                    if (opernum == 1)
                    {
                        y = float.Parse(label2.Text);
                        x = x + y;
                        label1.Text = label1.Text + label2.Text + "*";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 2)
                    {
                        y = float.Parse(label2.Text);
                        x = x - y;
                        label1.Text = label1.Text + label2.Text + "*";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 3)
                    {
                        y = float.Parse(label2.Text);
                        x = x * y;
                        label1.Text = label1.Text + label2.Text + "*";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 4)
                    {
                        y = float.Parse(label2.Text);
                        x = x / y;
                        label1.Text = label1.Text + label2.Text + "*";
                        label2.Text = x.ToString();
                    }

                }
            }
            else
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1) + "*";
            }
            opernum = 3;
            obn = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (obn != 1)
            {
                if (oper == 0)
                {
                    x = float.Parse(label2.Text);
                    label1.Text = label2.Text + "/";
                    oper++;
                }
                else
                {
                    if (opernum == 1)
                    {
                        y = float.Parse(label2.Text);
                        x = x + y;
                        label1.Text = label1.Text + label2.Text + "/";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 2)
                    {
                        y = float.Parse(label2.Text);
                        x = x - y;
                        label1.Text = label1.Text + label2.Text + "/";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 3)
                    {
                        y = float.Parse(label2.Text);
                        x = x * y;
                        label1.Text = label1.Text + label2.Text + "/";
                        label2.Text = x.ToString();
                    }
                    if (opernum == 4)
                    {
                        y = float.Parse(label2.Text);
                        x = x / y;
                        label1.Text = label1.Text + label2.Text + "/";
                        label2.Text = x.ToString();
                    }

                }
            }
            else
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1) + "/";
            }
            opernum = 4;
            obn = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (oper == 0)
            {
                x = float.Parse(label2.Text);
                label1.Text = label2.Text;
                oper++;
            }
            else
            {
                if (opernum == 1)
                {
                    y = float.Parse(label2.Text);
                    x = x + y;
                    label1.Text = x.ToString();
                    label2.Text = x.ToString();
                }
                if (opernum == 2)
                {
                    y = float.Parse(label2.Text);
                    x = x - y;
                    label1.Text = x.ToString();
                    label2.Text = x.ToString();
                }
                if (opernum == 3)
                {
                    y = float.Parse(label2.Text);
                    x = x * y;
                    label1.Text = x.ToString();
                    label2.Text = x.ToString();
                }
                if (opernum == 4)
                {
                    y = float.Parse(label2.Text);
                    x = x / y;
                    label1.Text = x.ToString();
                    label2.Text = x.ToString();
                }

            }
            opernum = 0;
            obn = 0;
            oper = 0;
            Clipboard.SetText(label1.Text.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            double otnw = Convert.ToDouble(this.Size.Width) / Convert.ToDouble(Fw);
            double otnh = Convert.ToDouble(this.Size.Height) / Convert.ToDouble(Fh);            
            int h = Convert.ToInt32(Bh * otnh);
            int w = Convert.ToInt32(Bw * otnw);
            button1.Size = new Size(w,h);
            button2.Size = new Size(w, h);
            button3.Size = new Size(w, h);
            button4.Size = new Size(w, h);
            button5.Size = new Size(w, h);
            button6.Size = new Size(w, h);
            button7.Size = new Size(w, h);
            button8.Size = new Size(w, h);
            button9.Size = new Size(w, h);
            button10.Size = new Size(w, h);
            button11.Size = new Size(w, h);
            button12.Size = new Size(w, h);
            button13.Size = new Size(w, h);
            button14.Size = new Size(w, h);
            button15.Size = new Size(w, h);
            button16.Size = new Size(w, h);
            int lw = Convert.ToInt32(94 * otnw);
            int lh = Convert.ToInt32(84 * otnh);            
            button2.Location = new Point(lw, lh);
            lw = Convert.ToInt32(154 * otnw);
            button3.Location = new Point(lw, lh);
            lw = Convert.ToInt32(215 * otnw);
            button4.Location = new Point(lw, lh);
            lw = Convert.ToInt32(33 * otnw);
            button1.Location = new Point(lw, lh);
            lw = Convert.ToInt32(215 * otnw);
            lh = Convert.ToInt32(144 * otnh);
            button5.Location = new Point(lw, lh);
            lw = Convert.ToInt32(154 * otnw);
            lh = Convert.ToInt32(144 * otnh);
            button6.Location = new Point(lw, lh);
            lw = Convert.ToInt32(94 * otnw);
            lh = Convert.ToInt32(144 * otnh);
            button7.Location = new Point(lw, lh);
            lw = Convert.ToInt32(33 * otnw);
            lh = Convert.ToInt32(144 * otnh);
            button8.Location = new Point(lw, lh);
            lw = Convert.ToInt32(215 * otnw);
            lh = Convert.ToInt32(204 * otnh);
            button9.Location = new Point(lw, lh);
            lw = Convert.ToInt32(154 * otnw);
            lh = Convert.ToInt32(204 * otnh);
            button10.Location = new Point(lw, lh);
            lw = Convert.ToInt32(94 * otnw);
            lh = Convert.ToInt32(204 * otnh);
            button11.Location = new Point(lw, lh);
            lw = Convert.ToInt32(33 * otnw);
            lh = Convert.ToInt32(204 * otnh);
            button12.Location = new Point(lw, lh);
            lw = Convert.ToInt32(215 * otnw);
            lh = Convert.ToInt32(264 * otnh);
            button13.Location = new Point(lw, lh);
            lw = Convert.ToInt32(154 * otnw);
            lh = Convert.ToInt32(264 * otnh);
            button14.Location = new Point(lw, lh);
            lw = Convert.ToInt32(94 * otnw);
            lh = Convert.ToInt32(264 * otnh);
            button15.Location = new Point(lw, lh);
            lw = Convert.ToInt32(33 * otnw);
            lh = Convert.ToInt32(264 * otnh);
            button16.Location = new Point(lw, lh);
            lw = Convert.ToInt32(33 * otnw);
            lh = Convert.ToInt32(324 * otnh);
            button17.Location = new Point(lw, lh);
            h = Convert.ToInt32(55 * otnh);
            w = Convert.ToInt32(238 * otnw);
            button17.Size = new Size(w, h);
            lw = Convert.ToInt32(30 * otnw);
            lh = Convert.ToInt32(24 * otnh);
            label1.Location = new Point(lw, lh);
            lw = Convert.ToInt32(30 * otnw);
            lh = Convert.ToInt32(58 * otnh);
            label2.Location = new Point(lw, lh);
        }
    }
}
