/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/


Console.WriteLine ("Введите первое число");
string namberOnerStr = Console.ReadLine() ??"";
int nambera =  Convert.ToInt32(namberOnerStr);
Console.WriteLine ("Введите второе число");
string namberTworStr = Console.ReadLine() ??"";
int namberb =  Convert.ToInt32(namberOnerStr);
int result = 1;
int res = 0;

while (res<= namberb)
{
 result = result * nambera;
 res++;
}
Console.WriteLine($"{result*3}");