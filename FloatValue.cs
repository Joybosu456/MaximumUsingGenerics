using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMax
{
    public class FloatValue
    {
        public static double MaxIntNum(double firstValue, double secoundValue, double thirdValue, double forthValue)
        {
            if (firstValue.CompareTo(secoundValue) > 0 && firstValue.CompareTo(thirdValue) > 0 && firstValue.CompareTo(forthValue) > 0)
            //firstValue.CompareTo(secoundValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
            //firstValue.CompareTo(secoundValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secoundValue.CompareTo(firstValue) > 0 && secoundValue.CompareTo(thirdValue) > 0 && secoundValue.CompareTo(forthValue) > 0)
            //secoundValue.CompareTo(firstValue) >= 0 && secoundValue.CompareTo(thirdValue) > 0 ||
            //secoundValue.CompareTo(firstValue) > 0 && secoundValue.CompareTo(thirdValue) >= 0)
            {
                return secoundValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secoundValue) > 0 && thirdValue.CompareTo(forthValue) > 0)
            //thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
            //thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                return thirdValue;
            }
            
            if (forthValue.CompareTo(firstValue) > 0 && forthValue.CompareTo(secoundValue) > 0 && forthValue.CompareTo(thirdValue) > 0)
            {
                return forthValue;
            }
            return firstValue;


        }
    }
}
