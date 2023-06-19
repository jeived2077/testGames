using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class GAME
    {
        
        public int money {
            get
            {
                return money;
            }
            set
            {
                money = value;
            } 
           
        }
        public int Points
        {
            get
            {
                return Points;
            }
            set
            {
                Points = value;
            }
        }
        public string Status
        {
            get
            {
                return Status;
            }
            set { Status = value; }
        }
        public string mood
        {
            get
            {
                return mood;
            }
            set { mood = value; }
        }
        public string system
        {
            get
            {
                return system;
            }
            set { system = value; }
        }
        public string antivirus
        {
            get
            {
                return antivirus;
            }
            set { antivirus = value; }
        }
    }
}
