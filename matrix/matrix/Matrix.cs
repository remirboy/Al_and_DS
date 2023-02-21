using System;
namespace matrix
{
    public class Matrix
    {
        private int n;
        private int k;
        private double[,] matrix;

        public void SetMatrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        public double[,] GetMatrix()
        {
            return matrix;
        }

        public double GetElementMatrix(int i, int j)
        {
            return matrix[i,j];
        }

        public void SetElementMatrix(int i, int j, double value)
        {
            matrix[i, j] = value;
        }

        public Matrix(int n, int k)
        {
            Random rnd = new Random();
            this.n = n;
            this.k = k;
            matrix = new double[n,k];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < k; j++)
                    matrix[i,j] = rnd.Next(1, 255); //заполняем матрицу с помощью простого линейного уравнения
        }

        public Matrix(int n, int k, double[,] matrix)
        {
            this.n = n;
            this.k = k;
            this.matrix = matrix;
        }

        public void Print() //первый метод, который печатает матрицу.
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                { 
                    Console.Write(" {0}", matrix[i,j]);
                }
            Console.WriteLine();
            }
        }

        public int RowsCount()
        {
            return matrix.GetUpperBound(0) + 1;
        }

        public int ColumnsCount()
        {
            return matrix.GetUpperBound(1) + 1;
        }

        public Matrix Transpouse()//второй метод, который транспонирует матрицу.
        {
            double tmp;
            double[,] transpouseMatrix = new double[k,n];

            for (int i = 0; i < k; i++)
                for (int j = 0; j < n; j++)
                    transpouseMatrix[i, j] = 0;


            for (int i = 0; i < k; i++)
                for (int j = 0; j < n; j++)
                    transpouseMatrix[i,j] = matrix[j,i];
            return new Matrix(k,n,transpouseMatrix);

        }

        public Matrix MatrixMultiplication(Matrix matrixB)
        {
            if (this.ColumnsCount()!= matrixB.RowsCount())
            {
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }
            Matrix matrixC = new Matrix(this.RowsCount(), matrixB.ColumnsCount());
            for (var i = 0; i < this.RowsCount(); i++)

            {
            for (var j = 0; j < matrixB.ColumnsCount(); j++)
            {
                for (var k = 0; k < this.ColumnsCount(); k++)
                {
                    matrixC.GetMatrix()[i, j] += this.GetElementMatrix(i, k) * matrixB.GetElementMatrix(k, j);

                    }

                }

            }
            return matrixC;
        }

    }

}

