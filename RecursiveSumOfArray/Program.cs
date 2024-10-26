int[] numbers = { 1, 2, 3, 4, 5 };
int sum = ArraySumLab.SumArray(numbers, numbers.Length);
Console.WriteLine($"Sum of array: {sum}");

public class ArraySumLab
{
    static public int SumArray(int[] array, int n)
    {
       if (n <= 0)
       {
           return 0;
       } 
       else
       {
           return (SumArray(array, n - 1) + array[n - 1]);
       }
    }
}

