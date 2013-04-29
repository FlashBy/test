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
    public partial class turntableInmm : UserControl
    {
        Rectangle VehicleRect = new Rectangle();
        public turntableInmm()
        {
            InitializeComponent();
        }

        private void turntableInmm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender,ref  e);
        }
        private void redrawPanel(ref object sender, ref PaintEventArgs e)
        {
            Panel p = sender as Panel;
            if (p == null)
                return;
            Pen pen = new Pen(Color.DarkGray);
            pen.Width = 2;
            e.Graphics.DrawRectangle(pen, p.ClientRectangle);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            if (p == null)
                return;
            Pen pen = new Pen(Color.DarkGray);
            pen.Width = 1;
            pen.Color=Color.Red;
            SolidBrush b = new SolidBrush(Color.LightPink);//定义单色画刷    
            e.Graphics.FillRectangle(b, p.ClientRectangle);
         //   e.Graphics.DrawRectangle(pen, p.ClientRectangle);
            pen.Color = Color.Blue;
            b.Color = Color.White;
            Rectangle r = new Rectangle(new Point(p.ClientRectangle.X + p.ClientRectangle.Width / 12, p.ClientRectangle.Y + p.ClientRectangle.Height /12), new System.Drawing.Size(p.ClientRectangle.Width*5 / 6, p.ClientRectangle.Height*5 / 6));
           int min=r.Width<r.Height?r.Width:r.Height;
           r.Width = min;
           r.Height = min;
           r.Location = new Point((p.ClientRectangle.Left+p.ClientRectangle.Right)/2-r.Width/2,(p.ClientRectangle.Top+p.ClientRectangle.Bottom)/2-r.Height/2);
            e.Graphics.FillEllipse(b, r);
            VehicleRect = r;
            e.Graphics.DrawPie(pen, r,315,675);
            pen.Color = Color.LightPink;
            e.Graphics.DrawEllipse(pen, r);

           

            Region region=new System.Drawing.Region(p.ClientRectangle);
        }

        private void turntableInmm_Paint(object sender, PaintEventArgs e)
        {
            turntableInmm p = sender as turntableInmm;
            if (p == null)
                return;
            Pen pen = new Pen(Color.DarkGray);
            pen.Width = 2;
            Rectangle r = new Rectangle();
            r = p.ClientRectangle;
            r.Width = panel1.Location.X + panel1.Size.Width + 2-r.Left;
            r.Height=panel10.Location.Y+panel10.Size.Height-r.Top+5;
            e.Graphics.DrawRectangle(pen, r);
           
          
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "5号侧车驱动";
            label2.Text = "0";
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "3号侧车驱动";
            label2.Text = "0";
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "1号侧车驱动";
            label2.Text = "0";
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "6号侧车驱动";
            label2.Text = "0";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "4号侧车驱动";
            label2.Text = "0";
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "2号侧车驱动";
            label2.Text = "0";
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            Panel p = sender as Panel;
            if (p == null)
                return;
            if (e.X > VehicleRect.X && e.X < VehicleRect.Right && e.Y > VehicleRect.Y && e.Y < VehicleRect.Bottom)
            {
                label1.Text = "后车台";
                label2.Text = "45°";
            }
            else
            {
                label1.Text = "后车台转台";
                label2.Text = "0";
            }
        }
        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

       
    }
}
