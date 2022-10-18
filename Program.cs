// HOME WORK 05

/*; Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int[] array = GetArray(4, 100, 999);
Console.WriteLine($"[{String.Join(" ", array)}]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count ++;

Console.Write(count);
*/


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int[] array = GetArray(4, 100, 999);
Console.WriteLine($"[{String.Join(" ", array)}]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 != 0)
count = count + array[i];

Console.Write(count);
*/

/*
Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] array = GetArray(5, 1, 999999);
Console.WriteLine($"[{String.Join(" ", array)}]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int min = array[0];
for (int i = 0; i < array.Length; i++)
{
	if (min > array[i])
	{
		min = array[i];
	}
}

Console.WriteLine("Минимальный элемент массива = "+min);

int max = array[0];
for (int i = 0; i < array.Length; i++)
{
	if (max < array[i])
	{
		max = array[i];
	}
}

Console.WriteLine("Максимальный элемент массива = "+max);

int count = 0;
count = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами = "+count);