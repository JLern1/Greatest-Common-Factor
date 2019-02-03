using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCF
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 30;
            int secondNumber = 60;

            List<int> firstFactors = getLCM(firstNumber);
            List<int> secondFactors = getLCM(firstNumber);

            var commonFactors = firstFactors.Intersect(secondFactors);
        }

        private static List<int> getLCM(int number)//LCM = Least Common multiples
        {
            List<int> factors = new List<int>();
            int i = 1;
            do
            {
                ++i;
                if (number % i == 0)
                {
                    number = number / i;
                    factors.Add(i);
                }
            } while (number != 1);
            return factors;
        }
    }
}
