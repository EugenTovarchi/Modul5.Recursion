using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Write something:");

        var str = Console.ReadLine();

        Console.WriteLine("Write number of echo deep:");
        int deep = int.Parse(Console.ReadLine());  
        
        Echo(str, deep);

        static void Echo(string phrase, int deep)
        {
            Console.WriteLine(phrase);
            var modif = phrase;
            if(modif.Length>2)
            {
                modif =modif.Remove(0, 2);
            }
            

            Console.WriteLine("..."+ modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }

        }
    }
}