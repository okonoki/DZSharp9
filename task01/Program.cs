// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRec(a * a, n / 2);
    else return a * PowerRec(a, n - 1);
}

Console.WriteLine(PowerRec(2, 3));
