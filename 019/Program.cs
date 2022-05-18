// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

//int number = new Random().Next(10000,100000);
//string strr = number.ToString();
int GetNumber(string msg)
{
while(true)
{
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if(number > 10000 && number < 100000)
            return number;

        else  
        {
            Console.WriteLine("Число должно быть пятизначным");

        }  

    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число");

    }

}
}


void IsPalindrome(string number)
{
 for (int i =0; i < number.Length / 2; i++)
 {
       if (number[i] != number[number.Length -1 - i])
        Console.WriteLine($"{number} - > нет");
        return;
   
  }  
  Console.WriteLine($"{number} - > да");
  return;
}

string messageX= "Число х:";
int x = GetNumber(messageX);
if (messageX.Reverse().SequenceEqual(messageX)) Console.WriteLine("Палиндром!");






/* bool IsPalindrome(string number)
{
    for (int i = 0; i < number.Length / 2; ++i)
        if (number[i] != number[number.Length - 1 - i]) return false;
    return true;
}
*/


/* void Polindrom(string number)
{

int len = number.length();
for (int i =0; i < len / 2; ++i)
{
 if(number[i] != number [len-i-1])
{ 
    Console.WriteLine($"{number} - > да");  

}
else 
{
      Console.WriteLine($"{number} - > нет");
}
}
*/



/* void IsPalindrome(string number)
{
 for (int i =0; i < number.Length / 2; i++)
 {
       if (number[i] != number[number.Length -1 - i])
        Console.WriteLine($"{number} - > нет");
        return;
   
  }  
  Console.WriteLine($"{number} - > да");
  return;
}

string messageX= "Число х:";
int x = GetNumber(messageX);
if (messageX.Reverse().SequenceEqual(messageX)) Console.WriteLine("Палиндром!");
*/



//bool result = IsPalindrome(true);
//Console.WriteLine(result);


//функция, которая получает число, введенное с клавиатуры
// + проверка на то, что ввели именно число
// + проверка, что число != 0

/* int GetNumber(string msg)
{
while(true)
{
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if(number > 10000 && number < 100000)
            return number;

        else  
        {
            Console.WriteLine("Число должно быть пятизначным");

        }  

    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число");

    }

}
}

string messageX = "Введите число х";


int x = GetNumber(messageX);

int Polindrom(x)
{
int Len = x.length();
for (int i =0; i < len / 2; ++i)
{
 if(x[i]) != x [len-i-1])
{
        return false;
}
*/

        
        
    