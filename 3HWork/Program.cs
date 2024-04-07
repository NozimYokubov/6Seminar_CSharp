// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да 
// “55655” => Да

bool IsStringPalindrome(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите строку");

string userInput = Console.ReadLine();

bool result = IsStringPalindrome(userInput);

Console.WriteLine(result ? "Cтрока полиндром" : "Строка не полиндром");


///////////////////////////////////
// Правильный ответ

// public class Task3
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка для проверки 
//         string input = "шалаш";
//         // Вызов метода для проверки, является ли строка палиндромом 
//         bool isPalindrome = IsPalindrome(input);
//         // Вывод результата 
//         Console.WriteLine(isPalindrome ? "Да" : "Нет");
//     }
//     // Метод для проверки, является ли строка палиндромом 
//     public static bool IsPalindrome(string str)
//     {
//         // Нормализация строки путем удаления не буквенно-цифровых символов и приведения к нижнему регистру 
//         string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//         // Сравнение строки с ее перевернутым вариантом 
//         return normalized.SequenceEqual(normalized.Reverse());
//     }
// }