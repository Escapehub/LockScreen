using System;
using System.Threading;

namespace LockScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockInput(SelectKey());
        }
        public static void BlockInput(int span)
        {
            try
            {
                NativeMethods.BlockInput(true);
                Console.WriteLine($"Stopping input {span} miliseconds");
                Thread.Sleep(span);
            }
            finally
            {
                Console.WriteLine("Allowing Keyboard input");
                NativeMethods.BlockInput(false);
            }
        }
        public static int SelectKey()
        {
            //Console.WriteLine("Please input what hotkey you would like");
            Console.WriteLine("How long do you want to pause input (Miliseconds)");
            return int.Parse(Console.ReadLine());
        }
    }
}
