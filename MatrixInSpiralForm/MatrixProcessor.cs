using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixInSpiralForm
{
    class MatrixProcessor
    {
        int[,] matrix;

        public MatrixProcessor(int[,] matrix) {
            this.matrix = matrix;
        }

        public void PrintInSpiralForm() {

            Console.WriteLine("*******The input matrix*******");
            PrintMatrix(matrix);

            int m = 0, n = 0;

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine("---Printing the matrix in spiral form---");
            while (m < rows && n < columns) {
                for (int i = n; i < columns; i++) {
                    Console.Write(matrix[m,i]+" ");
                }
                //Increment m as one row has been processed
                m++;

                for (int i = m; i < rows; i++) {
                    Console.Write(matrix[i,columns-1]+" ");
                }
                //Decrement as the last column has been processed
                columns--;

                if (m < rows) {
                    for (int i = columns - 1; i >= n; i--) {
                        Console.Write(matrix[rows-1,i]+" ");
                    }
                    //Decrement rows as the last row has been processed
                    rows--;
                }

                if (n < columns) {
                    for (int i = rows - 1; i >= m; i--) {
                        Console.Write(matrix[i,n]+" ");
                    }
                    n++;
                    //Increment n as first column has been processed
                }
            }
        }

        private void PrintMatrix(int[,] matrix) {
            Console.WriteLine("--------------------");

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write(matrix[i,j]+ " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
        }

    }
}
