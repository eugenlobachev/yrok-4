//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

/*Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b<1)
Console.Write("B должно быть натуральным " );
else
{
while (b!=0)
{
c = c * a;
b = b - 1;
}
Console.Write($" A в натуральной степени B равно {c}");
}
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a); 
Console.Write($"Сумма в {a} равна: {Sum(a,len)}");
int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}
int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

