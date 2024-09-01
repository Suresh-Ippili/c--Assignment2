namespace Assignment2
{
    internal class Sumof3
    {
        static void Main()
        {
            // Define two 3x3 matrices
            int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int[,] matrix2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

            // Create a new matrix to store the sum
            int[,] sumMatrix = new int[3, 3];

            // Loop through each element of the matrices
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Add corresponding elements of matrix1 and matrix2
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Display the sum matrix
            Console.WriteLine("Sum of the matrices:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
