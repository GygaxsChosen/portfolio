using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int temp;
                temp = Prompt("How many random numbers would you like to generate ? ");

                int[] Num = GenNum(temp);
                /*Console.WriteLine("Wich algorithim would you like to use? (Bubblesort Mergesort W.I.P. Quicksort?  W.I.P.)");

                String input = Console.ReadLine();
                if (input == "BubbleSort")
                {*/
                BubbleSort(Num);
                /*}
                else if (input == "QuickSort")
                {
                    QuickSort(Num);
                }*/
                Console.ReadLine();

            }


        }

        public static int[] GenNum(int A)
        {
            int[] RanNum = new int[(A)];
            Random random = new Random();

            for (int x = 0; x < A; x++)
            {
                int Num = random.Next(0, 100);
                RanNum[x] = Num;
                
                
            }
            return RanNum;
            
        }

        public static int Prompt(string a)
        {
            Console.WriteLine(a);
            int temp;
            temp = int.Parse(Console.ReadLine());

            return temp;


        }
        public static void MergeSort(int[] A) // WIP
        {
            if (A.Length % 2 == 0)     //Checks if input array is even
            {
                int[] B = new int[A.Length / 2];                //Declares sub array
                int[] C = new int[A.Length / 2];                //Declares sub array
                for (int x = 0; x < A.Length; x++)     //Performs an action for every item item in the array
                {
                    if (x < A.Length / 2)               //selects the first half of the input array and assigns it to sub-Array B
                    {
                        B[x] = A[x];
                    }
                    if (x > A.Length / 2)                //Selects the second half of the input array and assigns it to sub-Array C
                    {
                        C[x] = A[x];

                    }
                }

            }
        }

        public static void QuickSort(int[] A)
        {
            int i, j, pivot,counter,temp;
           
            counter = 1;                                    //Sets Initial counter to allow loop to execute
            while (counter != 0)
            {   i = -1;                                     //Left bound
                j = 0;                                      //Right bound
                counter = 0;                                //Count of transpositions per cycle set to zero
                Random rand = new Random();
                pivot = rand.Next(0, A.Length - 1);         //Random Pivot Value Generated

                for (int x = 0; x < A.Length; x++)          //Executes contents for each item in the array
                {
                    
                    

                    if (A[pivot] > A[j])                    //Checks if pivot is greater than right bound
                    {
                        i++;                                //left bound incremented
                        temp = A[j];                        
                        A[j] = A[i];                    
                        A[i] = temp;                        //swaps left and right bound values
                        j++;                                //Right bound Incremented
                        counter++;                          //Increments number of transpositions for this cycle.
                    }
                    else j++;                               //else right bound is icremented
                }
                                                            //Heres where it gets sketchy
                temp = A[i+1];                              
                A[i + 1] = A[pivot];                        //pivot value is placed in Index 1+ left bound

                for (int x =(i+2); x <A.Length; x++)        //Shifts the remaining values in the array from index of pivot (1+ left bound) over one position to the end of the array (not functional)
                {
                    temp = A[x];
                    A[x + 1] = temp;
                    
                    

                }

            }
           


        }

        public static void BubbleSort(int[] A)
{
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 1;

            while (count != 0)
            {
                count = 0;
            for (int x = 0; x < (A.Length-1); x++)
            {

                
                if (A[x] > A[x + 1])
                {
                    int temp;
                    count++;
                    temp = A[x + 1];
                    A[x + 1] = A[x];
                    A[x] = temp;
                        


                }
            }

        }
            foreach(int x in A)
            {
                Console.Write(x);
                Console.Write(" ");
            }

            stopwatch.Stop();
         

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(stopwatch.Elapsed);
}
    }
}
