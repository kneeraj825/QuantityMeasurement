using System;

namespace QuantityMeasurementProblem
{
    public class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quatity Measurement");
            //If feet and inch is zero then returns equal
            ReturnEqual returnequal = new ReturnEqual();
            returnequal.feet = 0;
            returnequal.inch = 0;
            ReturnEqual returnequal1 = returnequal;
            Console.WriteLine(returnequal.Equals(returnequal1));
        }
    }
}
