using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StageMachineCtrlSys
{
    public partial class log : UserControl
    {
        public log()
        {
            InitializeComponent();
        }

        private void log_Load(object sender, EventArgs e)
        {
            classification.SelectedIndex = 0;
            LinkedList<ListViewItem> list;
            getLoginInfo(out list);
            foreach (ListViewItem item in list)
            {
                listView.Items.Add(item);
            }
            CountOfShow.Text = list.Count.ToString();
            Invalidate();
        }
        private void getLoginInfo(out LinkedList<ListViewItem> list)
        {
            list = new LinkedList<ListViewItem>();
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["StageMachineCtrlSys.Properties.Settings.DB_SMCSConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "Users");
                connection.Open();
                string strCommand = "SELECT [user], password, time, login FROM dbo.Users";
                SqlCommand command = new SqlCommand(strCommand,
                   connection);
                command.CommandType = CommandType.Text;
                // Set the SqlDataAdapter's SelectCommand.
                adapter.SelectCommand = command;
                // Fill the DataSet.
                DataSet dataSet = new DataSet("Users");
                adapter.Fill(dataSet);
                connection.Close();
                int iCount=1;
                foreach (DataRow row in dataSet.Tables["Users"].Rows)
                {
                    ListViewItem item1 = new ListViewItem(iCount++.ToString(), 0);
                    item1.SubItems.Add(row["time"].ToString());
                    item1.SubItems.Add(row["user"].ToString());
                    if(row["login"].ToString()!="")
                        item1.SubItems.Add((Convert.ToBoolean(row["login"])==true?"登录":"退出")+"系统");
                    else
                        item1.SubItems.Add("");
                    list.AddLast(item1);
                }   
            }
        }
        private void OK_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
