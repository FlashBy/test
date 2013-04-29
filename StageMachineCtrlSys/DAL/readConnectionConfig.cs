using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StageMachineCtrlSys.Models;
using System.Xml;

namespace StageMachineCtrlSys.DAL
{
    class readConnectionConfig
    {
        protected string xmlPathName()
        {
            string CurrentExePath = System.Windows.Forms.Application.StartupPath;
            string xmlPath = CurrentExePath;
            string[] xmlPathArray = new string[20];
            char[] splite = new char[1];
            splite[0] = '\\';
            xmlPathArray = xmlPath.Split(splite, 20);
            xmlPath = "";
            for (int k = xmlPathArray.GetUpperBound(0) - 1; k >= 0; k--)
            {
                if (k == 0 && xmlPathArray[k] != "StageMachineCtrlSys")
                    System.Windows.Forms.Application.Exit();
                else if (xmlPathArray[k] == "StageMachineCtrlSys")
                {
                    for (int i = 0; i <= k; i++)
                    {
                        xmlPath += xmlPathArray[i] + "\\";
                    }
                    break;
                }
            }
            xmlPath += "connectionConfig.xml";
            return xmlPath;
        }
        protected element[] getElements(XmlDocument doc, SubSysName enumName)
        {
            string name = enumName.ToString();
            XmlNode root = doc.SelectSingleNode("SMCS");//查找<SMCS>
            XmlNode contents = root.SelectSingleNode("contents");
            XmlNode nodes = contents.SelectSingleNode(name).SelectSingleNode("contents");
            if (nodes.ChildNodes.Count < 0)
                return null;
            element[] elements = new element[nodes.ChildNodes.Count];
            for (int i = 0; i < nodes.ChildNodes.Count; i++)
            {
                elements[i] = new element();
                elements[i].Remark = nodes.ChildNodes[i].Attributes.GetNamedItem("remark").Value;
                elements[i].Type = nodes.ChildNodes[i].Attributes.GetNamedItem("type").Value;
                elements[i].No = nodes.ChildNodes[i].Attributes.GetNamedItem("No.").Value;
                elements[i].Address = nodes.ChildNodes[i].Attributes.GetNamedItem("address").Value;
            } 
            return elements;
        }
        public connectionConfig readConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            string xmlPath = xmlPathName();
            xmlDoc.Load(xmlPath);
            connectionConfig cc = new connectionConfig();
            cc.Curtains = getElements(xmlDoc, SubSysName.Curtains);
            cc.Mesas = getElements(xmlDoc, SubSysName.Mesas);
            cc.Lights = getElements(xmlDoc, SubSysName.Lights);
            return cc;
        }
        protected enum SubSysName
        {
            Curtains, Mesas, Lights
        }
    }
}
