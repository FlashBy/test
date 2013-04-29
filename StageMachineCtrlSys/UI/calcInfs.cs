using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StageMachineCtrlSys
{
    public partial class calcInfs : UserControl
    {
        Size fsSize = new Size();
        Point fsLocation = new Point();
        public calcInfs(string label8)
        {
            InitializeComponent();
            resizeLayout afterResize = new resizeLayout();
            afterResize.readjustLayout(this, 0.92, 0.60);
            this.Location = new Point(1, 1);
            textBox.Text = label8;
        }

        private void calcInfs_Resize(object sender, EventArgs e)
        {
            calcInfs fs = sender as calcInfs;
            if (fs == null)
                return;
            double heightRate = (fs.Size.Height + 0.0) / fs.fsSize.Height;
            double widthRate = (fs.Size.Width + 0.0) / fs.fsSize.Width;
            if (double.IsInfinity(heightRate) || double.IsInfinity(widthRate))
            {
                return;
            }
            resizeLayout afterResize = new resizeLayout();
            afterResize.readjustLayout(sender, heightRate, widthRate);
            this.fsSize = fs.Size;
            this.fsLocation = fs.Location;
        }

       

        private void button0_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btnClicked(ref sender);
        }
        private void btnClicked(ref object sender)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            int index=Convert.ToInt32(btn.Name.Substring(6));
            switch (index)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    if (textBox.Text.Length > 5)
                        return;
                    textBox.Text += index;
                    if (textBox.Text.Length > 1 && textBox.Text[0] == '0')
                        textBox.Text = textBox.Text.Substring(1);
                    break;
                case 10:
                    if (textBox.Text[0] == '-')
                        textBox.Text=textBox.Text.Substring(1);
                    else
                        textBox.Text = '-' + textBox.Text;
                    break;
                case 11:               
                case 12:
                    frontSuspenderInMC fs = this.Parent as frontSuspenderInMC;
                    if (fs == null)
                        return;
                    fs.isCalcOK(this, index == 12 ? false : true);
                    break;
                default:
                    break;
            }
        }
        public  string  resultFromCalc()
        {
            return textBox.Text;
        }
    }
}
