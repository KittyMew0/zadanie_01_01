/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N. Использовать рекурсию, не использовать циклы. */

Console.WriteLine("enter two numbers");
int M = Convert.ToInt32(Console.ReadLine()), 
    N = Convert.ToInt32(Console.ReadLine());
PrintNumber(M, N);

void PrintNumber(int m1, int n1) {
    Console.Write(m1 + " ");
    if (m1 < n1) {
        PrintNumber(m1 + 1, n1);
    }
}