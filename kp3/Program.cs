using MathNet.Numerics.LinearAlgebra;
Matrix<double> A15 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.17, -0.13, -0.11,-0.12},
    {1, -1, -0.13,0.13},
    {0.35,0.33,0.12,0.13},
    { 0.13,0.11,-0.13,-0.11}
});
Vector<double> B15 = Vector<double>.Build.Dense(new double[] { 0.22, 0.11, 0.12, 1 });
Matrix<double> A16 = Matrix<double>.Build.DenseOfArray(new double[,]{
    { 0.11,1.13,-0.17,0.18},
    {0.13,-1.17,0.18,0.14},
    {0.11,-1.05,-0.17,-0.15},
    {0.15,-0.05,0.18,0.11}
});
Vector<double> B16 = Vector<double>.Build.Dense(new double[] { 1, 0.13, 0.11, 1 });
Matrix<double> A23 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {1,-2.01,2.04,0.17 },
    {0.33,-0.77,0.44,-0.51 },
    {0.31,0.17,-0.21,0.54 },
    {0.17,1,-0.13,0.21}
});
Vector<double> B23 = Vector<double>.Build.Dense(new double[] { 0.18, 0.19, 0.21, 0.31 });
Matrix<double> A24 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {2.34,-1.42,-0.54,0.21},
    {1.44,-0.53,1.43,-1.27},
    {0.63,-1.32,-0.65,1.43},
    {0.56,0.88,-0.67,-2.38}
});
Vector<double> B24 = Vector<double>.Build.Dense(new double[] { 0.66, -1.44, 0.94, 0.73 });
void Matrix(Matrix<double> A, Vector<double> b)
{
    var lu = A.LU();
    var check = lu.L.Multiply(lu.U);
    var det = A.Determinant();
    var inv = A.Inverse();
    Vector<double> x = lu.Solve(b);
    Console.WriteLine($"L: \n {lu.L.ToString()}");
    Console.WriteLine($"U: \n {lu.U.ToString()}");
    Console.WriteLine($"Перевірка множенням L на U:\n{check.ToString()}");
    Console.WriteLine($"Визначник:{det}");
    Console.WriteLine($"Обернена матриця:\n{inv.ToString()}");
    Console.WriteLine($"Відповідь:{x.ToString()}");
}
Matrix(A15, B15);
Matrix(A16, B16);
Matrix(A23, B23);
Matrix(A24, B24); 
Matrix<double> m15 = Matrix<double>.Build.Dense(6, 6, (i, j) => (88.5 / ((0.1 * 15 * (i + 1) * (j + 1)) + 0.003 * Math.Pow((0.1 * 15 * (i + 1) * (j + 1)), 2))));
Matrix<double> m16 = Matrix<double>.Build.Dense(5, 5, (i, j) => (100 / Math.Pow((3 + 0.3 * (0.1 * 16 * (i + 1) * (j + 1))), 2)));
Matrix<double> m23 = Matrix<double>.Build.Dense(5, 5, (i, j) => (11.7 / Math.Pow((1 + (0.1 * 23 * (i + 1) * (j + 1))), 7)));
Matrix<double> m24 = Matrix<double>.Build.Dense(4, 4, (i, j) => (159 / (10 * Math.Pow((0.1 * 24 * (i + 1) * (j + 1)), 3) + Math.Pow((0.1 * 24 * (i + 1) * (j + 1)), 2) + 25)));

Matrix<double> M15 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {1*Math.Cos(20* (Math.PI / 180.0)), Math.Sin(20*(Math.PI / 180.0)), -1},
    {1.2*Math.Cos(45* (Math.PI / 180.0)), Math.Sin(45*(Math.PI / 180.0)), -1},
    {2*Math.Cos(60* (Math.PI / 180.0)), Math.Sin(60*(Math.PI / 180.0)), -1 },
    });
Vector<double> b15 = Vector<double>.Build.Dense(new double[] { Math.Pow(1, 2), Math.Pow(1.2, 2), Math.Pow(2, 2) });
Matrix<double> M16 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.9*Math.Cos(30* (Math.PI / 180.0)), Math.Sin(30*(Math.PI / 180.0)), -1},
    {1.1*Math.Cos(45* (Math.PI / 180.0)), Math.Sin(45*(Math.PI / 180.0)), -1},
    {1.9*Math.Cos(60* (Math.PI / 180.0)), Math.Sin(60*(Math.PI / 180.0)), -1 },
    });
Vector<double> b16 = Vector<double>.Build.Dense(new double[] { Math.Pow(0.9, 2), Math.Pow(1.1, 2), Math.Pow(1.9, 2) });
Matrix<double> M23 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.9*Math.Cos(30* (Math.PI / 180.0)), Math.Sin(30*(Math.PI / 180.0)), -1},
    {1.15*Math.Cos(45* (Math.PI / 180.0)), Math.Sin(45*(Math.PI / 180.0)), -1},
    {1.9*Math.Cos(60* (Math.PI / 180.0)), Math.Sin(60*(Math.PI / 180.0)), -1 },
    });
Vector<double> b23 = Vector<double>.Build.Dense(new double[] { Math.Pow(0.9, 2), Math.Pow(1.15, 2), Math.Pow(1.9, 2) });
Matrix<double> M24 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {1.1*Math.Cos(20* (Math.PI / 180.0)), Math.Sin(20*(Math.PI / 180.0)), -1},
    {1.35*Math.Cos(45* (Math.PI / 180.0)), Math.Sin(45*(Math.PI / 180.0)), -1},
    {2.1*Math.Cos(60* (Math.PI / 180.0)), Math.Sin(60*(Math.PI / 180.0)), -1 },
    });
Vector<double> b24 = Vector<double>.Build.Dense(new double[] { Math.Pow(1.1, 2), Math.Pow(1.35, 2), Math.Pow(2.1, 2) });
void Machine(Matrix<double> m, Matrix<double> M, Vector<double> b, int N)
{
    var A = m.L2Norm();
    var Inv = m.Inverse();
    var A_Inv = Inv.L2Norm();
    var condA_upd = A * A_Inv;
    Console.WriteLine($"Евклiдова норма для варiанту {N} -> {A}\n\nЧисло обумовленостi для варiанту {N} -> {condA_upd}");
    var lu = M.LU();
    Vector<double> x = lu.Solve(b);
    Console.WriteLine($"\nРозв'язки К1, К2 та К3 для варiанту {N} --> {x}");
    Console.WriteLine("\n\n\n");
}

Machine(m15, M15, b15, 15);
Machine(m16, M16, b16, 16);
Machine(m23, M23, b23, 23);
Machine(m24, M24, b24, 24);





