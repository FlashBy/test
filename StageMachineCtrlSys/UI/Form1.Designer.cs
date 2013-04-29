namespace StageMachineCtrlSys
{
    partial class FormFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrm));
            this.function = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.machineMonitor = new System.Windows.Forms.Button();
            this.rockerControl = new System.Windows.Forms.Button();
            this.machineDemonstrate = new System.Windows.Forms.Button();
            this.synchroControl = new System.Windows.Forms.Button();
            this.RepertoireManage = new System.Windows.Forms.Button();
            this.mechineCtrl = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.GroupBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.welcomeBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.timer1000ms = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.user = new System.Windows.Forms.ToolStripStatusLabel();
            this.seperater = new System.Windows.Forms.ToolStripStatusLabel();
            this.function.SuspendLayout();
            this.operation.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // function
            // 
            this.function.Controls.Add(this.exit);
            this.function.Controls.Add(this.help);
            this.function.Controls.Add(this.log);
            this.function.Controls.Add(this.machineMonitor);
            this.function.Controls.Add(this.rockerControl);
            this.function.Controls.Add(this.machineDemonstrate);
            this.function.Controls.Add(this.synchroControl);
            this.function.Controls.Add(this.RepertoireManage);
            this.function.Controls.Add(this.mechineCtrl);
            this.function.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.function.Location = new System.Drawing.Point(7, 5);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(125, 570);
            this.function.TabIndex = 0;
            this.function.TabStop = false;
            this.function.Text = "  功  能";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit.Location = new System.Drawing.Point(6, 501);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(109, 57);
            this.exit.TabIndex = 8;
            this.exit.Text = "退出系统";
            this.exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.help.Location = new System.Drawing.Point(5, 441);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(109, 57);
            this.help.TabIndex = 7;
            this.help.Text = "操作指南";
            this.help.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log.Image = ((System.Drawing.Image)(resources.GetObject("log.Image")));
            this.log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log.Location = new System.Drawing.Point(6, 381);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(109, 57);
            this.log.TabIndex = 6;
            this.log.Text = "日志记录";
            this.log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // machineMonitor
            // 
            this.machineMonitor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.machineMonitor.Image = ((System.Drawing.Image)(resources.GetObject("machineMonitor.Image")));
            this.machineMonitor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.machineMonitor.Location = new System.Drawing.Point(6, 321);
            this.machineMonitor.Name = "machineMonitor";
            this.machineMonitor.Size = new System.Drawing.Size(109, 57);
            this.machineMonitor.TabIndex = 5;
            this.machineMonitor.Text = "设备监控";
            this.machineMonitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.machineMonitor.UseVisualStyleBackColor = true;
            this.machineMonitor.Click += new System.EventHandler(this.machineMonitor_Click);
            // 
            // rockerControl
            // 
            this.rockerControl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rockerControl.Image = ((System.Drawing.Image)(resources.GetObject("rockerControl.Image")));
            this.rockerControl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rockerControl.Location = new System.Drawing.Point(6, 261);
            this.rockerControl.Name = "rockerControl";
            this.rockerControl.Size = new System.Drawing.Size(109, 57);
            this.rockerControl.TabIndex = 4;
            this.rockerControl.Text = "摇杆控制";
            this.rockerControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rockerControl.UseVisualStyleBackColor = true;
            this.rockerControl.Click += new System.EventHandler(this.rockerControl_Click);
            // 
            // machineDemonstrate
            // 
            this.machineDemonstrate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.machineDemonstrate.Image = ((System.Drawing.Image)(resources.GetObject("machineDemonstrate.Image")));
            this.machineDemonstrate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.machineDemonstrate.Location = new System.Drawing.Point(6, 141);
            this.machineDemonstrate.Name = "machineDemonstrate";
            this.machineDemonstrate.Size = new System.Drawing.Size(109, 57);
            this.machineDemonstrate.TabIndex = 3;
            this.machineDemonstrate.Text = "设备演示";
            this.machineDemonstrate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.machineDemonstrate.UseVisualStyleBackColor = true;
            this.machineDemonstrate.Click += new System.EventHandler(this.machineDemonstrate_Click);
            // 
            // synchroControl
            // 
            this.synchroControl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.synchroControl.Image = ((System.Drawing.Image)(resources.GetObject("synchroControl.Image")));
            this.synchroControl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.synchroControl.Location = new System.Drawing.Point(6, 201);
            this.synchroControl.Name = "synchroControl";
            this.synchroControl.Size = new System.Drawing.Size(109, 57);
            this.synchroControl.TabIndex = 2;
            this.synchroControl.Text = "同步控制";
            this.synchroControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.synchroControl.UseVisualStyleBackColor = true;
            this.synchroControl.Click += new System.EventHandler(this.synchroControl_Click);
            // 
            // RepertoireManage
            // 
            this.RepertoireManage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RepertoireManage.Image = ((System.Drawing.Image)(resources.GetObject("RepertoireManage.Image")));
            this.RepertoireManage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RepertoireManage.Location = new System.Drawing.Point(6, 81);
            this.RepertoireManage.Name = "RepertoireManage";
            this.RepertoireManage.Size = new System.Drawing.Size(109, 57);
            this.RepertoireManage.TabIndex = 1;
            this.RepertoireManage.Text = "剧目管理";
            this.RepertoireManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RepertoireManage.UseVisualStyleBackColor = true;
            this.RepertoireManage.Click += new System.EventHandler(this.RepertoireManage_Click);
            // 
            // mechineCtrl
            // 
            this.mechineCtrl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mechineCtrl.Image = ((System.Drawing.Image)(resources.GetObject("mechineCtrl.Image")));
            this.mechineCtrl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mechineCtrl.Location = new System.Drawing.Point(6, 21);
            this.mechineCtrl.Name = "mechineCtrl";
            this.mechineCtrl.Size = new System.Drawing.Size(109, 57);
            this.mechineCtrl.TabIndex = 0;
            this.mechineCtrl.Text = "设备控制";
            this.mechineCtrl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mechineCtrl.UseVisualStyleBackColor = false;
            this.mechineCtrl.Click += new System.EventHandler(this.mechineCtrl_Click);
            // 
            // operation
            // 
            this.operation.Controls.Add(this.linkLabel);
            this.operation.Controls.Add(this.welcomeBtn);
            this.operation.Controls.Add(this.panel);
            this.operation.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.operation.Location = new System.Drawing.Point(142, 5);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(1035, 570);
            this.operation.TabIndex = 2;
            this.operation.TabStop = false;
            this.operation.Text = "操 作";
            this.operation.Enter += new System.EventHandler(this.operation_Enter);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(754, 21);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(275, 19);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "兰州达盟电子科技有限责任公司";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // welcomeBtn
            // 
            this.welcomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeBtn.Location = new System.Drawing.Point(6, 19);
            this.welcomeBtn.Name = "welcomeBtn";
            this.welcomeBtn.Size = new System.Drawing.Size(99, 26);
            this.welcomeBtn.TabIndex = 1;
            this.welcomeBtn.Text = "欢迎使用";
            this.welcomeBtn.UseVisualStyleBackColor = true;
            this.welcomeBtn.Click += new System.EventHandler(this.welcome_Click);
            this.welcomeBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.topButtons_Paint);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Location = new System.Drawing.Point(6, 51);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 409);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // timer1000ms
            // 
            this.timer1000ms.Interval = 1000;
            this.timer1000ms.Tick += new System.EventHandler(this.timer1000ms_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusTime,
            this.time,
            this.user,
            this.seperater});
            this.statusStrip.Location = new System.Drawing.Point(0, 590);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1202, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // StripStatusTime
            // 
            this.StripStatusTime.Name = "StripStatusTime";
            this.StripStatusTime.Size = new System.Drawing.Size(0, 17);
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(11, 17);
            this.time.Text = "|";
            // 
            // user
            // 
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(44, 17);
            this.user.Text = "未登录";
            // 
            // seperater
            // 
            this.seperater.Name = "seperater";
            this.seperater.Size = new System.Drawing.Size(11, 17);
            this.seperater.Text = "|";
            // 
            // FormFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1202, 612);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.function);
            this.Name = "FormFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "舞台机械控制系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFrm_FormClosing);
            this.Load += new System.EventHandler(this.FormFrm_Load);
            this.Shown += new System.EventHandler(this.FormFrm_Shown);
            this.Resize += new System.EventHandler(this.FormFrm_Resize);
            this.function.ResumeLayout(false);
            this.operation.ResumeLayout(false);
            this.operation.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox function;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button machineMonitor;
        private System.Windows.Forms.Button rockerControl;
        private System.Windows.Forms.Button machineDemonstrate;
        private System.Windows.Forms.Button synchroControl;
        private System.Windows.Forms.Button RepertoireManage;
        private System.Windows.Forms.Button mechineCtrl;
        private System.Windows.Forms.GroupBox operation;
        private System.Windows.Forms.Timer timer1000ms;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.ToolStripStatusLabel user;
        private System.Windows.Forms.ToolStripStatusLabel seperater;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusTime;
        private System.Windows.Forms.Button welcomeBtn;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}

