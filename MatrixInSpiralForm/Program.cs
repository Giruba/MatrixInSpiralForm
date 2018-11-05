using System;

namespace MatrixInSpiralForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix in Spiral Form!");
            Console.WriteLine("----------------------");

            try
            {
                int[,] matrix = GetInput();
                MatrixProcessor matrixProcessor = new MatrixProcessor(matrix);
                matrixProcessor.PrintInSpiralForm();
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }

            Console.ReadLine();
        }

        private static int[,] GetInput() {

            int[,] matrix = null;
            Console.WriteLine("Enter the number of rows in the matrix");
            try
            {
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of columns in the matrix");
                int columns = int.Parse(Console.ReadLine());
                matrix = new int[rows,columns];
                for (int i = 0; i < rows; i++) {
                    Console.WriteLine("Enter the elements of row " + i + " separated by space");
                    String rowElements = Console.ReadLine();
                    String[] elements = rowElements.Split(' ');
                    for (int j = 0; j < columns; j++) {
                        matrix[i, j] = int.Parse(elements[j]);
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }
            return matrix;
        }
    }
}
