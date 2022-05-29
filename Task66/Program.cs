/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

int M = Input("Введите M: ");
int N = Input("Введите N: ");
int result = Recutsive(M, N);
System.Console.WriteLine(result);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int Recutsive (int M, int N)
{
    if (M == N)
        return N;
    return N + Recutsive(M, N - 1);
}