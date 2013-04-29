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
    public partial class liftsInmm : UserControl
    {
        public liftsInmm()
        {
            InitializeComponent();
        }

        private void liftsInmm_Load(object sender, EventArgs e)
        {
           
        }
        public void setPos(int pos)
        {
         //   this.label7.Location = new Point(this.label7.Location.X,this.label7.Location.Y - pos);
            this.label4.Location = new Point(this.label4.Location.X, this.label4.Location.Y- pos/100);
            this.label5.Location = new Point(this.label5.Location.X, this.label5.Location.Y - pos/100);
            this.label4.Text = pos.ToString();
            this.label9.Text = this.label4.Text;
        }
        public void setSpeed(int speed)
        {
            this.label8.Text = speed.ToString();
            if (speed == 0)
            {
                this.label10.Text = "停止";
            }
            else
            {
                this.label10.Text = "运行";
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
