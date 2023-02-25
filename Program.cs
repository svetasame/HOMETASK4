// задача 29, программа, которая задает массив из 8 элементов и выводит их на экран
//Task29();

#region
static void Task29()
{
Random rran = new Random();
int [] array = new int [8];
for (int i = 0; i <array.Length; i++)
{
  array [i] = rran.Next (1,99);
}
string sa = string.Join(", ", array); 
Console.WriteLine ($"Массив из 8 случайных элементов: {sa}");
}
#endregion

//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

#region

//Task27();
int Task27()
{
int number = Prompt("Введите число: ");
int result = Summa(number);
return result;
}

static int Prompt(string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int Summa (int number)
{
string numbering = number.ToString();
int[] array = new int [numbering.Length];
int res = 0;
for (int i = 0; i <numbering.Length; i++)
{
array[i] = Convert.ToInt32(numbering.Substring(i,1));
// Console.WriteLine ($" {array[i]}");
res += array[i];
}
Console.WriteLine ($"Сумма цифр в числе = {res}");
return res;
}
#endregion

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
#region
//Task25();
void Task25()
{
int a = Prompt("Введите число: ");
int b = Prompt("Введите число: ");
if (Validate (b))
{
System.Console.WriteLine($"{a} в степени {b} = {Degree(a, b)}");
}
// int result = Degree(a, b);
// return result;
}
int Degree(int a, int b)
{
int res = a;
for (int i = 1; i < b; i++)
{
  res = res * a;
}
return res;
}

bool Validate (int b)
{
  if (b < 0)
  {
    System.Console.WriteLine("показатель степени не должен быть меньше 0");
    return false;
  }
  return true;
}
#endregion



// задача 29, программа, которая задает массив из 8 элементов и выводит их на экран
//Task29();


#region
Task29v2 ();
void Task29v2()
{
  int length = Prompt("Длина массива: ");
  int min = Prompt("Начальное значение для диапазона: ");
  int max = Prompt("Конечное значение значение для диапазона: ");
  int [] array = GenerateArray (length, min, max);
  PrintArray (array);
}


int [] GenerateArray (int Length, int minValue, int maxValue)
{
int [] array = new int [Length];
Random rran = new Random();
for (int i = 0; i < Length; i++)
{
  array [i] = rran.Next (minValue, maxValue + 1);
}
return array;

// string sa = string.Join(", ", array); 
// Console.WriteLine ($"Массив из 8 случайных элементов: {sa}");
}

void PrintArray (int[] array)
{
  string sa = string.Join(", ", array);
  System.Console.WriteLine($"[{sa}]");
}
#endregion
