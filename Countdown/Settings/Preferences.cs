using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown.Settings
{
    [Serializable]
    public class Preferences
    {
        private Cycle cycle = new Cycle();
        private Startup startup = new Startup();

        public Cycle Cycle
        {
            get { return cycle; }
            set { cycle = value; }
        }

        public Startup Startup
        {
            get { return startup; }
            set { startup = value; }
        }
    }
}