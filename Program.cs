//Console.Write("Введите любое трехзначное число:");
//int number = Convert.ToInt32(Console.ReadLine());

//int firstnumb = number / 100;

//int secondnumb = (number - firstnumb*100)/10;

//Console.Write("Вторая цифра введенного числа: ");
//Console.WriteLine(secondnumb);





Console.Write("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number < 1000 && number >= 100)
{
    int thirdnumb = number % 100;

}
Console.Write("Третья цифра введенного числа: ");
Console.WriteLine(thirdnumb);