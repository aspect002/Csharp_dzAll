/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
var numbers = new int[] { 5, 4 };
var Mass = SetDoubleArray(numbers);
Average(Mass);
static void Average(int[,] a)//(внутри параметров создаются новые переменные которые будут действовать ТОЛЬКО в методе ниже,
                                       //и принимает значения )
{
//1+2+3 /3
    //создаём переменную, в которую кладём наш двумерный массив
    var arrayW = a;

    //цикл, пробегается по двумерному массиву и ищет введеное число.
    for (int i = 0; i < arrayW.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arrayW.GetLength(0); j++)
        {
           //0  = arrayW[0,0](первая строка первый столбец = первый элемент массива) и прибавим sum.
           //-2 = arrayW[0,1](-3) + sum(-2).
           //-5 = arrayW[0.2](9) + sum(-5)
           //4 = arrayW[0,3](4) + sum(4)
           //sum = 8
            sum = arrayW[j,i] + sum;

        }
        Console.WriteLine($"среднее арифмитическое: {sum / arrayW.GetLength(0)}");
    }
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
            arrayW[i, j] = random.Next(1, 10); //random.NextDouble - генерирует и добавляет случайный остаток после целого числа

            Console.Write($"{arrayW[i, j]} ");
        }
        Console.WriteLine();
    }
    return arrayW;
}
