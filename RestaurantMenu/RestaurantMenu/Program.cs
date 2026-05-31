namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppMenu menu = new AppMenu();

            menu.Run();

            Console.ReadKey();
        }
    }
}
