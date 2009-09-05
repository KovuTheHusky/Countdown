using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown.Settings
{
    [Serializable]
    public class Startup
    {
        private StartupMethod method = StartupMethod.Disabled;

        public StartupMethod Method
        {
            get { return method; }
            set { method = value; }
        }
    }
}