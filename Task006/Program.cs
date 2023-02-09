// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран, выводя индексы соответствующего элемента

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void CreateArray(int[,,] array3D){
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++){
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1){
      for (int j = 0; j < i; j++){
        while (temp[i] == temp[j]){
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
        number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++){
    for (int y = 0; y < array3D.GetLength(1); y++){
      for (int z = 0; z < array3D.GetLength(2); z++){
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void PrintArray (int[,,] array3D){
  for (int i=0; i < array3D.GetLength(0); i++){
    for (int j = 0; j < array3D.GetLength(1); j++){
      for (int k = 0; k < array3D.GetLength(2); k++){
        Console.Write($"X({i}) Y({j}) Z({k}) = {array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = ReadInt("Введите X: ");
int y = ReadInt("Введите Y: ");
int z = ReadInt("Введите Z: ");
Console.WriteLine();
int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);