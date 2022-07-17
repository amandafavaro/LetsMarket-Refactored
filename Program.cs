using LetsMarket.Menu;
using LetsMarket.Validations;

namespace LetsMarket
{
    public class Program
    {
        static void Main()
        {
            MenuItem.SetPrompt();
            Console.Title = "Let's Store";

            Login.VerifyLogin();

            MenuInitialization.InitializeMenu();            
            
        }
    }
}