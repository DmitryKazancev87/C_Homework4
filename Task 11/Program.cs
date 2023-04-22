// 11. цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int EnterInfomation(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int NumberA = EnterInfomation(" Введите число A : ");
int NumberB = EnterInfomation(" Введите число B : ");

// Функция ввода в степень

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1, i < = b, i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

Degree(NumberA, NumberB);

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


