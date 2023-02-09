// Если набор данных - таблица
//1, 2, 3
//4, 6, 1
//2, 1, 6

//на выходе ожидаем получить
//1 встречается 3 раза
//2 встречается 2 раз
//3 встречается 1 раз
//4 встречается 1 раз
//6 встречается 2 раза

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] FillMatrix(int lenght, int width){
    Random random = new Random();
    int[,] matrix = new int[lenght, width];
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = random.Next(0,10);
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++)    {
        for (int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
}

int lenght = ReadInt("Введите количество строк массива: ");
int width = ReadInt("Введите количество столбцов массива: ");
int[,] matrix = FillMatrix(lenght, width);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);

Console.WriteLine();

int count = 0;
for (int k=0; k<10; k++){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){
            if (matrix[i,j]==k) count++;
        }
    }
    if (count != 0) Console.WriteLine($"{k} встречается {count} раз");
    count = 0;
}