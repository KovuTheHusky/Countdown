using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown.Settings
{
    [Serializable]
    public class Cycle
    {
        private bool enabled = true;
        private int interval = 10000;

        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
    }
}