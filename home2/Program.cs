// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 & number % 23 == 0)
{
    System.Console.WriteLine($"{number} кратно 7 и 23");
}
else
{  
    System.Console.WriteLine($"{number} не кратно 7 и 23");
}


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("input X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input Y: ");
int y = Convert.ToInt32(Console.ReadLine());


if (x > 0 & y > 0)
{
    System.Console.WriteLine("Точка в первой четверти");
}
if (x < 0 & y > 0)
{
    System.Console.WriteLine("Точка во второй четверти");
}
if (x < 0 & y < 0)
{
    System.Console.WriteLine("Точка в третьей четверти");
}
if (x > 0 & y < 0)
{
    System.Console.WriteLine("Точка в четвертой четверти");
}
if (x == 0 | y == 0)
{
    System.Console.WriteLine("Точка не находится в координатной четверти");
}


// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

System.Console.WriteLine("input number of segment [10, 99]: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 & num <= 99)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        System.Console.WriteLine($"Наибольшая цифра числа {ed}");
    }
    else
    {
        System.Console.WriteLine($"Наибольшая цифра числа {dec}");
    }
    if (ed == dec)
    {
        System.Console.WriteLine("Две цифры числа равны");
    }
}
else 
{
    System.Console.WriteLine("Число вне отрезка");
}

// Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.

System.Console.WriteLine("input number: ");
int numb = Convert.ToInt32(Console.ReadLine());
int r = 0; // Разрядность числа
int numb2 = numb;

if (numb2 > 0)
{
  while (numb2 != 0)
    {
        numb2 = numb2 / 10;
        r++;
    }
    for (int n = 0; n < r; n++)
    {
        int finalnumbers = (numb / (int)Math.Pow(10,r - n - 1)) % 10;

        System.Console.Write($"{finalnumbers}");
        if (n != r - 1)
        {
            System.Console.Write(", ");   
        }
    }       
}
else
{
    System.Console.WriteLine("Число не натуральное");
}
// System.Console.WriteLine($"{r} ");
// System.Console.WriteLine($"{numb} ");
