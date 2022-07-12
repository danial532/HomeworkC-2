namespace Task3
{
    //Напишите программу, которая принимает на вход цифру, обозначающую день 
    //недели, и проверяет, является ли этот день выходным.
    class Program
    {
        public static void Main(string[] args)
        {
        Console.Clear();
        Console.WriteLine ("Введите цифру, обозначающую день недели ");
        int N = Convert.ToInt32(Console.ReadLine());
        if ( N > 7 ) { Console.WriteLine ("нет такого дня недели");}
        else
            {if (N == 0) { Console.WriteLine ("нет такого дня недели");}
            else
                {if ( N == 1 )
                { Console.WriteLine ("Понедельник - рабочий день"); }
                if (N == 2)
                { Console.WriteLine ("Вторник - рабочий день"); }
                if (N == 3)
                { Console.WriteLine ("Среда - рабочий день"); }
                if (N == 4)
                { Console.WriteLine ("Четверг - рабочий день"); }
                if (N == 5)
                { Console.WriteLine ("Пятница - рабочий день"); }
                if (N == 6)
                { Console.WriteLine ("Ура! Суббота - выходной"); }
                if (N == 7)
                { Console.WriteLine ("Ура! Воскресенье - выходной"); }
                }
            }
        
        }
    }
}
