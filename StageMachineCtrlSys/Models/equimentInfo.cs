using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StageMachineCtrlSys.Models
{
    #region 剧目数据类
    public class repertoreExample                                                         //剧目测试类
    {
       private  LinkedList<repertore> repertores = new LinkedList<repertore>();
       public LinkedList<repertore> Repertores
       {
           get
           {
               return repertores;
           }
           set
           {
               repertores = value;
           }
       }
       public void init()
       {
           repertore r = new repertore("花儿与少年");         //根节点 
           scene s = new scene("月下山林");                  //子节点
           track t = new track("3#前舞台吊杆");              //子子节点
           s.Tracks.AddLast(t);
           r.Sences.AddLast(s);
           repertores.AddLast(r);
           s = new scene("雪山草原");
           t = new track("19#前舞台吊杆");
           s.Tracks.AddLast(t);
           t = new track("33#前舞台吊杆");
           s.Tracks.AddLast(t);
           t = new track("43#前舞台吊杆");
           s.Tracks.AddLast(t);
           r.Sences.AddLast(s);

           r = new repertore("战斗歌舞团");
           s = new scene("3号和大幕降");
           t = new track("前舞台吊杆");
           s.Tracks.AddLast(t);
           t = new track("大幕升降");
           s.Tracks.AddLast(t);
           r.Sences.AddLast(s);
           repertores.AddLast(r);
           s = new scene("大幕升");
           t = new track("大幕升降");
           s.Tracks.AddLast(t);
           r.Sences.AddLast(s);

           r = new repertore("丝路花雨");
           s = new scene("大佛↓");
           t = new track("40#前舞台吊杆");
           s.Tracks.AddLast(t);
           r.Sences.AddLast(s);
           repertores.AddLast(r);
           s = new scene("序大幕↓");
           t = new track("42#前舞台吊杆");
           s.Tracks.AddLast(t);
           r.Sences.AddLast(s);
       }
    }
    public class repertore
    {
        public repertore(string str)
        {
            name = str;
    }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        LinkedList<scene> sences = new LinkedList<scene>();
        public LinkedList<scene> Sences
        {
            get
            {
                return sences;
            }
            set
            {
                sences = value;
            }
        }
    }                      //剧目集
    public class scene
    {
        public scene(string str)
        {
            name = str;
    }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        LinkedList<track> tracks = new LinkedList<track>();
        public LinkedList<track> Tracks
        {
            get
            {
                return tracks;
            }
            set
            {
                tracks = value;
            }
        }

    }                          //场景
    public class track
    {
        public track(string str)
        {
            name = str;
    }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }                          //场次
    #endregion 

    public class equimentInfo
    {
        private uint NO;
        public uint _NO
        {
            get
            {
                return NO;
            }
            set
            {
                NO = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private uint presetSpeed;
        public uint PresetSpeed
        {
            get
            {
                return presetSpeed;
            }
            set
            {
                presetSpeed = value;
            }
        }
        private uint presetPosition;
        public uint PresetPosition
        {
            get
            {
                return presetPosition;
            }
            set
            {
                presetPosition = value;
            }
        }
        private uint currentSpeed;
        public uint CurrentSpeed
        {
            get
            {
                return currentSpeed;
            }
            set
            {
                currentSpeed = value;
            }
        }
        private uint currentPosition;
        public uint CurrentPosition
        {
            get
            {
                return currentPosition;
            }
            set
            {
                currentPosition = value;
            }
        }
        private string status;
        public string  Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        private uint delay;
        public uint Delay
        {
            get
            {
                return delay;
            }
            set
            {
                delay = value;
            }
        }
    }
}
