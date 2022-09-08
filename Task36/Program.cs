// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int count = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-20,20);
    if (i % 2 != 0)
    {
        count+=array[i];
    }
}

Console.Write("[{0}]",string.Join("; ",array));
Console.WriteLine(" -> "+count);
