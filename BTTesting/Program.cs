using System;
using NUnit.Framework;
namespace BTTesting
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        
    }
    public class Calculator
    {
        public int TotalCost(int quantity, bool haveStudentCard)
        {
            if (quantity <= 0)
                throw new Exception("Invalid input");
            if (haveStudentCard)
                return quantity * 40;
            else
                return quantity * 60;
        }
    }
}
