Console.Write("Введите количество элементов в будущем массиве:  ");
int count = Convert.ToInt32(Console.ReadLine());
string[] inputArray = new string[count];
if (count != 0)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        inputArray[i] = Console.ReadLine();
    }

    string[] newArr = GetNewArray(inputArray);
    Console.Write("Введенный массив:");
    PrintArray(inputArray);
    Console.Write("Итоговый массив:");
    PrintArray(newArr);
}
else Console.WriteLine("Введите корректное значение количества элементов массива!");

string[] GetNewArray(string[] array)
{
    int size = 0; //размерность будущего массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }

    string[] newArray = new string[size];
    int k = 0; //счетчик нового массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newArray[k++] = array[i];
    }
    return newArray;
}

void PrintArray(string[] arr)
{

    if (arr.Length == 0) Console.Write("[]");
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0) Console.Write($"[");
            if (i != arr.Length - 1) Console.Write($"'{arr[i]}',");
            else Console.Write($"'{arr[i]}']");
        }
    }
    Console.WriteLine();
}

