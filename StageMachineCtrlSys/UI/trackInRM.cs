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
    public partial class trackInRM : UserControl
    {
        public trackInRM()
        {
            InitializeComponent();
        }
        public void selectedName(ref LinkedList<string> name)
        {
            repetoreName.Text = name.ElementAt(0);
            sceneName.Text = name.ElementAt(1);
            equipmentName.Text = name.ElementAt(2);
        }
    }
}
