using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3,4); //создаём экземпляр класса, передаём размер - 4 на 4.
            matrix.Print();//печатаем матрицу, смотрим.
            Console.WriteLine();
            matrix.Transpouse().Print();
            Console.WriteLine();
            Matrix matrix1 = new Matrix(4, 5);
            matrix1.Print();
            Console.WriteLine();
            matrix.MatrixMultiplication(matrix1).Print();
        }
    }
}
