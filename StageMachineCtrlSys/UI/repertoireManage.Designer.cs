namespace StageMachineCtrlSys
{
    partial class repertoireManage
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repertoireManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downloadScene = new System.Windows.Forms.Button();
            this.uploadScene = new System.Windows.Forms.Button();
            this.stopScene = new System.Windows.Forms.Button();
            this.runScene = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downloadScene);
            this.groupBox1.Controls.Add(this.uploadScene);
            this.groupBox1.Controls.Add(this.stopScene);
            this.groupBox1.Controls.Add(this.runScene);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // downloadScene
            // 
            this.downloadScene.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.downloadScene.Image = ((System.Drawing.Image)(resources.GetObject("downloadScene.Image")));
            this.downloadScene.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downloadScene.Location = new System.Drawing.Point(245, 12);
            this.downloadScene.Name = "downloadScene";
            this.downloadScene.Size = new System.Drawing.Size(80, 73);
            this.downloadScene.TabIndex = 13;
            this.downloadScene.Text = "下载场景";
            this.downloadScene.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.downloadScene.UseVisualStyleBackColor = true;
            // 
            // uploadScene
            // 
            this.uploadScene.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploadScene.Image = ((System.Drawing.Image)(resources.GetObject("uploadScene.Image")));
            this.uploadScene.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uploadScene.Location = new System.Drawing.Point(164, 12);
            this.uploadScene.Name = "uploadScene";
            this.uploadScene.Size = new System.Drawing.Size(80, 73);
            this.uploadScene.TabIndex = 12;
            this.uploadScene.Text = "上传场景";
            this.uploadScene.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uploadScene.UseVisualStyleBackColor = true;
            // 
            // stopScene
            // 
            this.stopScene.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopScene.Image = ((System.Drawing.Image)(resources.GetObject("stopScene.Image")));
            this.stopScene.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stopScene.Location = new System.Drawing.Point(83, 12);
            this.stopScene.Name = "stopScene";
            this.stopScene.Size = new System.Drawing.Size(80, 73);
            this.stopScene.TabIndex = 11;
            this.stopScene.Text = "停止场景";
            this.stopScene.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopScene.UseVisualStyleBackColor = true;
            // 
            // runScene
            // 
            this.runScene.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.runScene.Image = ((System.Drawing.Image)(resources.GetObject("runScene.Image")));
            this.runScene.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.runScene.Location = new System.Drawing.Point(2, 12);
            this.runScene.Name = "runScene";
            this.runScene.Size = new System.Drawing.Size(80, 73);
            this.runScene.TabIndex = 10;
            this.runScene.Text = "运行场景";
            this.runScene.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.runScene.UseVisualStyleBackColor = true;
            this.runScene.Click += new System.EventHandler(this.runScene_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Control;
            this.treeView.Location = new System.Drawing.Point(4, 96);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(330, 408);
            this.treeView.TabIndex = 5;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 518);
            this.panel2.TabIndex = 1;
            // 
            // repertoireManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "repertoireManage";
            this.Size = new System.Drawing.Size(1114, 518);
            this.Load += new System.EventHandler(this.repertoireManage_Load);
            this.Resize += new System.EventHandler(this.repertoireManage_Resize);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button downloadScene;
        private System.Windows.Forms.Button uploadScene;
        private System.Windows.Forms.Button stopScene;
        private System.Windows.Forms.Button runScene;
    }
}
