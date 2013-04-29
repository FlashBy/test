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
    public partial class repetoreInRM : UserControl
    {
        Point rmLocation = new Point(0, 0);
        Size rmSize = new Size();
        public repetoreInRM()
        {
            InitializeComponent();
            
         //   resizeLayout afterResize = new resizeLayout();
          //  double heightRate = 0.75, widthRate = 0.58;
         //   afterResize.readjustLayout(this, heightRate, widthRate);
         //   rmLocation = this.Location;
         //   rmSize = this.Size;
        }
        public void selectedName(ref LinkedList<string> name)
        {
            repetoreName.Text = name.ElementAt(0) ;
        }

        private void repetoreInRM_Resize(object sender, EventArgs e)
        {
            double heightRate = (this.Size.Height + 0.0) / this.rmSize.Height;
            double widthRate = (this.Size.Width + 0.0) / this.rmSize.Width;
            if (double.IsInfinity(heightRate) || double.IsInfinity(widthRate))
            {
                this.rmSize = this.Size;
                this.rmLocation = this.Location;
                return;
            }
            resizeLayout afterResize = new resizeLayout();
            afterResize.readjustLayout(sender, heightRate, widthRate);
            this.rmSize = this.Size;
            this.rmLocation = this.Location;
        }
    }
}
