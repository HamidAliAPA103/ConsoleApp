using Courseapp.Helpers;

namespace Courseapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.ConsolColor(ConsoleColor.Cyan, "Select one opetions! ");
            Helper.ConsolColor(ConsoleColor.Yellow, "1 - Creat group,2 - Get Library,3 - GetAll libraries,4 - Delete Library,5 - Update Library ");
        }
    }
}
