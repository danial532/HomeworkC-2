namespace Task1
{
    //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    class Program
    {
        public static void Main(string[] args)
        {
        Console.Clear();
        int N = GetRandomNumber();        
        Console.WriteLine ("Случайное трехзначное число:" + N);
        string str = N.ToString();
        int result = Convert.ToInt32(str[1].ToString()); 
        Console.WriteLine ("Вторая цифра числа = " + result);
        }
        private static int GetRandomNumber()
        {
            int N = new Random().Next(100, 1000);
            return N;
        }
    }
}