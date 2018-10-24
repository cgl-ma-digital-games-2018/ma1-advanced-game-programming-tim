using System;
using System.Diagnostics;
using System.Globalization;

namespace MultithreadGameLoop
{
    internal abstract class Loop
    {
        /// <summary>
        /// Runs the independent loop.
        /// </summary>
        /// <param name="executionFrequency">The max frequency in Hz at which the loop should run.</param>
        public void Run(int executionFrequency)
        {
            // Initializes and starts a Timer.
            var stopwatch = Stopwatch.StartNew();

            long frequencyMilliseconds = 1000 / executionFrequency;

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
                    Console.WriteLine("[{0}] Starting {1} after {2} ms.",
                        GetSystemTimeAsString(),
                        ToString(),
                        elapsedMilliseconds);

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