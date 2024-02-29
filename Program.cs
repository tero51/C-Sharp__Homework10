class Program
{
    static void Main()
    {
        // Исходный массив
        string[] inputArray = { "Hello", "2", "world", ":-)" };

        // Вызов функции для фильтрации строк
        string[] resultArray = FilterStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.Write($"{str} ");
        }
    }
}