using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace MultithreadGameLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int inputFrequency = 40;
            const int updateFrequency = 90;
            const int renderFrequency = 60;

            var gameLoop = new GameLoop(inputFrequency, updateFrequency, renderFrequency);

            gameLoop.Run();

            //Console.ReadKey();

            // Requirements:
            //
            // - Threads for
            // user input,
            // evaluation,
            // rendering
            //
            // - Object-oriented approach to modeling the different threads
            //
            // - Configurable frequencies for each thread
            //
            // Which subsystem controls the threads? – Input manager, core engine, game logic, threadgenerating component?
            //
            // Optional:
            //
            // Secure, shared data management
        }
    }
}