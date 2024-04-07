// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.

// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharsArrayToString(char[] letters);
// {

//     string strResult = char.Empty;
//     for (int i = 0; i < letters.Length; i++)
//     {
//         strResult += letters[i]; // C#
//                                // strResult = strResult + chars[i]; // java
//     }
//     return strResult;
// }

// char[] word = { 'a', 'b', 'c', 'd' };

// string result = CharsArrayToString(word);

// System.Console.WriteLine(result);

string CharsArrayToString(char[] chars)
{
    string strResult = string.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        strResult += chars[i]; // C#
                               //strResult = strResult + chars[i]; // java
    }

    return strResult;
}

char[] chars = { 'a', 'b', 'c', 'd' };

string strResult = CharsArrayToString(chars);

Console.WriteLine(strResult);