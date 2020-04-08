using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    class ReturnEqual
    {
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
        }
        public override int GetHashCode()
        {
            return this.inch.GetHashCode() ^ this.inch.GetHashCode();
        }
    }
}
