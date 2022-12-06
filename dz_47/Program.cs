/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
System.Console.WriteLine("Задача 47.Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");
var numbers = GetEnteredNumbers("Введите m и n: ", true);
System.Console.WriteLine($"{String.Join(", ", numbers)}");
//var arrayW = new double[ numbers[0], numbers[1] ];
SetDoubleArray(numbers);
//создаём функцию SetDoubleArray и положим туда наш числовой массив nubmers
static void SetDoubleArray(int[] a)
{
    //создаём переменную, в которую кладём наш двумерный массив
    var arrayW = new double[a[0], a[1]];
    var random = new Random();
    //цикл, пробегается по двумерному массиву и заполняет его рандомными числами.
    for (int i = 0; i < arrayW.GetLength(0); i++)
    {
        for (int j = 0; j < arrayW.GetLength(1); j++)
        {
            arrayW[i, j] =Math.Round(random.Next(-9, 10) + random.NextDouble(),1); //random.NextDouble - генерирует и добавляет случайный остаток после целого числа

            Console.Write($"{arrayW[i, j]} ");
        }
        Console.WriteLine();
    }

}












/// <summary>
/// Функция получает текст и просит ввести данные в строку через запятую или пробел
/// </summary>
/// <param name="outputText">переменная outputText принимает текст, который пользователь просит ввести </param>
/// <returns>возвращает числовой массив </returns>
static int[] GetEnteredNumbers(string outputText = "", bool inline = false)
{
    var arrayInts = Array.Empty<int>();
    if (inline)
        Console.Write(outputText);
    else
        Console.WriteLine(outputText);

    char[] separators = { ' ', ',' };
    var arrayOfEnteredText = Console.ReadLine()
        ?.Split(separators,
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);//RemoveEmptyEntries(срезает лишние пробелы) и
                                                                                    //TrimEntries(срезает пробелы в начале и конце строки) дополнительные условия к сплиту.
    if (arrayOfEnteredText != null)
        arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s)); //конвертирует все в числовой массив

    return arrayInts;
}
