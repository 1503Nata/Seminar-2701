Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine( );
Console.WriteLine();
Console.WriteLine("Задайте размер масcива:  ");
int size;
while (!Int32.TryParse(Console.ReadLine(), out size)|| size==0)
    Console.Write("Неправильный ввод. Введите целое положительное число: ");
int[] array = new int[size];
FullArray(array);
Console.WriteLine("Массив по заданным условиям сформирован: ");
PrintArray(array);
Console.WriteLine( );

void FullArray(int[] array)
{for (int i = 0; i < size; i++)
  {
   array[i] = new Random().Next (1, 100);
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
int summa=0;
for (int j=0; j < size; j+=2)
{
summa = summa + array[j];
}
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях равна {summa}.");