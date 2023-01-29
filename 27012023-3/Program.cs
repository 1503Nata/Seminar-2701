// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер масcива:  ");
int size;
while (!Int32.TryParse(Console.ReadLine(), out size) || size==0)
    Console.Write("Неправильный ввод. Введите целое положительное число: ");
double[] array = new double[size];
FullArray(array);
Console.WriteLine("Массив по заданным условиям сформирован: ");
PrintArray(array);
Console.WriteLine( );
double resmax = array[0];
double resmin = array[0];
ArgMax(array);
ArgMin(array);
Console.WriteLine($"Максимальное число в массиве: {resmax.ToString("#.000")}, Минимальное число в массиве: {resmin.ToString("#.000")}");

void ArgMax(double[] array)
{
    for (int j=0; j < size; j++)
    {if (array[j]>resmax)
      resmax=array[j];
    }
    return;
}

void ArgMin(double[] array)
{
    for (int j=0; j < size; j++)
    {if (array[j]<resmin)
    resmin=array[j];
    }
    return;
}

void FullArray(double[] array)
{
    {Random Rand = new Random();
    for (int i = 0; i < size; i++) 
      {
        array[i] =100-Rand.Next(100)+Rand.NextDouble();
      }
    }
return;
}
void PrintArray(double[] array)
    {
    int i = 0;
    Console.Write($" [ {(array[i].ToString("#.000"))}");
        for (i = 1; i < size; i++)
        {
          Console.Write($", {(array[i].ToString("#.000"))}");
        }
    Console.Write(" ]");
    return;
    }

double diff = 0;
diff = resmax - resmin;
Console.WriteLine($"Разность между максимальныи и минимальным элементами массива равна {diff.ToString("#.000")}.");
