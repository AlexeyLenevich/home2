// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true) // Бесконечный цикл
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Convert.ToString(Console.ReadLine()); // Чтение строки ввода пользователя
    if (input == "q") // Проверка на ввод 'q' для выхода
    {
        break;
    }
    int number;
    if (int.TryParse(input, out number))// Проверка, является ли ввод числом. (input - (проверяемое значение),
     //out ... - в какое значение перевести, если int (int указывается в начале метода, там может быть любой 
    //тип чисел)
    {
        int sum = 0;
        while (number > 0) // Вычисление суммы цифр числа
        {
            sum += number % 10; // Добавление последней цифры к сумме
            number /= 10; // Удаление последней цифры из числа
        }
        if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
        {
            Console.WriteLine("[STOP]");
            break;
        }
    }
    else // Если ввод не является числом и не 'q', повторить запрос
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
    }
}


// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateArray(int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length /*n*/; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;

}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine("input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
System.Console.WriteLine(EvenNumbers(array));

// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] Perevorot(int[] arr)
{
    int vrem;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        vrem = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = vrem;
    }
    foreach (int number in arr)
    {
        Console.Write($"{number} ");
    }
    return arr;
}

// int[] array2 = CreateArray(size, min, max);
// PrintArray(array2);
int[] array2 = Perevorot(array);
System.Console.Write(array2);
// System.Console.WriteLine();

