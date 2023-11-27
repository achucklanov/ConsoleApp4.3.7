namespace ConsoleApp4._3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя :");

            var name = Console.ReadLine();

            for ( int i = name.Length - 1; i >= 0; i-- )
            {
            Console.Write(name[i] +" ");
            }

            Console.ReadKey();
        }
    }
}