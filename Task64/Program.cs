/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

int number = Input("Введите N: ");
Recursive(number);


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void Recursive(int number)
{
    if (number == 1) 
        Console.Write(number);
    else
    {
        Console.Write(number + ", ");
        Recursive(number - 1);
    }
}