/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

/*
Console.WriteLine("Введите число для проверки на палиндромность");
int T = Convert.ToInt32(Console.ReadLine());
int n = 1;
int count = 0;
int m = 1;
bool fail = false;
while (T/n%10 != 0)
{
    count++;
    n *= 10;
    m *= 10;
}
if (m != 1)
    m /=10;

for (int i = 0; i < count/2; i++)
{
    n = 1;
    for (int j = 0; j < i; j++)
    {
        n *= 10;
        m /= 10;
    }
    if (T/n%10 != T/m%10)
    {
        fail = true;
        break;
    }
}
if (!fail)
    Console.WriteLine("Числоя является палиндромом");
else
    Console.WriteLine("Числоя не является палиндромом");
*/



/*Напишите программу, которая принимает на вход координаты двух точек 
 * и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
int read()
{ 
    return Convert.ToInt32(Console.ReadLine());
}

void write(string coordinate, int num_dot)
{
    Console.WriteLine($"Введите координату {coordinate} {num_dot} точки:");
}

int[] arr_coordinate = new int[6];

for (int i = 0; i < 2; i ++)
{
    int b = i * 3;
    for (int j = 0; j < 3; j++)
    {
        if (j == 0)
            write("x", i+1);
        else if (j == 1)
            write("y", i+1);
        else
            write("z", i+1);
        arr_coordinate[b + j] = read();
    }
}

int size_x = arr_coordinate[0] - arr_coordinate[3];
int size_y = arr_coordinate[1] - arr_coordinate[4]; 
int size_z = arr_coordinate[2] - arr_coordinate[5];

Console.WriteLine(Math.Sqrt(Math.Pow(Math.Sqrt(Math.Pow(size_x, 2) + Math.Pow(size_y, 2)), 2) + Math.Pow(size_z, 2)));
*/





/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*
Console.WriteLine("Введите число, до которого вывести кубы чисел:");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}
*/