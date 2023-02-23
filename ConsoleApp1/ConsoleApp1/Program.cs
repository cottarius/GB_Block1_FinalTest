Console.WriteLine("Создаём массив...");
string[] array = CreateArray();
Console.WriteLine(); ;

Console.WriteLine("Выводим массив на экран...");
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Заполняем новый массив элементами исходного массива, длина которых <= 3");
string[] newArray = FillArray(array);

Console.WriteLine("Выводим новый массив на экран...");
PrintArray(newArray);

string[] FillArray(string[] array)
{
    
    int count = 0;    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
string[] CreateArray()
{
    int n = 0;
    Console.Write("Введите размер массива: ");
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Ошибка! Введите целое положительное число : ");
    }
    string[] array = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{    
    Console.WriteLine("[\"" + string.Join("\", \"", array) + "\"]");
}

