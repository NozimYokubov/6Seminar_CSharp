// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные. 

// “aBcD1ef!-” => “abcd1ef!-” 

string ChangeCase(string word)
{
    string str = "aBcD1ef!-";
    string result = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            result += str[i].ToString().ToLower();
        }
        else
        {
            result += str[i];
        }
    }
    return result;
}

string word = "aBcD1ef!-";
string result = ChangeCase(word);
Console.WriteLine(result);


///////////////////////////////////
// Правильный ответ

// public class Task2
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка со смешанными буквами обоих регистров 
//         string input = "aBcD1ef!-";
//         // Преобразование всех заглавных букв в строчные 
//         string result = input.ToLower();
//         // Вывод результата 
//         Console.WriteLine(result);
//     }
// }