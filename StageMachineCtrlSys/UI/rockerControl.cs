using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StageMachineCtrlSys
{
    public partial class rockerControl : Form
    {
        FormFrm frm;
        public rockerControl(FormFrm frmWnd)
        {
            InitializeComponent();
            frm = frmWnd;
        }

        private void addmachineLeft_Click(object sender, EventArgs e)
        {

        }

        private void rockerControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Rc = null;
        }
    }
}
