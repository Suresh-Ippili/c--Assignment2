namespace Assignment2
{
    internal class Columnsum
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                int columnSum = 0;

                for (int i = 0; i < rows; i++)
                {
                    columnSum += matrix[i, j];
                }

                Console.WriteLine("Sum of column " + (j + 1) + ": " + columnSum);
            }
        }
    }
}
