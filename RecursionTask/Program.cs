using System.Data.SqlTypes;
using System.Runtime.InteropServices;

public class program
{
    public static void Main(string[] args)
    {
        //PrintOneToNumber();
        //Console.Write(SumRecursion(6));
        //FibonacciSeries(10);

        //int[] numbers = { 2, 4, 6, 8, 10, 12 };
        //PrintArray(numbers);

        //Console.WriteLine(DigitsOfNumber(100000));
        //Console.WriteLine(DigitsOfNumberSum(25));
        //Console.WriteLine(GCD(10, 50));

        //int[] numbers = { 2, 4, 6, 8, 10, 12 };
        //Console.WriteLine(GreatestNumber(numbers));

        //Console.WriteLine(Factorial(4));
    }

    /// <summary>
    /// Q1
    /// </summary>
    /// <param name="Counter"></param>
    public static void PrintOneToNumber(int Counter = 1)
    {
        if(Counter <= 50)
        {
            Console.WriteLine(Counter);
            Counter++;
            PrintOneToNumber(Counter);

        }
    }

    /// <summary>
    /// Q2
    /// </summary>
    /// <param name="Start"></param>
    /// <param name="End"></param>
    /// <param name="sum"></param>
    /// <param name="Counter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static int SumRecursion( int End )
    {
        int Sum = 0;

        if( End != 0 )
            Sum = End+ SumRecursion(--End);

        return Sum;
    }

    /// <summary>
    /// Q3
    /// </summary>
    /// <param name="Counter"></param>
    /// <param name="End"></param>
    /// <param name="sum"></param>
    /// <exception cref="Exception"></exception>
    public static void FibonacciSeries(int Counter, int End = 1 , int sum = 0  )
    {
        if (Counter > 20)
            throw new Exception("Larger than 20");
        int lastSum = sum;
        if(Counter >= 0)
        {
            Console.WriteLine(sum);
            sum = End + sum;
            End = lastSum;
            Counter--;
            FibonacciSeries(Counter, End, sum);

        }

    }
    /// <summary>
    /// Q4
    /// </summary>
    /// <param name="Numbers"></param>
    /// <param name="index"></param>
    public static void PrintArray(int[] Numbers , int index = 0)
    {
        if(index < Numbers.Length)
        {
            Console.WriteLine(Numbers[index]);
            index++;
            PrintArray(Numbers, index);
        }
    }
    /// <summary>
    /// Q5
    /// </summary>
    /// <param name="Number"></param>
    /// <param name="Count"></param>
    /// <returns></returns>
    public static int DigitsOfNumber(int Number , int Count = 0)
    {
        if(Number.ToString().Length != Count)
        {
            Count++;
            Count = DigitsOfNumber(Number, Count);
        }
        return Count;
    }

    /// <summary>
    /// Q6
    /// </summary>
    /// <param name="Number"></param>
    /// <param name="Count"></param>
    /// <param name="sum"></param>
    /// <returns></returns>
    public static int DigitsOfNumberSum(int Number, int Count = 0 , int sum = 0)
    {
        if (Number.ToString().Length >= Count)
        {
            int value = Number % 10;
            Count++;
            sum = DigitsOfNumberSum(Number / 10, Count) + value;
        }
        return sum;
    }
    /// <summary>
    /// Q8
    /// </summary>
    /// <param name="FirstNumber"></param>
    /// <param name="SecondNumber"></param>
    /// <param name="gcd"></param>
    /// <param name="Counter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static int GCD(int FirstNumber , int SecondNumber , int gcd = 1 , int Counter = 1)
    {
        if (SecondNumber < FirstNumber)
            throw new Exception("First Number need to be greatest than Second");

        if(Counter <= SecondNumber)
        {
            if (FirstNumber % Counter == 0 && SecondNumber % Counter == 0)
                gcd = Counter;
            Counter++;
            gcd = GCD(FirstNumber, SecondNumber, gcd, Counter);
            
        }
        return gcd;
    }
    /// <summary>
    /// Q9
    /// </summary>
    /// <param name="Numbers"></param>
    /// <param name="Counter"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static int? GreatestNumber(int[] Numbers , int Counter = 0 , int? max = null)
    {
        if(Numbers.Length > Counter)
        {
            if (max == null)
                max = Numbers[Counter];

            else if (max < Numbers[Counter])
                max = Numbers[Counter];
            Counter++;
            max = GreatestNumber(Numbers , Counter, max);
        }
        return max;
    }
    /// <summary>
    /// Q10
    /// </summary>
    /// <param name="number"></param>
    /// <param name="result"></param>
    /// <returns></returns>
    public static int Factorial(int number, int result = 0)
    {
        int lastNumber = number;
        if(number > 0)
        {
            result = number;
            result =Factorial(--number , result) * lastNumber;
            ;
        }
        return result;
    }
}