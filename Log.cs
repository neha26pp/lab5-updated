using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab5_updated
{
    //computes the log of current value
    class Log: Module
    {
        public Log() {
            this.compute();
        }

        public override void compute()
        {
            double log = Math.Log(getCurrentvalue());
            //Debug.WriteLine("Log = " + log);
            setCurrentValue(log);
        }


    }
}
