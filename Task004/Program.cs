// Найти произведение двух матриц

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
            Console.Write(String.Format("{0,4}", matrix[i,j]));
        Console.WriteLine();
    }
}


int lenght = ReadInt("Введите количество строк массивов: ");
int width = ReadInt("Введите количество столбцов массивов: ");

int[,] matrix1 = FillMass(lenght, width);
int[,] matrix2 = FillMass(lenght, width);
Console.WriteLine("Первый массив: ");
PrintMass(matrix1);
Console.WriteLine();
Console.WriteLine("Второй массив: ");
PrintMass(matrix2);
Console.WriteLine();

int[,] mass = new int[lenght, width];
for (int i=0; i<mass.GetLength(0); i++){
    for (int j=0; j<mass.GetLength(1); j++){
        mass[i,j] = matrix1[i,j] * matrix2[i,j];
    }
}
Console.WriteLine("Результат произведения массивов: ");
PrintMass(mass);