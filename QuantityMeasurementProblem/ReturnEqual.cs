using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class ReturnEqual
    {
        public int feet { get; set; }
        public int inch { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is ReturnEqual))
            {
                return false;
            }
            return this.inch == ((ReturnEqual)obj).inch && this.inch == ((ReturnEqual)obj).inch; 
            return this.feet == ((ReturnEqual)obj).feet && this.feet == ((ReturnEqual)obj).feet;
        }
        public override int GetHashCode()
        {
            return this.inch.GetHashCode() ^ this.inch.GetHashCode();
             return this.feet.GetHashCode() ^ this.feet.GetHashCode();
        }
    }
}
