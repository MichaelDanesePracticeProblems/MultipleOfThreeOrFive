using System;

namespace MultipleOfThreeOrFive
{
/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
*/
//Michael Danese
    class Program
    {
        static void Main(string[] args)
        {//This program takes the 
            int threeMultiple = 3;
            int fiveMultiple = 5;
            int sum = 0;

            while (threeMultiple < 1000)
            {//This method only requires 3 variables and does not need to check every value under 1000. Just needs to keep track of the multiples and when they intersect.
                if (threeMultiple > fiveMultiple )
                {//Checks if the 3 multiple is greater than the five multiple and if so increments both after adding both to the sum
                    sum += threeMultiple + fiveMultiple;
                    threeMultiple += 3;
                    fiveMultiple += 5;
                }
                else if (threeMultiple == fiveMultiple)
                {//Checks if the 3 multiple is equal to the five multiple and if so increments both after adding the three multiple to the sum

                    sum += threeMultiple;
                    threeMultiple += 3;
                    fiveMultiple += 5;
                }
                else
                {//Adds 3 multiple to the sum then increments the three multiple
                    sum += threeMultiple;
                    threeMultiple += 3;
                }
            }
            Console.Write("The sum is: ");
            Console.WriteLine(sum);
        }
    }
}
