namespace Assignment2
{
    internal class SumandAverage
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Sum of elements: " + sum);
            Console.WriteLine("Average of elements: " + average);
        }
    }
}
