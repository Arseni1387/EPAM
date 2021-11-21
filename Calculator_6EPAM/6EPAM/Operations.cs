using System;
using System.Collections.Generic;
using System.Text;

namespace _6EPAM
{
    public class Operations
    {
        static public int Plus(int firstTerm, int secondTerm)
        {
            if ((double)firstTerm + (double)secondTerm > int.MaxValue)
            {
                throw new ArgumentException("sum is bigger than MaxVaue");
            }

            if ((double)firstTerm + (double)secondTerm < int.MinValue)
            {
                throw new ArgumentException("sum is less than MinVaue");
            }

            return firstTerm + secondTerm;
        }

        static public int Minus(int firstTerm, int secondTerm)
        {
            return firstTerm - secondTerm;
        }

        static public int Multiply(int firstTerm, int secondTerm)
        {
            return firstTerm * secondTerm;
        }

        static public int Division(int firstTerm, int secondTerm)
        {
            if (secondTerm == 0)
            {
                throw new ArgumentException(nameof(secondTerm));
            }

            return firstTerm / secondTerm;
        }
    }
}
