//Показать двумерный массив размером m×n заполненный вещественными числами
void FillArray(double[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(1); k++)
            matrix[i,k] = random.NextDouble() * 100;
}
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
            Console.Write(matrix[i,k] + " ");
        Console.WriteLine();
    }
}
Console.WriteLine("Enter the number of lines: ");
int rows = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("Enter the number of columnes: ");
int columnes = int.Parse(Console.ReadLine()?? "");

double[,] matrix = new double[rows,columnes];

FillArray(matrix);
PrintArray(matrix);

