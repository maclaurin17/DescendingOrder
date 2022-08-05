using System;
using System.Linq;
namespace DescendingOrder
{
    internal class Program //program to sort an array in decreasing order using iterative way
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[] { 9, 5, 3, 10, 15, 16, 10, 19 }; //declaring and initializing the array
            int numb;
            for (int i = 0; i < myNumbers.Length - 1; i++) // traverse 0 to array length
                for (int j = i + 1; j < myNumbers.Length; j++) // traverse i+1 to array length
                    if (myNumbers[i] < myNumbers[j]) //compare array element with all next element
                {
                    numb = myNumbers[i];
                    myNumbers[i] = myNumbers[j];
                    myNumbers[j] = numb;
                }
            foreach (int i in myNumbers)    
            Console.WriteLine(i + " ");
        }
    }
}