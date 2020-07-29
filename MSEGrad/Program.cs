using System;
using MathNet.Numerics.LinearAlgebra.Double;

namespace MSEGrad
{
    //利用矩阵运算的梯度下降法，求得 HuberLoss 的极值
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new DenseMatrix(2, 3);
            Console.WriteLine(matrix1);
            Console.WriteLine("Hello World!");
        }
    }
}
