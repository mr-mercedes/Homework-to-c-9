/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 
*/

int m = 2;
int n = 3;
int result = Accerman(m, n);
System.Console.WriteLine($"Результат функции Аккермана {result} от значений {m} и {n}");

int Accerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Accerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Accerman(m - 1, Accerman(m, n - 1));
    return Accerman(m, n);
}