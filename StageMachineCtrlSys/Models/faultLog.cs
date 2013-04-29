using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageMachineCtrlSys.Models
{
    class faultLog
    {
        public DateTime time { get; set; }
        public uint deviceNo { get; set; }
        public string content { get; set; }
        public short type { get; set; }
    }
}
