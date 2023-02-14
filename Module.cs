using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_updated
{
    //super class for all modules
    class Module
    {
        private static double currentValue = 0;
        
        //method to perform computations based on selected module
        public virtual void compute() { }
     

        public Module() { }

        
        public static double getCurrentvalue()
        {
            return currentValue;
        }

        
        public static void setCurrentValue(double x)
        {
            currentValue = x;
        }
    }
}
