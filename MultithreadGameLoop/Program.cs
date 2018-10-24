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
            // Requirements:
            //
            // X - Threads for
            // X user input,
            // X evaluation,
            // X rendering
            //
            // X - oriented approach to modeling the different threads
            //
            // X - Configurable frequencies for each thread
            //
            // X Which subsystem controls the threads? – Input manager, core engine, game logic, thread generating component?
            // X --> Thread generating component / core engine.
            //
            // Optional:
            //
            // Secure, shared data management

            const int inputLoopFrequency = 40;
            const int updateLoopFrequency = 90;
            const int renderLoopFrequency = 60;

            var gameLoop = new GameLoop(inputLoopFrequency, updateLoopFrequency, renderLoopFrequency);

            gameLoop.Start();
        }
    }
}