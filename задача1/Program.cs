/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

if (number < 1000 && number > 99)
{
   Console.WriteLine(number/ 10 % 10);
}
else
    Console.WriteLine("Введено не трехзначное число");
