using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageMachineCtrlSys.Models
{
    
    class realTime
    {
        const uint MAX_DGJDQ = 152;
        const uint MAX_TMJDQ = 170;
        public DateTime time { get; set; }
        /********************** 升降台 ****************************************/ 
        public float SJTPos1 { get; set; }
        public float SJTSpeed1 { get; set; }
        public float SJTPos2 { get; set; }
        public float SJTSpeed2 { get; set; }
        public float SJTPos3 { get; set; }
        public float SJTSpeed3 { get; set; }
        public float SJTPos4 { get; set; }
        public float SJTSpeed4 { get; set; }
        public float SJTPos5 { get; set; }
        public float SJTSpeed5 { get; set; }
        public float SJTPos6 { get; set; }
        public float SJTSpeed6 { get; set; }
        /********************** 车台 ******************************************/
        public float CTPos1 { get; set; }
        public float CTSpeed1 { get; set; }
        public float CTPos2 { get; set; }
        public float CTSpeed2 { get; set; }
        public float CTPos3 { get; set; }
        public float CTSpeed3 { get; set; }
        public float CTPos4 { get; set; }
        public float CTSpeed4 { get; set; }
        public float CTPos5 { get; set; }
        public float CTSpeed5 { get; set; }
        public float CTPos6 { get; set; }
        public float CTSpeed6 { get; set; }
        /********************** 车载转台 ****************************************/
        public float CZZTPos1 { get; set; }
        public float CZZTSpeed1 { get; set; }
        /********************** 舞台台面继电器 **********************************/
        protected bool[] TMJDQ = new bool[MAX_DGJDQ];
        /********************** 舞台吊杆继电器 ***********************************/
        protected bool[] DGJDQ = new bool[MAX_TMJDQ];
        public bool[] getTMJDQ(uint firstIndex = 0, uint lastIndex = MAX_DGJDQ-1)
        {
            
            if(firstIndex<=lastIndex)
            {
                bool[] jdq = new bool[lastIndex - firstIndex];
                for (uint index = firstIndex; index < lastIndex; index++)
                    if (this.TMJDQ[index] != null)
                        jdq[index + firstIndex] = this.TMJDQ[index];
                return jdq;
            }
            return null;
        }
        public bool[] getDGJDQ(uint firstIndex = 0, uint lastIndex = MAX_TMJDQ-1)
        {
            if (firstIndex <= lastIndex)
            {
                bool[] jdq = new bool[lastIndex - firstIndex];
                for (uint index = firstIndex; index < lastIndex; index++)
                    if (this.DGJDQ[index] != null)
                        jdq[index + firstIndex] = this.DGJDQ[index];
                return jdq;
            }
            return null;
        }
        public void setTMJDQ(ref bool[] jdq, uint firstIndex = 0, uint lastIndex = MAX_DGJDQ-1)
        {
            if (firstIndex <= lastIndex)
            {
                for (uint index = firstIndex; index < lastIndex && index + firstIndex < this.TMJDQ.GetLength(0); index++)
                    if (jdq[index] != null)
                        this.TMJDQ[index+firstIndex] = jdq[index];
            }
        }
        public void setDGJDQ(ref bool[] jdq, uint firstIndex = 0, uint lastIndex = MAX_TMJDQ-1)
        {
            if (firstIndex <= lastIndex)
            {
                for (uint index = firstIndex; index < lastIndex && index + firstIndex < this.DGJDQ.GetLength(0); index++)
                    if (jdq[index] != null)
                        this.DGJDQ[index + firstIndex] = jdq[index];
            }
        }
    }
}
