namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage<string> storage = new Storage<string>();
            UserInterface.Run(storage);
        }
    }

}