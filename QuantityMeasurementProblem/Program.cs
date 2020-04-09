using System;

namespace QuantityMeasurementProblem
{
    public class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quatity Measurement");
            //If  inch and feet is zero then returns equal
            ReturnEqual returnequal = new ReturnEqual();
            returnequal.inch = 0;
            ReturnEqual returnequal3 = new ReturnEqual();
            returnequal3.feet = 0;
            ReturnEqual returnequal2 = new ReturnEqual();
            returnequal2.inch = 0;
            ReturnEqual returnequal4 = new ReturnEqual();
            returnequal4.feet = 0;
            // for the reference equality returns false by different method
            bool areEqual = System.Object.ReferenceEquals(returnequal, returnequal2);
            System.Console.WriteLine("ReferenceEquals(value1, value2) = {0}", areEqual);
            bool areEqual1 = System.Object.ReferenceEquals(returnequal3, returnequal4);
            System.Console.WriteLine("ReferenceEquals(value1, value2) = {0}", areEqual);
            // for the type check returns true
            Console.WriteLine("value1 and value2 are the same type: {0}",
            Object.ReferenceEquals(returnequal.GetType(), returnequal2.GetType()));
            Console.WriteLine("value1 and value2 are the same type: {0}",
            Object.ReferenceEquals(returnequal3.GetType(), returnequal4.GetType()));
           //  for the value equality returns true
            Console.WriteLine(returnequal.Equals(returnequal2));
            Console.WriteLine(returnequal3.Equals(returnequal4));
        }
    }
}
