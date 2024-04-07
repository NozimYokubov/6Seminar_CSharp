// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива. 

// Пример
// a b c   => “abcdef” 
// d e f 

char[,] chars = {
    {'a', 'b', 'c'},
    {'d', 'e', 'f'},
    {'g', 'h', 'i'}
};

string GatheredChars(char[,] array)
{
    string word = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            word += array[i, j];
        }
    }
    return word;
}

string result = GatheredChars(chars);
Console.WriteLine(result);
