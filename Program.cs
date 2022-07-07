/*Console.WriteLine("Введите размер массива");                     //Задача 34
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);

int kolvochetnih(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) sum = sum + 1;
        }
        return sum;
    }   

Console.WriteLine("Кол-во четных элементов масива = " + kolvochetnih(MyArray));
*/


/* 
Console.WriteLine("Введите размер массива");                           //Задача 36
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);

int summa(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0) sum = sum + array[i];
        }
        return sum;
    }   

Console.WriteLine("Сумма элементов масива стоящих на нечетных позициях = " + summa(MyArray));
*/

 /*Задайте массив вещественных чисел. 
 Найдите разницу между максимальным и минимальным элементов массива.
 */
 
/*
Console.WriteLine("Введите размер массива");                           //Задача 38
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);

int raznMaxMin(int[] array)
    {
        int sum = 0;
        int max = array[0];
        int min = array[1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }
        sum = max - min;
        return sum;
    }   

Console.WriteLine("Разница между макс и мин элементом массива = " + raznMaxMin(MyArray));
*/