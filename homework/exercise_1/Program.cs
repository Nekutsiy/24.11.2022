// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.


Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(GetMathPow(a, b));

static double GetMathPow(double a, int b)
{
    if (b < 0) { (a, b) = (1.0 / a, -b); }
    double res = 1.0;
    for (; b != 0; a *= a, b /= 2)
    {
        if (b % 2 != 0) { res *= a; }
    }
    return res;
}