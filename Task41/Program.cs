/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/


int[] GetArray()
{
    Console.WriteLine("Введите  числа");
    string data = Console.ReadLine();
    char[] seperators = new char[] { ' ', '.', ',' };
    int[] arr = data.Split(seperators).Select(n => Convert.ToInt32(n)).ToArray();
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        System.Console.Write($" {num} ");
    }

}

void GetCountZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;

    }
    System.Console.WriteLine($" -> Колличество чисел больше 0: {count}");

}

int[] array = GetArray();
PrintArray(array);
GetCountZero(array);