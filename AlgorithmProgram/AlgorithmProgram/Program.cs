using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithmic Programs");
            Console.WriteLine("1.BinarySearch\n2.InsertionSort\n3.BubbleSort\n4.PrimeNumbers\n5.Anagram\n6.CustomizeMessage\n7.Exit");
            Console.Write("Enter the Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    BinarySearch.Search();
                    break;
                case 2:
                    InsertionSort.Insertionsort();
                    break;
                case 3:
                    Bubblesort.Bubble();
                    break;
                case 4:
                    PrimeNumber.Prime();
                    break;
                case 5:
                    Anagram.FindAnagram();

                    break;
                case 6:
                    RegexInput regexp = new RegexInput();
                    regexp.Check();
                    break;
                default:
                    Console.WriteLine("Thank You... :)");
                    break;
            }
        }
    }
}
