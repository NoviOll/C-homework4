// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
class Program
{
    static void Main(string[] args)
    {
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for(int i = 0; i < B; i++)
        {
             result = result * A;
        } 
        Console.WriteLine(result);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
class Program
{
    static void Main(string[] args)
    {
        string strA = Convert.ToString(Console.ReadLine());
        int[] A = new int[strA.Length];
        int sum = 0;
        for(int i = 0; i < A.Length; i++) 
        {
            A[i] = int.Parse(Convert.ToString(strA[i]));
            sum = sum + A[i];
        }
        Console.Write(sum);
    }
}


// Напишите программу, которая задаёт массив из N элементов и выводит их на экран
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Введите элементы массива через enter");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
        Console.Write(array[i] + " ");
        }
    }
}