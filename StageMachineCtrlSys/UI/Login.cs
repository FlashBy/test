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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            comboBox.Invalidate();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        public string getCurrentUserName()
        {
            return comboBox.Text;
        }
    }
}
