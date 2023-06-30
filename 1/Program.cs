//создание массива через ввод

Console.Write("Введите числа через пробел: ");
int[] numbers = GetArrayFromString(Console.ReadLine()!);


int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}
