/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
  if (number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine($"{number} - палиндром.");
  }
  else 
  {
    Console.WriteLine($"{number} - НЕ палиндром.");
  }
}

else
{
    Console.WriteLine($"Введи пятизначное число");
}

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/



int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 =  GetNumber("Введите координату X первой точки: ");
int y1 =  GetNumber("Введите координату Y первой точки: ");
int z1 =  GetNumber("Введите координату Z первой точки: ");
int x2 =  GetNumber("Введите координату X второй точки: ");
int y2 =  GetNumber("Введите координату Y второй точки: ");
int z2 =  GetNumber("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double Length = Math.Sqrt(A*A + B*B + C*C);
Console.WriteLine($"длинна отрезка {Length} ");


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}

