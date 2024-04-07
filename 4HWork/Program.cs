// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

// “Hello my world” => “world my Hello”

string hello = "Hello my world";
string res = string.Empty;
string[] helloSplit = hello.Split();//["Hello", "my", "world"]

for (int i = helloSplit.Length - 1; i >= 0; i--)
{
res += helloSplit[i] + " ";
}

Console.WriteLine(res.TrimEnd());