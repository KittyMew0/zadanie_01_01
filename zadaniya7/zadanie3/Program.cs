/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы. */

int m = 10;
int[] array = new int[m];
for (int i = 0; i < m; i++) {
    array[i] = new Random().Next(0, 10);
}
for (int i = 0; i < m; i++) {
    Console.Write(array[i] + " ");
}
Console.WriteLine();
PrintReversed(m - 1);

void PrintReversed(int i) {
    if (i >= 0) {
        Console.Write(array[i] + " ");
        PrintReversed(i - 1);
    }
}