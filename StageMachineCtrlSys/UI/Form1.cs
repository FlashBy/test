using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using StageMachineCtrlSys.DAL;


namespace StageMachineCtrlSys
{
    public partial class FormFrm : Form
    {
        public double resizeRateX=1;
        public double resizeRateY = 1;
        Point frmLocation = new Point(0,0);

        Size frmSize=new Size();

        mechineCtrl mc;
        repertoireManage rm;
        machineDemonstrate md;
        synchroControl sc;
        rockerControl rc;
        public rockerControl Rc
        {
            get
            {
                return rc;
            }
            set
            {
                rc = value;
            }
        }
        machineMonitor mm;
        log l;
        welcome w;
        private bool passwordError = true;
        private Byte buttonCount = 0;
        private Byte currentSelectedButton = 0;
        Button[] topButtons = new Button[7];
        #region 初始化、关闭
        public FormFrm()
        {
            InitializeComponent();
            frmLocation = this.Location;
            frmSize = this.Size;
        }

        private void FormFrm_Load(object sender, EventArgs e)
        {
           
            this.statusStrip.Items[0].Text = "  " + DateTime.Now.ToString();
            timer1000ms.Start();
        }
        private void addLoginInfo(string u, string p,bool isLogin=true)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["StageMachineCtrlSys.Properties.Settings.DB_SMCSConnectionStringFromSQL2008"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "Users");
                connection.Open();
                string strCommand = "Insert into Users values('";
                strCommand += u;
                strCommand += "','";
                strCommand += p;
                strCommand += "','";
                strCommand+=DateTime.Now;
                strCommand += "','";
                strCommand += isLogin;
                strCommand += "','";
                strCommand += "')";
                SqlCommand command = new SqlCommand(strCommand,
                //   "SELECT * FROM dbo.User;",
                   connection);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void FormFrm_Shown(object sender, EventArgs e)
        {
            FormFrm frm = sender as FormFrm;
                if (frm == null)
                    return;
            function.Visible = false;
            operation.Visible = false;
            LoginBack lb = new LoginBack();
            lb.Parent = this;
       //     lb.Location=new Point(
            Login l = new Login();
            if (DialogResult.OK != l.ShowDialog())
            {
                this.Close();
            }
            else
            {
                passwordError = false;
                string strUser = l.getCurrentUserName();
                statusStrip.Items[2].Text = "当前登录账户："+strUser;
                addLoginInfo(strUser, "");
                lb.Visible = false;
                function.Visible = true;
                operation.Visible = true;
                frm.Location = new Point(20, 20);

                Rectangle rect = new Rectangle();//声明一个rect
                rect = Screen.PrimaryScreen.Bounds;//获取当前屏幕的分辨率
                int width, height;//声明宽度，高度
                width = int.Parse(rect.Width.ToString());
                height = int.Parse(rect.Height.ToString());//将高度宽度赋值
         //       this.operation.Width = width * 6 / 7;
         //       this.operation.Height = height * 74/100;
                this.operation.Width = width * 15 / 16;
                this.operation.Height = height * 77 / 100;
                function.Width = width * 1 / 8;
                function.Height = height * 74 / 100;
                this.panel.Size = new Size(this.operation.Size.Width*99/100, (this.operation.Size.Height - this.welcomeBtn.Size.Height)*381/400 );
                if (w == null)
                {
                    w = new StageMachineCtrlSys.welcome();
                    w.Parent = panel;
                    w.Location = new Point(0, 0);
                    w.Size = new Size(panel.Width, panel.Height);
                    w.Show();
                }
                w.Visible = true;
                topButtons[buttonCount++] = welcomeBtn;
            }
        }
        private void FormFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!passwordError)
                if (MessageBox.Show("确认退出舞台机械控制系统？", "请确认", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    e.Cancel = true;
                else
                    if(statusStrip.Items[2].Text.Length>7)
                        addLoginInfo(statusStrip.Items[2].Text.Substring(7), "", false);
        }
        private void timer1000ms_Tick(object sender, EventArgs e)
        {
            this.statusStrip.Items[0].Text = "  " + DateTime.Now.ToString();
        }
        private void topButtons_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            Pen pen = new Pen(Color.SkyBlue);

            if (btn == topButtons[currentSelectedButton])
            {
                //       btn.FlatStyle = FlatStyle.Popup;
                topButtons[currentSelectedButton].FlatAppearance.BorderColor = Color.SkyBlue;
                btn.ForeColor = Color.SkyBlue;
            }
            else
            {
                //       btn.FlatStyle = FlatStyle.Standard;
                btn.ForeColor = Color.Black;
                topButtons[currentSelectedButton].FlatAppearance.BorderColor = Color.Black;
            }
        }
        #endregion
        #region 调整窗体中各元素大小
        private void FormFrm_Resize(object sender, EventArgs e)
        {
            FormFrm frm = sender as FormFrm;
            if (frm == null)
                return;
            
            double heightRate = (frm.Size.Height + 0.0) / frm.frmSize.Height;
            double widthRate = (frm.Size.Width + 0.0) / frm.frmSize.Width;
            if(heightRate>0.2&&widthRate>0.2&&heightRate<5&&widthRate<5)
         //       readjustLayout(frm, heightRate, widthRate);
            frm.frmSize.Width = frm.Width;
            frm.frmSize.Height = frm.Height;
        }
        public void readjustLayout(object container/*容器*/, double heightRate/*纵向缩放比例*/, double widthRate/*横向缩放比例*/)
        {
            Type type = container.GetType();
            if (type == typeof(FormFrm))
            {
                FormFrm frm = container as FormFrm;
                if (frm == null)
                    return;
                for (int i = 0; i < frm.Controls.Count;i++ )
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
                    if (ctrl.GetType() == typeof(Button))
                    {
                           continue;
                    }
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
                 //   ctrl.Location = new PointF(Convert.ToSingle(ctrl.Location.X * widthRate), Convert.ToSingle(ctrl.Location.Y * heightRate));
                    ctrl.Location = new Point(Convert.ToInt32(ctrl.Location.X * widthRate), Convert.ToInt32(ctrl.Location.Y * heightRate));
                    ctrl.Size = new Size(Convert.ToInt32(ctrl.Size.Width * widthRate), Convert.ToInt32(ctrl.Size.Height * heightRate));
                 //   readjustLayout(ctrl, heightRate, widthRate);
                }
            } 
        }
        #endregion

        #region 功能区按钮响应
        private void welcome_Click(object sender, EventArgs e)          //欢迎使用
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            showFunction fun = showFunction.welcome;
            switchFunction(ref fun);
        }
        private void mechineCtrl_Click(object sender, EventArgs e)     //设备控制
        {
       //     readConnectionConfig rcc = new readConnectionConfig();
        //    rcc.readConfig();
            showFunction fun = showFunction.mechineCtrl;
        //    addButtonToTop(object sender);
            switchFunction(ref fun);
        }
        private void RepertoireManage_Click(object sender, EventArgs e)           //剧目管理
        {
            showFunction fun = showFunction.repertoireManage;
            switchFunction(ref fun);
        }
        private void machineDemonstrate_Click(object sender, EventArgs e)         //设备演示
        {
            showFunction fun = showFunction.machineDemonstrate;
            switchFunction(ref fun);
        }

        private void synchroControl_Click(object sender, EventArgs e)            //同步控制
        {
            showFunction fun = showFunction.synchroControl;
            switchFunction(ref fun);
        }

        private void rockerControl_Click(object sender, EventArgs e)               //摇杆控制
        {
            //showFunction fun = showFunction.rockerControl;
          //  switchFunction(ref fun);
            if (rc == null)
            {
                rc = new StageMachineCtrlSys.rockerControl(this);
                rc.Show();
            }
            rc.Visible = true;
        }

        private void machineMonitor_Click(object sender, EventArgs e)                   //设备监控
        {
            showFunction fun = showFunction.machineMonitor;
            switchFunction(ref fun);
        }

        private void log_Click(object sender, EventArgs e)                            //日志记录
        {
            showFunction fun = showFunction.log;
            switchFunction(ref fun);
        }

        private void help_Click(object sender, EventArgs e)                                 //操作指南
        {
       //     showFunction fun = showFunction.help;
       //     switchFunction(ref fun);
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files\工大舞台\舞台控制系统\Help.pdf");
            }
            catch (Exception ee)
            {
            }
        }

        private void exit_Click(object sender, EventArgs e)                               //退出系统
        {
     //       showFunction fun = showFunction.exit;
      //      switchFunction(ref fun);
            this.Close();
        }
        private void addButtonToTop(ref showFunction which)
        {
            bool isFind = false;
            for (byte i = 0; i < buttonCount; i++)
            {
                if (topButtons[i].Name == which.ToString() + "Btn")
                {
                    isFind = true;
                    break;
                }
            }
            if (isFind == false)
            {
               
                topButtons[buttonCount] = new Button();
                topButtons[buttonCount].Parent = operation;
                topButtons[buttonCount].Size = topButtons[0].Size;
                topButtons[buttonCount].Location = new Point(topButtons[0].Location.X+(topButtons[0].Width+1)*buttonCount,topButtons[0].Location.Y);
                topButtons[buttonCount].Name = which.ToString() + "Btn";
                string text="";
                switch (which)
                {
                    case showFunction.mechineCtrl:                   //设备控制
                        topButtons[buttonCount].Click +=new EventHandler(mechineCtrl_Click);
                        text = "设备控制";
                        break;
                    case showFunction.repertoireManage:              //剧场管理
                        topButtons[buttonCount].Click += new EventHandler(RepertoireManage_Click);
                        text = "剧场管理";
                        break;
                    case showFunction.machineDemonstrate:            //设备演示
                        topButtons[buttonCount].Click += new EventHandler(machineDemonstrate_Click);
                        text = "设备演示";
                        break;
                    case showFunction.synchroControl:                //同步控制
                        topButtons[buttonCount].Click += new EventHandler(synchroControl_Click);
                        text = "同步控制";
                        break;
                    case showFunction.machineMonitor:                //设备监控
                        topButtons[buttonCount].Click += new EventHandler(machineMonitor_Click);
                        text = "设备监控";
                        break;
                    case showFunction.log:                           //日志记录
                        topButtons[buttonCount].Click += new EventHandler(log_Click);
                        text = "日志记录";
                        break;
                    default:
                        text = "";
                        break;
                }
                topButtons[buttonCount].Text = text;
                topButtons[buttonCount].Paint += new PaintEventHandler(topButtons_Paint);
                topButtons[buttonCount].BackColor = Color.Transparent;
            //    topButtons[buttonCount].FlatAppearance.BorderSize = 0;
                topButtons[buttonCount].FlatStyle = FlatStyle.Popup;
               
              //  topButtons[currentSelectedButton].FlatAppearance.BorderSize = 0;
                topButtons[buttonCount].BringToFront();
                topButtons[buttonCount].Show();
                buttonCount++;
            }
        }
       
        private void switchFunction(ref showFunction whichFunction)                       //按钮响应函数
        {
            foreach (Control ctrl in panel.Controls)
                ctrl.Visible = false;
            addButtonToTop(ref whichFunction);
            for (byte i = 0; i < buttonCount; i++)
            {
                if (whichFunction.ToString()== topButtons[i].Name||whichFunction.ToString() + "Btn" == topButtons[i].Name)
                {
                    topButtons[currentSelectedButton].Invalidate();
                    currentSelectedButton = i;
                    topButtons[currentSelectedButton].Invalidate();
                    
                    break;
                }
            }
            Rectangle rect = new Rectangle();//声明一个rect
            rect = Screen.PrimaryScreen.Bounds;//获取当前屏幕的分辨率
            int width, height;//声明宽度，高度
            width = int.Parse(rect.Width.ToString());
            height = int.Parse(rect.Height.ToString());//将高度宽度赋值
            this.operation.Width = width * 6 / 7;
            this.operation.Height = height * 74 / 100;
         //   this.panel.Width = width * 6/ 7;
            this.panel.Width = width;
            this.panel.Height = height * 74 / 100;
            switch (whichFunction)
            {

                case showFunction.mechineCtrl:                   //设备控制
                    if (mc == null)
                    {
                        mc = new StageMachineCtrlSys.mechineCtrl();
                        mc.Parent = panel;
                        mc.Location = new Point(1, 0);
                        mc.Size = new System.Drawing.Size(panel.Width - 4, panel.Height - 4);  
                        mc.Show();
                    }
                    mc.Visible = true;
                    break;
                case showFunction.repertoireManage:              //剧场管理
                    
                    if(mc!=null&&mc.Visible)
                        mc.Visible = false;
                    if (rm == null)
                    {
                        rm = new repertoireManage();
                        rm.Parent = panel;
                        rm.Location = new Point(1, 0);
                        rm.Size = new Size(panel.Width - 4, panel.Height - 4);
                        rm.Show();
                    }
                    rm.Visible = true;
                    break;
                case showFunction.machineDemonstrate:            //设备演示
                    if(mc!=null&&mc.Visible)
                        mc.Visible = false;
                    if (md == null)
                    {
                        md = new StageMachineCtrlSys.machineDemonstrate();
                        md.Parent = panel;
                        md.Location = new Point(1, 0);
                        md.Size = new Size(panel.Width - 4, panel.Height - 4);
                        md.Show();
                    }
                    md.Visible = true;
                    break;
                case showFunction.synchroControl:                //同步控制
                    if (mc != null && mc.Visible)
                        mc.Visible = false;
                    if (sc == null)
                    {
                        sc = new StageMachineCtrlSys.synchroControl();
                        sc.Parent = panel;
                        sc.Location = new Point(1, 0);
                        sc.Size = new Size(panel.Width - 4, panel.Height - 4);
                        sc.Show();
                    }
                    sc.Visible = true;
                    break;
              /*  case showFunction.rockerControl:                 //摇杆控制
                     if (rc == null)
                    {
                        rc = new StageMachineCtrlSys.rockerControl();
                        rc.Location = new Point(100, 100);
                        rc.Show();
                    }
                     rc.Visible = true;
                    break;*/
                case showFunction.machineMonitor:                //设备监控
                      if (mm == null)
                    {
                        mm = new machineMonitor();
                        mm.Parent = panel;
                        mm.Location = new Point(1, 0);
                        mm.Size = new Size(panel.Width - 4, panel.Height - 4);
                        mm.Show();
                    }
                     mm.Visible = true;
                    break;
                case showFunction.log:                           //日志记录
                    if (l == null)
                    {
                        l = new StageMachineCtrlSys.log();
                        l.Parent = panel;
                        l.Location = new Point(1, 0);
                        l.Size = new Size(panel.Width - 4, panel.Height - 4);
                        l.Show();
                    }
                     l.Visible = true;
                    break;
           /*     case showFunction.help:                          //操作指南
                    try
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\工大舞台\舞台控制系统\Help.pdf");
                    }
                    catch (Exception e)
                    {
                    }
                    break;*/
             /*   case showFunction.exit:                          //退出系统
                    this.Close();
                    break;*/
                case showFunction.welcome:                          //欢迎画面
                      if (w == null)
                    {
                        w = new StageMachineCtrlSys.welcome();
                        w.Parent = panel;
                        w.Location = new Point(0, 0);
                        w.Size = new Size(panel.Width , panel.Height);
                        w.Show();
                    }
                     w.Visible = true;
                    break;
                default :
                    break;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"http://baike.baidu.com/view/8066037.htm");
            }
            catch (Exception ee)
            {
            }
        }
        #endregion

        private void operation_Enter(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
    #region 程序使用的数据
    public enum showFunction
    {
        welcome,mechineCtrl, repertoireManage, machineDemonstrate, synchroControl, rockerControl, machineMonitor,log,help,exit
    }
    public class resizeLayout
    {
        public void readjustLayout(object container/*容器*/, double heightRate/*纵向缩放比例*/, double widthRate/*横向缩放比例*/)
        {
            Type type = container.GetType();
            if (type == typeof(FormFrm))
            {
                FormFrm frm = container as FormFrm;
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
            else if (type == typeof(frontSuspenderInMC))
            {
                frontSuspenderInMC frm = container as frontSuspenderInMC;
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
            else if (type == typeof(calcInfs))
            {
                calcInfs frm = container as calcInfs;
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
            else if (type == typeof(repetoreInRM))
            {
                repetoreInRM frm = container as repetoreInRM;
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
            else if (type == typeof(sceneInRM))
            {
                sceneInRM frm = container as sceneInRM;
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
            else if (type == typeof(trackInRM))
            {
                trackInRM frm = container as trackInRM;
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
    }
#endregion
}
