// // **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

void Sortirovka(string[] array, string[] Newarray)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Newarray[temp] = array[i];
            temp++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    
    }
    System.Console.WriteLine();
}

string[] array = new string[5] {"Hello","Russia","123",":D", "Denmark"};

string[] Newarray = new string[array.Length];

System.Console.WriteLine($"Начальный массив: ");

PrintArray(array);