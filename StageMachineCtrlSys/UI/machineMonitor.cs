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
    public partial class machineMonitor : UserControl
    {
        static int[] pos = new int[20];                      //台上设备位置
        liftsInmm[] lifts = new liftsInmm[10];
        turntableInmm tt = new turntableInmm();
        public machineMonitor()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                lifts[i] = new liftsInmm();
           /*     lifts[i].setPos(ref i);
                if (i % 3 == 0)
                   lifts[i].setSpeed(ref i);
                else
                {
                    int ii = 0;
                    lifts[i].setSpeed(ref ii);
                }*/
                lifts[i].Location = new Point(i * (this.Size.Width + 9) / 18, Convert.ToInt32(this.Size.Height / 2.18));
                lifts[i].Size = new System.Drawing.Size((this.Size.Width + 9) / 18, this.Size.Height / 2);
                lifts[i].Parent = this;
                lifts[i].Visible = true;
                lifts[i].Show();
          //      System.Drawing.Graphics g=this.CreateGraphics();
           //     Pen pen=new Pen(Color.DarkGray);
           //     g.DrawRectangle(pen, lifts[i].Location.X, lifts[i].Location.Y, lifts[i].Location.X+lifts[i].Size.Width, lifts[i].Location.Y+lifts[i].Size.Height);
            }
            lifts[1].setPos(3010);
            lifts[2].setSpeed(530);
            lifts[2].setPos(1750);
            lifts[3].setPos(350);
            lifts[7].setPos(1100);
            tt.Location = new Point((this.Size.Width + 9) / 3, Convert.ToInt32(this.Size.Height / 3.4));
          //  tt.Location = new Point(lifts[9].Location.X + lifts[9].Size.Width, lifts[9].Location.Y);
            tt.Parent = this;
            tt.Visible = true;
            tt.Show();
          //  for (int i = 0; i < pos.GetLength(0); i++)
            //    pos[i] = i*3;
            pos[0] = 5265;
            pos[1] = 1500;
            pos[5] = 2370;
           
        }

        private void machineMonitor_Load(object sender, EventArgs e)
        {

        }
        #region 重绘panel
        private void redrawPanel(ref object sender, ref PaintEventArgs e,int index=0)
        {
            Panel p = sender as Panel;
            if (p == null)
                return;
            Pen pen = new Pen(Color.DarkGray);
            pen.Width = 2;
            SolidBrush b = new SolidBrush(Color.DarkGray);//定义单色画刷
            e.Graphics.DrawRectangle(pen, p.ClientRectangle);
            Rectangle rect=new Rectangle();
            rect.Width = p.ClientRectangle.Width - 10;
            rect.Height = 5;
            Font f=new Font("Verdana",15);
            b.Color = Color.Black;
            e.Graphics.DrawString(pos[index].ToString(),f , b, new Point(5, 20 + pos[index]/100));
            b.Color = Color.DarkGray;
            rect.Location = new Point(5, 20 + pos[index]/100+f.Height);
            e.Graphics.FillRectangle(b, rect);
            rect.Height = rect.Width;
            rect.Location = new Point(5, 20 + 5 + pos[index]/100 + f.Height);
            e.Graphics.DrawEllipse(pen, rect);
            e.Graphics.FillEllipse(b, rect);
            b.Color=Color.LightCyan;
            e.Graphics.FillEllipse(b,new Rectangle(Convert.ToInt32(rect.X+rect.Width/2-5),Convert.ToInt32(rect.Y+(rect.Height/2)-5),10,10));
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,0);
        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,1);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,2);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,3);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,4);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,5);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,6);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,7);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,8);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,9);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,10);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,11);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,12);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,13);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,14);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            redrawPanel(ref sender, ref  e,15);
        }
        #endregion
    }
   
}
