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

    static string[] FilterStrings(string[] array)
    {
        int resultCount = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                resultCount++;
            }
        }

        string[] resultArray = new string[resultCount];
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                resultArray[index++] = str;
            }
        }

        return resultArray;
    }
}