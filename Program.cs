using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 0, b = 0; // Variable declaration and initialization
            Console.WriteLine("Enter a – start range");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b – end range");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Start range should be less than the end range");
                Console.ReadLine();
                return;
            }
            else
            {
                printPrimeNumbers(a, b);
            }


            Console.WriteLine("Enter number to get the sum of the series - ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            getSeriesResult(n1);
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            Console.WriteLine("Enter number of lines for the pattern - ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            if (n4 > 0)
                printTriangle(n4);
            else
                Console.WriteLine("Entered number should not be less than 1");



            Console.WriteLine("Computing frequency program starts...");
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            int i,j, ctr=0;           
            try
            {
                for (i=x; i<=y; i++)
                {
                    ctr = 0;                   
                    for (j = 2; j <= i/2 + 1; j++)
                    {                        
                        if (i % j == 0)
                        {
                            ctr++;
                            break;
                        }
                    }
                    if (ctr == 0 && i != 1)
                        Console.WriteLine("{0} is a prime number.\n", i);
                }                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static int getFactorial(int n)
        {
            int factorial = 1;
            int ctr = 1;
            try
            {
               while (ctr <= n)
                {
                    factorial = factorial * ctr;
                    ctr++;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getFactorial()");
            }
            return factorial;
        }

        public static double getSeriesResult(int n)
        {
            double sum = 0;
            int ctr = 1;
            int den = 2;

            try
            {   
                while (ctr <= n)
                {
                    //den = ctr + 1;
                    Console.WriteLine("Factorial of ::" + ctr + " is ::" + getFactorial(ctr));
                    if (ctr % 2 == 0)
                    {    
                        sum = sum - (double)getFactorial(ctr) / den;
                        Console.WriteLine("Divided by 2 ::" + ctr + " is ::" + sum);
                    }
                    else
                    {
                        sum = sum + (double)getFactorial(ctr) / den;
                        Console.WriteLine("Not Divided by 2 ::" + ctr + " is ::" + sum);
                    }
                    Console.WriteLine("ctr flag is ::::" + ctr + "and sum is :::" + sum);
                    ctr++;
                    den++;
                }
               
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return Math.Round(sum, 3);

        }

        public static void printTriangle(int n)
        {
            try
            {
                int x, y;
                //Loop till n
                for (x = 0; x<=n; x++)
                {
                    // Print whitespace
                    for (y = 1; y <= n - x; y++)
                        Console.Write(" ");
                    // Pprint '*'
                    for (y = 1; y <= 2 * x - 1; y++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] arr)
        {
            try
            {
                if (arr.Length > 0)
                {
                    // creating an array to store frequencies 
                    int[] frequency = new int[arr.Length];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        frequency[i] = -1;
                    }
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int count = 1;
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] == arr[j])
                            {
                                count++;
                                frequency[j] = 0;
                            }
                        }

                        if (frequency[i] != 0)
                        {
                            frequency[i] = count;
                        }
                    }


                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (frequency[i] != 0)
                        {
                            Console.Write("{0}\t{1}\n", arr[i], frequency[i]);
                        }
                    }
                }
                else
                {
                    Console.Write("The Array entered by the user is empty");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
