// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 3 числа (после каждого нажмите Enter)");
int max = 0;
for (int index = 0; index < 3; index ++) 
{
    int num = int.Parse(Console.ReadLine()!); 
    if(num > max) 
    {
        max = num; 
    }
}
Console.WriteLine("Максимальное число = " + max);
