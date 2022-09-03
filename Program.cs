
void LineSort(ref int[,] matrix)
{   
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; ++j)
                for (int k = 0; k < matrix.GetLength(1) - 1; ++k)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
                Console.Write(matrix[i,j] + "  ");
            Console.WriteLine();
        }
}

void MatrixInitialization(ref int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            matrix[i,j] = rnd.Next(-10, 10);
                
        
}


Console.WriteLine("Введите размеры матрицы");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m,n];

MatrixInitialization(ref matrix);

Console.WriteLine("\nИзначальная матрица");
PrintMatrix(matrix);

LineSort(ref matrix);

Console.WriteLine("\nУпорядоченная построчно матрица");
PrintMatrix(matrix);