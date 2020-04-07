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
            ReturnEqual returnequal2 = new ReturnEqual();
            returnequal2.feet = 0;
            // for the reference equality returns false by different method
            bool areEqual = System.Object.ReferenceEquals(returnequal, returnequal2);
            System.Console.WriteLine("ReferenceEquals(value1, value2) = {0}", areEqual);
        }
    }
}
