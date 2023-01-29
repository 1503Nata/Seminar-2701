Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
// [345, 897, 568, 234] -> 2
Console.WriteLine();
Console.WriteLine("Задайте размер масcива:  ");
int size;
while (!Int32.TryParse(Console.ReadLine(), out size) || size==0)
    Console.Write("Неправильный ввод. Введите целое положительное число: ");
int[] array = new int[size];
FullArray(array);
Console.WriteLine("Массив по заданным условиям сформирован: ");
PrintArray(array);
Console.WriteLine();

void FullArray(int[] array)
{for (int i = 0; i < size; i++)
  {
   array[i] = new Random ().Next (100, 1000);
  }
return;
}
void PrintArray(int[] array)
{
    int i = 0;
    Console.Write($" [ {array[i]}");
    for (i = 1; i < size; i++)
    {
    Console.Write($", {array[i]}");
    }
    Console.Write(" ]");
    return;
}
int Count=0;
for (int j=0; j < size; j++)
if (array [j] % 2 == 0)
Count++;

Console.WriteLine($"  В массиве {Count} четных чисел.");