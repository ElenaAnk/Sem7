/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


Console.WriteLine();
getSum(array);


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

//Метод нахождения элементов
void getSum(int[,] array)
{
      // 0,1,2
      // 1,2,3
      // 1,2,2
      // 2,3,3 

      int rows = array.GetLength(0);
      int columns = array.GetLength(1);

      int number = 0;
      if (rows > columns) {number = columns;}
      else {number = rows;}

      int[] numbers = new int[number];
      int sum = 0;
      for (int i = 0; i < rows; i++)
      {
            for (int j = 0; j < columns; j++)
            {
                  if (i==j)
                  {
                        numbers[i] = array[i,j];
                        sum += array[i,j];
                  }
            }
      }

      Console.WriteLine($"{String.Join(", ",numbers)} --> {sum}");
}