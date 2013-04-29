using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StageMachineCtrlSys.Models;


namespace StageMachineCtrlSys
{
    public partial class repertoireManage : UserControl
    {
        public double resizeRateX = 1;
        public double resizeRateY = 1;
        Point rmLocation = new Point(0, 0);
        Size rmSize = new Size();
        repetoreInRM r = new repetoreInRM();
        sceneInRM s = new sceneInRM();
        trackInRM t = new trackInRM();
        public repertoireManage()
        {
            InitializeComponent();
            resizeLayout afterResize = new resizeLayout();
            panel1.Width =  Convert.ToInt32(this.Width * 0.35);
           // afterResize.readjustLayout(this.panel1, 0.63, 0.55);
           // afterResize.readjustLayout(this.panel2, 0.63, 0.80);
            panel2.Location = new Point((this.Location.X + panel1.Width)*48/100, panel1.Location.Y);
            panel2.Width = Convert.ToInt32(this.Width * 0.6);
            rmLocation = this.Location;
            rmSize = this.Size;
            afterResize.readjustLayout(this.panel1, 0.63, 0.55);
             afterResize.readjustLayout(this.panel2, 0.63, 0.55);
           // double heightRate = 0.75, widthRate = 0.58;
          //  afterResize.readjustLayout(r, heightRate, widthRate);
           // afterResize.readjustLayout(s, heightRate, widthRate);
          //  afterResize.readjustLayout(t, heightRate, widthRate);

        }

        private void repertoireManage_Load(object sender, EventArgs e)
        {
            treeViewInit();
        }
        private void treeViewInit()
        {
            repertoreExample re = new repertoreExample();
            re.init();
            for (int i = 0; i < re.Repertores.Count; i++)
            {
                    treeView.Nodes.Add(re.Repertores.ElementAt(i).Name);
                    for (int ii = 0; ii < re.Repertores.ElementAt(i).Sences.Count; ii++)
                    {
                        treeView.Nodes[i].Nodes.Add(re.Repertores.ElementAt(i).Sences.ElementAt(ii).Name);
                        for (int iii = 0; iii < re.Repertores.ElementAt(i).Sences.ElementAt(ii).Tracks.Count; iii++)
                        {
                            treeView.Nodes[i].Nodes[ii].Nodes.Add(re.Repertores.ElementAt(i).Sences.ElementAt(ii).Tracks.ElementAt(iii).Name);
                        }
                    }
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView view = sender as TreeView;
            if (view == null)
                return;
            TreeNode node = e.Node;
            if (node == null)
                return;
            LinkedList<string> path = new LinkedList<string>();
            LinkedList<equimentInfo> lists = new LinkedList<equimentInfo>();
            for (int i = 0; i < 3; i++)
            {
                path.AddFirst(node.Text);
                node = node.Parent;
                if (node == null)
                    break;
            }
            switch (path.Count)
            {
                case 1:
                    r.Parent = panel2;
                    r.Location = new Point(1, 1);
                    r.Width = this.Width *62/100;
                    r.selectedName(ref path);
                    t.Visible = false;
                    s.Visible = false;
                    r.Visible = true;
                    break;
                case 2:
                    uint i = 1;
                    foreach (TreeNode sub in e.Node.Nodes)
                    {
                        equimentInfo ei = new equimentInfo();
                        ei._NO = i++;
                        ei.Name = sub.Text;
                        lists.AddLast(ei);
                    }
                    s.Parent = panel2;
                    s.Location = new Point(1, 1);
                    s.Width = this.Width * 62 / 100;
                    s.selectedName(ref path);
                    s.equimentsList(ref lists);
                    t.Visible = false;
                    s.Visible = true;
                    r.Visible = false;
                    break;
                case 3:
                    t.Parent = panel2;
                    s.Location = new Point(1, 1);
                    r.Width = this.Width * 62 / 100;
                    t.selectedName(ref path);
                    t.Visible = true;
                    s.Visible = false;
                    r.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void repertoireManage_Resize(object sender, EventArgs e)
        {
            double heightRate = (this.Size.Height + 0.0) / this.rmSize.Height;
            double widthRate = (this.Size.Width + 0.0) / this.rmSize.Width;
            if (double.IsInfinity(heightRate) || double.IsInfinity(widthRate))
            {
                return;
            }
            resizeLayout afterResize = new resizeLayout();
            afterResize.readjustLayout(sender, heightRate, widthRate);
            this.rmSize = this.Size;
            this.rmLocation = this.Location;
        }

        private void runScene_Click(object sender, EventArgs e)
        {

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
