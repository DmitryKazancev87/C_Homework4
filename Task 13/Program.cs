// 13. Программа, которая задаёт массив из 8 элементов и выводит их на экран.



int [] RandomArray=new int [8];
for (int i=0;i<8;i++)
{
    RandomArray[i]=new Random().Next(0,9);
    System.Console.Write(RandomArray[i]+" ");
}



//int EnterInfomation(string message)
//{
//    Console.Write(message);
//    return int.Parse(Console.ReadLine()!);
//}
//int LengthArray = EnterInfomation(" Введите длину массива : ");
//int [] RandomArray=new int [LengthArray];
//for (int i=0;i<RandomArray.Length;i++)
//{
//    RandomArray[i]=new Random().Next(1,9);
//    System.Console.Write(RandomArray[i]+" ");
//}



