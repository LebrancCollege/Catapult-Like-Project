using System;

namespace CataParuto
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new CataParuto())
                game.Run();
        }
    }
}
