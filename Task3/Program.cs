/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:

1 4 7 2

5 9 2 3

8 4 2 4

Новый массив будет выглядеть вот так:

1 4 49 2

5 9 2 3

64 4 4 4*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
GetPow(array);

Console.WriteLine();
PrintArray(GetPow(array));


// Метод заполнения двумерного массива 
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Метод вывода двумерного массива
void PrintArray(int[,] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for(int j = 0; j < inArray.GetLength(1); j++){
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Метод замены элементов
int[,]GetPow(int[,]Array)
{
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                Array[i,j]= Convert.ToInt32(Math.Pow(Array[i,j],2));
            }
        }
}
return Array;
}
