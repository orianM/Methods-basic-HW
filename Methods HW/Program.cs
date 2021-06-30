using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            //function is a block of commands with a number of code lines that do some sort of specified work.

            #endregion

            #region question 2

            /*the benefit of functions is, you can add code to the function and use it
            instead of having to type the same repeating code lines.*/

            #endregion

            #region question 3

            /*to build a function you need: 1.accessibility level for example: public/private.
                                            2.returned value, if expecting to get an answer else void.
                                            3.name of the function usually each word with an UpperCaseLetter
                                            4.parameters, what type of variable the function is expecting to get
                                            5.block of commands, open { and close }
            */

            #endregion

            #region question 4

            //it is possible to create a function that returns a value without a parameter

            #endregion

            #region question 5

            //a function can only return one value.

            #endregion

            #region question 6

            //each function is meant to be written in a class, for example: class Program.

            #endregion

            #region question 7

            /*in a function that has to return a value, whenever return is that's where the function ends
              in a function that doesn't have to return a value, void ends at the end of the command block*/

            #endregion

            #region question 8

            //Console.WriteLine("enter a number 1-10");
            //int enterNum = int.Parse(Console.ReadLine());
            //PrintNumName(enterNum);
            //if(enterNum < 1 || enterNum > 10)
            //{
            //    Console.WriteLine("number is out of range");
            //}

            #endregion

            #region question 9

            //Console.WriteLine("how many times do you want the loop to run?");
            //int loopRepetitions = int.Parse(Console.ReadLine());
            //PrintNumbers(loopRepetitions);

            #endregion

            #region question 11

            //Console.WriteLine("Enter a number to check if it's prime or not");
            //int numberEntered = int.Parse(Console.ReadLine());
            //int result = IsPrime(numberEntered);
            //Console.WriteLine(result);

            #endregion

            #region question 12

            //int[] myArr = { 2, 4, 9, 13, 17 };
            //CheckArrayForPrimeNumbers(myArr);

            #endregion

            #region question 13

            int[] arr1st = { 3, 8, 25, 4, 7 };
            int[] arr2nd = { 6, 9, 23, 8, 1 };

            WhichArrayIsBigger(arr1st, arr2nd);
            int Answer = WhichArrayIsBigger(arr1st, arr2nd);
            Console.WriteLine(Answer);

            #endregion
        }
        public static void PrintNumName(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
            }
        }
        private static bool PrintNumbers(int number)
        {
            if (number < 10 && number > 1)
            {
                return true;
            }
            else
                return false;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }

        }
        private static int IsPrime(int numberByUser)
        {
            int checkIfPrime = 2;
            while (numberByUser % checkIfPrime != 0)
            {
                checkIfPrime++;
            }
            if (numberByUser == checkIfPrime)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private static void CheckArrayForPrimeNumbers(int[] arr)
        {
            int divByNum = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] % divByNum != 0)
                {
                    divByNum++;
                }
                if (arr[i] == divByNum)
                {
                    Console.WriteLine("Prime number");
                }
                else
                {
                    Console.WriteLine("Not prime number");
                }
            }
        }
        private static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += arr1[i];
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                sum2 += arr2[j];
            }
            if (sum1 > sum2)
                return 1;
            else if (sum1 == sum2)
                return 0;
            else
                return -1;
        }
    }
}
