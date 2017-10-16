using System;

namespace arrays_2
{
    class Program
    {
        //insertion sorting method
        public static void insSort(int[] myArr)
        {
            //creating a local array of the source array's size
            int[] myArrLoc = new int[myArr.Length];

            //copying content of the source array into the local one to avoid its changing within the Main function
            Array.Copy(myArr, myArrLoc, myArr.Length);
            int i, j, k;

            //sorting operation perform
            for (i = 1; i < myArrLoc.Length; i++)
            {
                k = myArrLoc[i];
                j = i - 1;
                while (j >= 0 && myArrLoc[j] > k)
                {
                    myArrLoc[j + 1] = myArrLoc[j];
                    j--;
                }
                myArrLoc[j + 1] = k;
            }

            //displaying sorted local copy of the source array
            Console.WriteLine();
            foreach (int nums in myArrLoc) Console.Write("{0}  ", nums);
        }

        //bubble sorting method 
        public static void bubbleSort(int[] myArr)
        {
            //creating a local array of the source array's size
            int[] myArrLoc = new int[myArr.Length];

            //copying content of the source array into the local one to avoid its changing within the Main function
            Array.Copy(myArr, myArrLoc, myArr.Length);
            int i, j, k;

            //sorting operation perform
            for (i = 1; i < myArrLoc.Length; i++)
            {
                j = i - 1;
                while (j >= 0)
                {
                    if (myArrLoc[j] > myArrLoc[j + 1])
                    {
                        k = myArrLoc[j + 1];
                        myArrLoc[j + 1] = myArrLoc[j];
                        myArrLoc[j] = k;
                    }
                    j--;
                }
            }

            //displaying sorted local copy of the source array
            foreach (int nums in myArrLoc) Console.Write("{0}  ", nums);
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo userInput;

            do
            {
                int randNum = 100, randLen = 10;
                Random rnd = new Random();
                int[] randInts = new int[randLen];
                Console.WriteLine("There's a range of randomly sorted numbers: ");

                for (int i = 0; i < randInts.Length; i++)
                {
                    randInts[i] = rnd.Next(randNum);
                    Console.Write("{0}  ", randInts[i]);
                }

                //methods invoking
                Console.WriteLine("\n\nThe range sorted with an 'InsertionSortAlgo' would be following: ");
                insSort(randInts);

                Console.WriteLine("\n\n... and with a 'BubbleSortAlgo' would be this like:\n");
                bubbleSort(randInts);

                //"application closing by user" procedure
                Console.WriteLine("\n\nPress 'Enter' key to close the program's window or any other key to repeat above operations.");
                userInput = Console.ReadKey(true);

            } while (userInput.Key != ConsoleKey.Enter);
        }
    }
}