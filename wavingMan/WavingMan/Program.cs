using System;
using System.Threading;

namespace WavingMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var stage = new Stage();

            while (true)
            {
                stage.ShowAndMove();
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}
