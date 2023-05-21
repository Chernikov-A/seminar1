//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2){
    Console.WriteLine("max = " + number1);
}else {
    Console.WriteLine("max = "+number2);
}
*/
///////////////////////////////////////////////////////////////

/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3){
    Console.WriteLine("MAX = " + number1);
}else if (number2 > number3){
    Console.WriteLine("MAX = " + number2);
}else {
    Console.WriteLine("MAX = " + number3);
}
*/
/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */
/*Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 %2 == 0){
    Console.WriteLine("Четное и делится на 2");
}else {
    Console.WriteLine("Нечетное и не делится на 2");
}
*/
/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
/*
int i =0;
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());

for (i = 1; i<=number1; i++){
    if(i %2 ==0){
        Console.WriteLine(i);
    }
}
*/