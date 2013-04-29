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
    public partial class frontSuspenderInMC : UserControl
    {
        Size fsSize = new Size();
        Point fsLocation = new Point();
        public Point FsLocation
        {
            get
            {
                return fsLocation;
            }
            set
            {
                fsLocation = value;
            }
        }
        uint fsIndex = 0;
        uint fsNO = 1;
        public uint FsIndex
        {
            get
            {
                return fsIndex;
            }
            set
            {
                fsIndex = value;
            }
         }
        
        public frontSuspenderInMC(ref uint NO,ref int index)
        {
            InitializeComponent();
            FsIndex = Convert.ToUInt32(index);
            fsNO = NO;
            fsSize = this.Size;                                                             //保存各控件容器的坐标，以备重绘时调整位置
            fsLocation = this.Location;

            Size[] labelSize = new Size[12];
            Point[] labelLocation = new Point[12];
            int heightOfAllLabel=fsSize.Height - fsSize.Height / 20 - fsSize.Height / 3-5-60;
            for (int i = 0; i < 5; i++)
            {
                labelSize[i] = new Size(fsSize.Width / 7, heightOfAllLabel/5);
                labelLocation[i] = new Point(1, heightOfAllLabel * i / 5);
            }
            for (int i = 5; i < 10; i++)
            {
                labelSize[i] = new Size(Convert.ToInt32(fsSize.Width *2.7)/ 6, heightOfAllLabel/5);
                labelLocation[i] = new Point(labelSize[0].Width + 2, labelLocation[i-5].Y);
            }
            labelSize[6].Width = labelSize[6].Width *3/ 5-1;
            labelSize[9].Width = labelSize[6].Width;
            labelSize[10] = new Size(labelSize[5].Width - labelSize[6].Width-1, labelSize[6].Height);
            labelLocation[10] = new Point(labelLocation[6].X + labelSize[6].Width + 1, labelLocation[6].Y);
            labelSize[11] = new Size(labelSize[10].Width, labelSize[6].Height);
            labelLocation[11] = new Point(labelLocation[9].X + labelSize[9].Width + 1, labelLocation[9].Y);

            for (int i = 0; i < this.Controls.Count; i++)
            {
                Label lb = this.Controls[i] as Label;
                if (lb == null)
                    continue;
                lb.Location = labelLocation[Convert.ToInt32(lb.Name.Substring(5))-1];
                lb.Size = labelSize[Convert.ToInt32(lb.Name.Substring(5))-1];
            }


            this.trackBar.Size = new Size(Convert.ToInt32(fsSize.Width / 1.67), fsSize.Height / 20);
            // this.trackBar.Location = new Point(0, this.trackBar.Location.Y);
            this.trackBar.Location = new Point(0, Convert.ToInt32(fsSize.Height / 3)+3);
            up.Size = new Size(Convert.ToInt32(fsSize.Width / 5.3), fsSize.Height / 11);
            up.Location = new Point(0, trackBar.Location.Y + trackBar.Size.Height-22);
            stop.Size = new Size(up.Size.Width,up.Size.Height);
            stop.Location = new Point(up.Location.X + up.Size.Width + 1, up.Location.Y);
            down.Size = new Size(up.Size.Width, up.Size.Height);
            down.Location = new Point(stop.Location.X + stop.Size.Width + 1, up.Location.Y);

            option.Size = new Size(stop.Location.X + stop.Size.Width - up.Location.X, up.Size.Height);
            option.Location = new Point(0, up.Location.Y + up.Size.Height);
            exit.Size = new Size(up.Size.Width, up.Size.Height);
            exit.Location = new Point(option.Location.X + option.Size.Width + 1, up.Location.Y + up.Size.Height);


            label6.Text = "" + NO + " " + NO + "#前舞台吊杆";
        }

        private void frontSuspenderInMC_Load(object sender, EventArgs e)
        {
        //    this.Size = new Size(Parent.Size.Width / 4, 2);
            
          //  trackBar.Show();
        }

        private void frontSuspenderInMC_Resize(object sender, EventArgs e)
        {

            frontSuspenderInMC fs = sender as frontSuspenderInMC;
            if (fs == null)
                return;
            double heightRate = (fs.Size.Height + 0.0) / fs.fsSize.Height;
            double widthRate = (fs.Size.Width + 0.0) / fs.fsSize.Width;           
            if (double.IsInfinity(heightRate) || double.IsInfinity(widthRate))
            {
                return;
            }
            resizeLayout afterResize=new resizeLayout();
            afterResize.readjustLayout(sender, heightRate, widthRate);
            this.fsSize = fs.Size;
           // this.fsLocation = fs.Location;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            mechineCtrl mc = this.Parent.Parent.Parent as mechineCtrl;
            if (mc == null)
                return;
            mc.fsExit(this);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Label lb = this.Controls[i] as Label;
                if (lb == null)
                    continue;
                lb.Visible = false;
            }
            calcInfs fs = new calcInfs(label8.Text);
            fs.Parent = this;
            fs.Size = new Size(this.Width-2, this.Height-2);
            fs.Location = new Point(1,1);
            fs.Visible = true;
            fs.Enabled = true;
            fs.Show();
           
        }
        public void isCalcOK(calcInfs cc,bool isOK)
        {
            if (isOK)
            {
                label8.Text = cc.resultFromCalc();
            }
            cc.Dispose();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Label lb = this.Controls[i] as Label;
                if (lb == null)
                    continue;
                lb.Visible = true;
            }
        }
    }
}
