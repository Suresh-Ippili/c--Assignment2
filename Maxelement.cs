namespace Assignment2
{
    internal class Maxelement
    {
        static void Main()
        {
            int[] numbers = { 10, 25, 3, 40, 5, 30, 100 };

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("The maximum element in the array is: " + max);
        }
    }
}
