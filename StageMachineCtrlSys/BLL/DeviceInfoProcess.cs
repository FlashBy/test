using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StageMachineCtrlSys.DAL;
using StageMachineCtrlSys.Models;

namespace StageMachineCtrlSys.BLL
{
    class DeviceInfoProcess
    {
        public string getSelectSQL(ref string table, ref string timeStart, ref string timeEnd)
        {
            string strSQL = "Select * from ";
            strSQL += table;
            strSQL += " where jddate between #";
            strSQL += timeStart;
            strSQL += "# and  #";
            strSQL += timeEnd;
            strSQL += "# ";
            return strSQL;
        }
        public void insertHistoryData(ref string table, ref realTime dt)
        {
            bool [] dgjdq=dt.getDGJDQ();
            bool[] tmjdq = dt.getTMJDQ();
            string strCommand = "Insert into ";
            strCommand += table;
            strCommand += " values('";
            strCommand += DateTime.Now.ToString();
            /******台面电机、吊杆电机数据*********************/
            #region           
            strCommand += "','";
            strCommand += dt.CTSpeed6;
            strCommand += "','";
            strCommand += dt.CTPos6;
            strCommand += "','";
            strCommand += dt.CTSpeed5;
            strCommand += "','";
            strCommand += dt.CTPos5;
            strCommand += "','";
            strCommand += dt.CTSpeed4;
            strCommand += "','";
            strCommand += dt.CTPos4;
            strCommand += "','";
            strCommand += dt.CTSpeed3;
            strCommand += "','";
            strCommand += dt.CTPos3;
            strCommand += "','";
            strCommand += dt.CTSpeed2;
            strCommand += "','";
            strCommand += dt.CTPos2;
            strCommand += "','";
            strCommand += dt.CTSpeed1;
            strCommand += "','";
            strCommand += dt.CTPos1;
            strCommand += "','";
            strCommand += dt.CTSpeed6;
            strCommand += "','";
            strCommand += dt.CTPos6;
            #endregion                       
            /******吊杆继电器数据*********************/
            for (int i = 0; i < dgjdq.GetLength(0); i++)
            {
                strCommand += "','";
                strCommand += dgjdq[i];
            }
            /******台面继电器数据*********************/
            for (int i = 0; i < tmjdq.GetLength(0); i++)
            {
                strCommand += "','";
                strCommand += tmjdq[i];
            }
            strCommand += "')";
            DBHelper.ExecuteNonQuery(strCommand);      //执行插入语句
        }
    }
}
