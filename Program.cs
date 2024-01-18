using MoreCSharpFun;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //Constructor
        PrintStuff ps = new PrintStuff();

        string name = "";

        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }

}