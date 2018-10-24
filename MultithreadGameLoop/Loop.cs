using System;
using System.Diagnostics;
using System.Globalization;

namespace MultithreadGameLoop
{
    internal abstract class Loop
    {
        public abstract int UpdateFrequency { get; set; }

        public Loop(int updateFrequency)
        {
            UpdateFrequency = updateFrequency;
        }

        /// <summary>
        /// Runs the independent loop.
        /// </summary>
        public void Run()
        {
            // Initializes and starts a Timer.
            var stopwatch = Stopwatch.StartNew();

            long frequencyMilliseconds = 1000 / UpdateFrequency;

            // The actual loop.
            while (true)
            {
                //if (Console.ReadKey().Key == ConsoleKey.Escape)
                //{
                //    break;
                //}

                var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                // Prevents logic from executing more frequently than executionFrequency.
                if (elapsedMilliseconds >= frequencyMilliseconds)
                {
                    // Executes the specific logic.
                    ExecuteLogic();

                    // Restarts the timer.
                    stopwatch.Restart();
                }
            }
        }

        /// <summary>
        /// Includes the actual logic to execute within the loop.
        /// </summary>
        protected abstract void ExecuteLogic();

        /// <summary>
        /// Gets the system time.
        /// </summary>
        /// <returns>System time as a string.</returns>
        private string GetSystemTimeAsString()
        {
            return DateTime.Now.ToString("T", DateTimeFormatInfo.InvariantInfo);
        }
    }
}