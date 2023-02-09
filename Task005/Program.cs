// В двумерном массиве целых чисел.
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] FillMass(int lenght, int width){
    Random random = new Random();
    int[,] matrix = new int[lenght, width];
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = random.Next(0,10);
    return matrix;
}
void PrintMass(int[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++)    {
        for (int j=0; j<matrix.GetLength(1); j++)
            Console.Write(String.Format("{0,3}", matrix[i,j]));
        Console.WriteLine();
    }
}


int lenght = ReadInt("Введите количество строк массива: ");
int width = ReadInt("Введите количество столбцов массива: ");

int[,] matrix = FillMass(lenght, width);
Console.WriteLine("Исходный массив: ");
PrintMass(matrix);
Console.WriteLine();

int minimum = matrix[0,0];
int minRow = 0;
int minColomn = 0;
for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){
            if (matrix[i,j] < minimum){
                minimum = matrix[i,j];
                minRow = i;
                minColomn = j;
            }
        }
}
Console.WriteLine($"Минимальное значение = {minimum}; имеет координаты: {minRow+1} строка, {minColomn+1} столбец.");
Console.WriteLine();

int[,]newmatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    for (int i=0; i<newmatrix.GetLength(0); i++){
        for (int j=0; j<newmatrix.GetLength(1); j++){
            if (i<minRow && j<minColomn) newmatrix[i,j]=matrix[i,j];
            if (i<minRow && j>=minColomn) newmatrix[i,j]=matrix[i,j+1];
            if (i>=minRow && j<minColomn) newmatrix[i,j]=matrix[i+1,j];
            if (i>=minRow && j>=minColomn) newmatrix[i,j]=matrix[i+1,j+1];
        }
    }

Console.WriteLine("Скорректированный массив: ");
PrintMass(newmatrix);