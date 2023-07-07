/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;
string palindrome = Convert.ToString(number);
string reverse = Reverse(palindrome);
if (palindrome == reverse) Console.WriteLine($"{palindrome} -> да");
else Console.WriteLine($"{palindrome} -> нет");

string Reverse (string str)
{
    char[] chars = str.ToCharArray();
    for (int i = 0; i < str.Length / 2; i++)
    {
        char ch = chars[i];
        chars[i] = chars[str.Length-i-1];
        chars[str.Length-i-1] = ch;
    }
    return new string(chars);
}