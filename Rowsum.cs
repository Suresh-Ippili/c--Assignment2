namespace Assignment2
{
    internal class Rowsum
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0; 

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j]; 
                }

                Console.WriteLine("Row " + (i + 1) + " sum: " + rowSum);
            }
        }
    }
}
