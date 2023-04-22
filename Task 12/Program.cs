// 12. Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

int EnterInfomation(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Number = EnterInfomation(" Введите число : ");
int Length = NumberLength(Number);
SumNumbers(Number,Length);

// Функция нахождения количества цифр в числе:
int NumberLength (int a)
{
    int index = 0;
    while (a>0)
    {
    a=a/10;
    index++;
    }
    return index;
}
    
// Функция вывода сумм цифр в числе:

void SumNumbers (int N, int Length)
{
int sum=0;
for (int i=1; i<=Length;i++)
{
sum=sum%10;
N=N/10;
}
System.Console.WriteLine(sum);
}

// Ввод через фунцию EnterInformation:

//int EnterInfomation (string message)
//{
//    Console.Write (message);
//    return int.Parse (Console.ReadLine());
//}
//int Number = EnterInfomation(" Введите число N : ");
//for (int i = 1; i <= Number; i++)
//{
//       Console.Write($"{i*i*i}  ");}
