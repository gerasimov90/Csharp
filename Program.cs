//Console.Write("Введите любое трехзначное число:");
//int number = Convert.ToInt32(Console.ReadLine());

//int firstnumb = number / 100;

//int secondnumb = (number - firstnumb*100)/10;

//Console.Write("Вторая цифра введенного числа: ");
//Console.WriteLine(secondnumb);





//Console.Write("Введите любое число:");
//int number = Convert.ToInt32(Console.ReadLine());
//
//if (number < 100)
//{
//   Console.WriteLine("Третьей цифры нет");
//}
//else if (number < 1000 && number >= 100)
//{
//    int thirdnumb = number % 10;
//
//
//Console.Write("Третья цифра введенного числа: ");
//Console.WriteLine(thirdnumb);
//}
//
//else if (number < 10000 && number >= 1000)
//{
//    int thirdnumb = (number % 100)/10;
//
//
//Console.Write("Третья цифра введенного числа: ");
//Console.WriteLine(thirdnumb);
//}


Console.Write("Введите число, обозначающее день недели :");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6)
{
    Console.WriteLine("Нет, этот день не выходной");
}
else if (number <= 7 && number > 5)
{
    Console.WriteLine("Да, этот день выходной");
}

else if (number > 7)
{
Console.WriteLine("В неделе всего 7 дней)))");
}