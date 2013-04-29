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
    public partial class mechineCtrl : UserControl
    {
        int fsCount = 0;
        frontSuspenderInMC[] fsArr = new frontSuspenderInMC[40];
        Size mcSize = new Size();
        Point mcLocation = new Point();
        Size chzSize = new Size();
        Point chzLocation = new Point();
        public mechineCtrl()
        {
            InitializeComponent();

            mcSize = this.Size;                                                             //保存各控件容器的坐标，以备重绘时调整位置
            mcLocation = this.Location;
            chooseZone.Size=new Size(this.Width/6,this.Height-185);
            chooseZone.Location = new Point(0, 0);
            controlZone.Size = new Size(Convert.ToInt32(this.Width / 2.33), chooseZone.Size.Height);
            controlZone.Location = new Point(this.Width / 6 + 2, 0);
            panel.Size = new System.Drawing.Size(controlZone.Width -4, controlZone.Height-13);
            panel.Location = new Point(2, 11);
            chzLocation = chooseZone.Location;
            chzSize = chooseZone.Size;
        }

        private void mechineCtrl_Load(object sender, EventArgs e)
        {
            foreach (Button ctrl in this.chooseZone.Controls)                                   //给选择区内的按钮安排位置
            {
                int width=Convert.ToInt32(chooseZone.Size.Width / 2.04);
                int height=Convert.ToInt32(chooseZone.Size.Height/21.8);
                ctrl.Size = new Size(width, height);
                int index = Convert.ToInt32(ctrl.Name.Substring(6));
                if (index < 200)                                                                //舞台控制按钮
                {
                    int x = 3 + ((index % 2) == 0 ? width + 2 : 2);
                    int y = ((index + 1) / 2 - 1) * (height) + 22;
                    ctrl.Location = new Point(x, y);
                }
                else                                                                            //翻页按钮
                {
                    width = Convert.ToInt32(chooseZone.Size.Width / 4.04);
                    ctrl.Size = new System.Drawing.Size(width, height);
                    int x = 3 + (index - 200) * (width + 1);
                    int y = 21 * height-13;
                    ctrl.Location = new Point(x, y);
                }
            }
        }

        private void mechineCtrl_Resize(object sender, EventArgs e)          //重绘控件（mechineCtrl）时调整控件内的子控件位置
        {
                if (this.mcSize.Height < 1)
                    return;  
                mechineCtrl mc = sender as mechineCtrl;
                if (mc == null)
                    return;
                double heightRate = (mc.Size.Height + 0.0) / this.mcSize.Height;
                double widthRate = (mc.Size.Width + 0.0) / this.mcSize.Width;
       
                this.mcSize = mc.Size;
                this.mcLocation = mc.Location;
               
                readjustLayout(mc, heightRate, widthRate);
        }
        public void readjustLayout(object container/*容器*/, double heightRate/*纵向缩放比例*/, double widthRate/*横向缩放比例*/)
        {
            Type type = container.GetType();
            if (type == typeof(mechineCtrl))
            {
                mechineCtrl frm = container as mechineCtrl;
                if (frm == null)
                    return;
                for (int i = 0; i < frm.Controls.Count; i++)
                {
                    Control ctrl = frm.Controls[i];
                    ctrl.Location = new Point(Convert.ToInt32(ctrl.Location.X * widthRate), Convert.ToInt32(ctrl.Location.Y * heightRate));
                    ctrl.Size = new Size(Convert.ToInt32(ctrl.Size.Width * widthRate), Convert.ToInt32(ctrl.Size.Height * heightRate));
                    readjustLayout(ctrl, heightRate, widthRate);
                }
            }
            else if (type == typeof(GroupBox))
            {
                GroupBox frm = container as GroupBox;
                if (frm == null)
                    return;
                for (int i = 0; i < frm.Controls.Count; i++)
                {
                    Control ctrl = frm.Controls[i];
                    ctrl.Location = new Point(Convert.ToInt32(ctrl.Location.X * widthRate), Convert.ToInt32(ctrl.Location.Y * heightRate));
                    ctrl.Size = new Size(Convert.ToInt32(ctrl.Size.Width * widthRate), Convert.ToInt32(ctrl.Size.Height * heightRate));
                    readjustLayout(ctrl, heightRate, widthRate);
                }
            }
            else if (type == typeof(Panel))
            {
                Panel frm = container as Panel;
                if (frm == null)
                    return;
                for (int i = 0; i < frm.Controls.Count; i++)
                {
                    Control ctrl = frm.Controls[i];
                    ctrl.Location = new Point(Convert.ToInt32(ctrl.Location.X * widthRate), Convert.ToInt32(ctrl.Location.Y * heightRate));
                    ctrl.Size = new Size(Convert.ToInt32(ctrl.Size.Width * widthRate), Convert.ToInt32(ctrl.Size.Height * heightRate));
                    readjustLayout(ctrl, heightRate, widthRate);
                }
            }
            else if (type == typeof(UserControl))
            {
                UserControl frm = container as UserControl;
                if (frm == null)
                    return;
                for (int i = 0; i < frm.Controls.Count; i++)
                {
                    Control ctrl = frm.Controls[i];
                    ctrl.Location = new Point(Convert.ToInt32(ctrl.Location.X * widthRate), Convert.ToInt32(ctrl.Location.Y * heightRate));
                    ctrl.Size = new Size(Convert.ToInt32(ctrl.Size.Width * widthRate), Convert.ToInt32(ctrl.Size.Height * heightRate));
                    readjustLayout(ctrl, heightRate, widthRate);
                }
            } 
        }
    
        private void frontSuspender(ref object sender)                  //创建前舞台吊杆子控件(frontSuspenderInMC)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            if (fsCount >= 8)
                return;
            uint index = Convert.ToUInt32(btn.Name.Substring(6));
            fsArr[fsCount] = new frontSuspenderInMC(ref index,ref fsCount);
            fsArr[fsCount].Parent = this.panel;
            fsArr[fsCount].Size = new Size(Convert.ToInt32((panel.Width) / 4.03), Convert.ToInt32(panel.Height / 2.03) - 4);
            fsArr[fsCount].Location = new Point(1 + (fsCount % 4) * fsArr[fsCount].Size.Width + 1, 5 + (fsCount / 4) * fsArr[fsCount].Size.Height + 1);
            fsArr[fsCount].Visible = true;
            fsArr[fsCount].Enabled = true;
            fsArr[fsCount].Show();
            fsCount++;
        }

        public void fsExit(frontSuspenderInMC fs)                                                     //退出前舞台吊杆控制
        {
            uint fsIndex = fs.FsIndex;
            for (int i = fsCount-1; i > (int)fsIndex; i--)
            {           
                fsArr[i].Location = new Point(fsArr[i - 1].Location.X, fsArr[i - 1].Location.Y);
                fsArr[i].FsLocation = new Point(fsArr[i - 1].Location.X, fsArr[i - 1].Location.Y);
                if (fsArr[i].FsIndex > 0)
                    fsArr[i].FsIndex = fsArr[i].FsIndex - 1;
             
            }
            fsArr[fsIndex] = null;
            fs.Dispose();
            fsCount--;
            for (int i = 0; i < 8; i++)
            {
                if (fsArr[i] == null)
                {
                    for(int k=i;k<8;k++)
                    {
                            fsArr[k] = fsArr[k + 1];
                    }
                }
            }

        }
        #region 按钮响应
        private void button1_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            frontSuspender(ref sender);
        }
        

        private void button200_Click(object sender, EventArgs e)              //首页
        {

        }

        private void button201_Click(object sender, EventArgs e)                 //上一页
        {

        }

        private void button202_Click(object sender, EventArgs e)                  //下一页
        {

        }

        private void button203_Click(object sender, EventArgs e)                  //尾页
        {

        }
        #endregion
    }
}
