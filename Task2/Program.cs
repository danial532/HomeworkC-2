namespace Task2
{
    //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    class Program
    {
        public static void Main(string[] args)
        {
        Console.Clear();
        Console.WriteLine ("Введите число:");
        string str = Console.ReadLine();
         int strLen = str.Length;
         if (strLen < 3)     
            {
             Console.WriteLine ("Третьей цифры в числе нет");
            }
            else
                {
                
                int result = Convert.ToInt32(str[2].ToString());
               Console.WriteLine ("Третья цифра в числе = " + result);
                }    
        }
        
    }
        
        
}