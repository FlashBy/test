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
    public partial class sceneInRM : UserControl
    {
        string repetore;
        string scene;
        public sceneInRM()
        {
            InitializeComponent();
        }
        public void selectedName(ref LinkedList<string> name)
        {
            repetoreName.Text = name.ElementAt(0);
            sceneName.Text = name.ElementAt(1);
        }
        public void equimentsList(ref LinkedList<equimentInfo> list)
        {
            listView.Items.Clear();
            foreach (equimentInfo equiment in list)
            {
                ListViewItem item = new ListViewItem(equiment._NO.ToString(), Convert.ToInt32(equiment._NO));
                item.SubItems.Add(equiment.Name);
                listView.Items.Add(item);
            }
        }

        private void addEquipment_Click(object sender, EventArgs e)
        {

        }
    }
}
