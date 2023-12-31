/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n.
            { n + 1                       m = 0
A (m, n) =  { A (m - 1, 1)                m > 0, n = 0 
            { A (m - 1, A (m, n - 1) )    m > 0, n > 0
*/

Console.WriteLine("Enter two numbers");
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());

int result = CountAckermann(m, n);
Console.WriteLine("Ackermann(" + m + ", " + n + ") = " + result);

int CountAckermann(int m1, int n1) {
    if (m1 == 0) {
        return n1 + 1;
    }
    else if (m1 > 0 && n1 == 0) {
        return CountAckermann(m1 - 1, 1);
    }
    else {
        return CountAckermann(m1 - 1, CountAckermann(m1, n1 - 1));
    }
}