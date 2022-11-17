using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Matrix
    {
        private int rows, columns;
        private int[,] matrix;

        public Matrix()
        {
            initializeMatrix(0, 0);
        }

        private void initializeMatrix(int r, int c)
        {
            matrix = new int[r, c];
            rows = r; columns = c;
        }

        public void SetData(int numRows, int numColumns, int min, int max)
        {
            initializeMatrix(numRows, numColumns);
            Random numRandom = new Random();
            int r, c;
            for (r = 0; r < numRows; r++)
                for (c = 0; c < numColumns; c++)
                    matrix[r, c] = numRandom.Next(min, max);
        }

        public string GetData()
        {
            string matrixStr = "";
            int r, c;
            for (r = 0; r < rows; r++)
            {
                for (c = 0; c < columns; c++)
                    matrixStr = matrixStr + matrix[r, c] + "\x09";
                matrixStr = matrixStr + "\x0d" + "\x0a";
            }
            return matrixStr;
        }
    }
}
