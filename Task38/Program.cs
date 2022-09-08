// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int max = array[0];
int min = 100;


for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,100);

}    

for (int i=0; i<size; i++)
{
if(array[i] > max)
    {
        max = array[i];
    }

}

for (int j=0; j<size; j++)
{
if(array[j] < min)
    {
        min = array[j];
    }

}

Console.Write("[{0}]",string.Join("; ",array));
Console.WriteLine(" -> " + (max-min));

