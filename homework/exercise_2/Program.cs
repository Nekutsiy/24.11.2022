<<<<<<< HEAD
﻿// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
=======
﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
>>>>>>> 9b03bb345d503d57d4d6aa0f276fb3bc68a74410

// 452 -> 11

// 82 -> 10

// 9012 -> 12

<<<<<<< HEAD
Console.WriteLine(" Write Number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма " + GetSumNum(num));

int GetSumNum(int input)
{
    int sum = 0;
    while (input > 0)
    {
        sum += input % 10;
        input /= 10;
    }
    return sum;
}

=======
using System;
namespace Example {
class Program {
static void Main() {
Console.Write("Введите число: ");
string number = Console.ReadLine();
ushort sum = 0;
bool point = true;
char symbol;
for (int i = 0; i < number.Length; ++i) {
symbol = number[i];
if (i == 0 && symbol == '-' || symbol == '+') continue;
if (point && symbol == '.') {
point = false;
continue;
}
if (Char.IsDigit(symbol)) sum += Convert.ToUInt16(symbol.ToString());
else break;
}
Console.WriteLine("Сумма цифр = " + sum);
Console.ReadKey();
}
}
}
>>>>>>> 9b03bb345d503d57d4d6aa0f276fb3bc68a74410
