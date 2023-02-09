// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//Пример: Есть набор данных
//{ 1, 9, 9, 0, 2, 8, 0, 9 }

//частотный массив может быть представлен так:
//0 встречается 2 раза
//1 встречается 1 раз
//2 встречается 1 раз
//8 встречается 1 раз
//9 встречается 3 раза

void FillArray(int[]array){
    for (int i=0; i<array.Length; i++){
        int number = new Random().Next(10);
        array[i] = number;
    }
}
void PrintArray(int[]array){
    foreach (var element in array){
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}
void SortArray(int[]array){
    for (int i=0; i<array.Length; i++){
        for (int j=0; j<array.Length-1; j++){
            if (array[j]>array[j+1]){
                int temporary = array[j];
                array[j] = array[j+1];
                array[j+1] = temporary;
            }
        }
    }
}

int[]arr = new int[10];

FillArray(arr);
PrintArray(arr);

SortArray(arr);
PrintArray(arr);

Console.WriteLine();

int count = 1;
int temp = 1;
for (int i=0; i<arr.Length; i=i+temp){
    temp = 1;
    for (int j=i+1; j<arr.Length; j++){
        if (arr[i]==arr[j]){
            count++;
            temp = count;
        }
        else break;
    }
    Console.WriteLine($"{arr[i]} встречается {count} раз");
    count = 1;
}