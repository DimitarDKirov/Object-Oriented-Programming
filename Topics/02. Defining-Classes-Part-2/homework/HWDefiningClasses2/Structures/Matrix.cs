using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    [Version(1,1)]
    class Matrix<T>
    {
        private T[,] array;

        public Matrix(int rows, int cols)
        {
            this.array = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.array[row, col];
            }
            set
            {
                this.array[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            int rows = matrixA.array.GetLength(0);
            int cols = matrixA.array.GetLength(1);
            if (rows != matrixB.array.GetLength(0) || cols != matrixB.array.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("Both matrices must have equal dimensions");
            }

            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = (dynamic)matrixA.array[row, col] + (dynamic)matrixB.array[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            int rows = matrixA.array.GetLength(0);
            int cols = matrixA.array.GetLength(1);
            if (rows != matrixB.array.GetLength(0) || cols != matrixB.array.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("Both matrices must have equal dimensions");
            }

            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = (dynamic)matrixA.array[row, col] - (dynamic)matrixB.array[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            int rows = matrixA.array.GetLength(0);
            int cols = matrixB.array.GetLength(1);

            if (matrixA.array.GetLength(1) != matrixB.array.GetLength(0))
            {
                throw new ArgumentOutOfRangeException("Matrices could not be multiplyed");
            }
            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    for (int i = 0; i < matrixA.array.GetLength(1); i++)
                    {
                        result[row, col] += (dynamic)matrixA[row, i] * (dynamic)matrixB[i, col];
                    }
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.array.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.array.GetLength(1); col++)
                {
                    if ((dynamic)matrix.array[row, col] == 0) return false;
                }

            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix) return true;
            return false;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int row = 0; row < this.array.GetLength(0); row++)
            {
                for (int col = 0; col < this.array.GetLength(1); col++)
                {
                    builder.AppendFormat("{0} ", this.array[row, col]);
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

        public string Attribute()
        {
            string result = string.Empty;
            var attributes = typeof(Matrix<T>).GetCustomAttributes(typeof(VersionAttribute), false);
            foreach (VersionAttribute attribute in attributes)
            {
                result += attribute.ToString();
            }
            return result;
        }
    }
}
