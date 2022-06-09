// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] matrix)
{
    Random random=new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(1); k++)
            matrix[i,k] = random.Next(-100,100);
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
            Console.Write(matrix[i,k] + " ");
        Console.WriteLine();
    }
}
void Square(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(1); k++)
            if(i%2 == 0 && k%2 == 0) matrix[i,k] = matrix[i, k] * matrix[i, k];
}
Console.WriteLine("Enter the number of lines: ");
int rows = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("Enter the number of columnes: ");
int columnes = int.Parse(Console.ReadLine()?? "");

int[,] matrix = new int[rows,columnes];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Square(matrix);
PrintArray(matrix);
