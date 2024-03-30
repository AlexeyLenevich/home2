// 6-ой семинар:

// Задача 1: Создание строки из двумерного массива символов


void Main(char[,] Arr)
{
        // Вызов метода для создания строки из 2D массива
    string result = CreateStringFrom2DArray(Arr);
    // Вывод результата
    Console.WriteLine(result);
}


// Метод для создания строки из двумерного массива символов
string CreateStringFrom2DArray(char[,] array)
{
    string result = "";

    // Цикл по каждому элементу в двумерном массиве
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Добавление каждого символа в результирующую строку
            result += array[i, j];
        }
    }

    return result;
}
char[,] charArray = new char[,] { { 'a', 'b', '4' }, { 'c', 'd', '3' } };
Main(charArray);



// Задача 2: Замена заглавных букв на строчные в строке


void Main2(string letter)
{
       // Преобразование всех заглавных букв в строчные
    string result = letter.ToLower();

    // Вывод результата
    Console.WriteLine(result);
}
System.Console.WriteLine("Введите текст: ");
string text = Convert.ToString(Console.ReadLine());
Main2(text);


// Задача 3: Проверка строки на палиндром


void Main3(string input)
{
       // Вызов метода для проверки, является ли строка палиндромом
    bool isPalindrome = IsPalindrome(input);

    // Вывод результата
    if (isPalindrome == true)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    
}

// Метод для проверки, является ли строка палиндромом
bool IsPalindrome(string str)
{
    // Нормализация строки путем удаления не буквенно-цифровых символов и приведения к нижнему регистру
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

    // Сравнение строки с ее перевернутым вариантом
    return normalized.SequenceEqual(normalized.Reverse());
}
System.Console.WriteLine("Введите текст: ");
string word = Convert.ToString(Console.ReadLine());
Main3(word);


// Задача 4 (необязательная): Обратный порядок слов в строке


void Main4()
{
    // Входная строка со словами, разделенными пробелами
    string input = "Hello my world";

    // Вызов метода для обращения порядка слов в строке
    string result = ReverseWords(input);

    // Вывод результата
    Console.WriteLine(result);
}

// Метод для обращения порядка слов в строке
string ReverseWords(string str)
{
    string[] words = str.Split(' ');

    // Обращение порядка слов
    Array.Reverse(words);

    // Соединение слов обратно в строку с пробелами
    return string.Join(" ", words);
}

Main4();


