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
            int firstNumber = 16;
            int secondNumber = 32;

            List<int> firstFactors = getLCM(firstNumber); //generates a list with all the factors of the first number
            List<int> secondFactors = getLCM(secondNumber); //generates a list with all the factors of the second number

            List<int> result = firstFactors.Where(i => secondFactors.Contains(i)).ToList(); //brings all common numbers from list 1 and 2 to the result list.
        }

        private static List<int> getLCM(int number) //LCM = Least Common multiples
        {
            List<int> factors = new List<int>(); //makes a new empty list for factors
            int i = 1; //starts at 1 to avoid having 1 in the list
            do
            {
                ++i; 

                int numberOfTimes = number / i; //checks how many times i fits into number

                for (int p = 0; p < numberOfTimes; p++) //First divides the number by i and executes the method that many times
                {
                    number = AddDivisibleToList(number, factors, i); //checks if number is divisible with i and if it is then i is added to the "factors" list
                }
            } while (number != 1); //keep going only until 1 to make sure the list don't get 1 as a factor
            return factors;
        }

        private static int AddDivisibleToList(int number, List<int> factors, int i)//checks if number is divisible with i and if it is then i is added to the "factors" list
        {
            if (number % i == 0) //will only execute if the number user inputted is divisible by i aka the divisor
            {
                number = number / i; //changes number to what number is after taking out a factor
                factors.Add(i); //adds the factor into the factors list
            }

            return number;
        }
    }
}
