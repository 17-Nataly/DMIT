// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Жора, твоя мама очень сексуальная");
/*int x = 5;
Console.WriteLine(x);*/
/*string str1 = "some string1";
string str2 = "some string2";
string str3 = str1 + " " + str2;
Console.WriteLine(str3);*/
//double PI = 3.14;
//Console.WriteLine(Math.PI);
/*string x = null;
string x2 = x + "some";
Console.WriteLine(x2);*/
/*int a = 15;
sbyte b = (sbyte)a;
Console.WriteLine(b);*/
/*byte agression = 1;
int changeAgression = agression -2;
agression = (byte)changeAgression;
Console.WriteLine(agression);*/
/*Console.WriteLine("Введите число:");
string x = Console.ReadLine();
int a = Convert.ToInt32(x);
a = a * a;
Console.WriteLine(a);*/
/*Console.WriteLine("Введите возраст вашей девушки:");
int years = Convert.ToInt32(Console.ReadLine());
if (years > 16)
{
    Console.WriteLine("Tooooooo old");
}
else
{
    Console.WriteLine("Тесак уже выезжает за тобой");
}*/
/*Console.WriteLine("введите год вашего рождения");
int x = Convert.ToInt32(Console.ReadLine());
if(x > 2017)
{
    Console.WriteLine("Ты либо из будущего, либо балабол.");
    Console.WriteLine("Что-то я не вижу рядом машину времени...");
}
else if(x > 2010)
{
    Console.WriteLine("Ути пути какой малыш");   
}
else
{
    Console.WriteLine("Привет, тут контент для тебя");  
}*/
/*Console.WriteLine("введите год вашего рождения");
int x = Convert.ToInt32(Console.ReadLine());

bool result = x > 2017;

if(result)
{
    Console.WriteLine("Магия");
}*/
/* тернарный оператор
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

string result = x > 100 ? "больше 100" : "меньше 100";

Console.WriteLine("Результат " + result);*/
Console.WriteLine("введите число ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
    Console.WriteLine("число 1");
    break;
    case 2:
    Console.WriteLine("число 2");
    break;
    case 3:
    Console.WriteLine("число 3");
    break;
    default:
    Console.WriteLine("хз какое число");
    break;
}
