/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
System.Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,"
+ "и возвращает значение этого элемента или же указание, что такого элемента нет ");


var numbers = new int[] { 5, 7 };
var Mass = SetDoubleArray(numbers);
int x = Convert.ToInt32(Console.ReadLine());
FindNumber(Mass, x);
static void FindNumber(int[,] a, int x)//(внутри параметров создаются новые переменные которые будут действовать ТОЛЬКО в методе ниже,
                                       //и принимает значения )
{

    //создаём переменную, в которую кладём наш двумерный массив
    var arrayW = a;
    var count = 0;
    //цикл, пробегается по двумерному массиву и ищет введеное число.
    for (int i = 0; i < arrayW.GetLength(0); i++)
    {
        for (int j = 0; j < arrayW.GetLength(1); j++)
        {

            if (arrayW[i, j] == x)
            {
                count++;
            }
        }
    }
    Console.WriteLine($"Количество таких чисел:  {count} ");
}






//создаём функцию SetDoubleArray и положим туда наш числовой массив nubmers
static int[,] SetDoubleArray(int[] a)
{
    //создаём переменную, в которую кладём наш двумерный массив
    var arrayW = new int[a[0], a[1]];
    var random = new Random();
    //цикл, пробегается по двумерному массиву и заполняет его рандомными числами.
    for (int i = 0; i < arrayW.GetLength(0); i++)
    {
        for (int j = 0; j < arrayW.GetLength(1); j++)
        {
            arrayW[i, j] = random.Next(-9, 10); //random.NextDouble - генерирует и добавляет случайный остаток после целого числа

            Console.Write($"{arrayW[i, j]} ");
        }
        Console.WriteLine();
    }
    return arrayW;
}
