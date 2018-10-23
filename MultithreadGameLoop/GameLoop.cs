using System;
using System.Diagnostics;
using System.Globalization;

namespace MultithreadGameLoop
{
    internal class GameLoop
    {
        #region Fields
        private readonly int _handleInputFrequency;
        private readonly int _updateFrequency;
        private readonly int _renderFrequency;

        //private readonly Stopwatch _gameStopwatch = new Stopwatch();
        #endregion

        public GameLoop(int handleInputFrequency, int updateFrequency, int renderFrequency)
        {
            _handleInputFrequency = handleInputFrequency;
            _updateFrequency = updateFrequency;
            _renderFrequency = renderFrequency;
        }

        #region Test
        private int PrivateTestProp { get; set; } = 0;

        private void PrivateTestPropTestMethod()
        {
            PrivateTestProp = 1;

            var temp = PrivateTestProp;
        }
        #endregion

        public void Run()
        {
            //_gameStopwatch.Restart();

            // 1. get user input.
            HandleInput(_handleInputFrequency);

            // 2. Update game logic.
            //Update();

            // 3. Render.
            //Render();
        }

        private void HandleInput(int frequency)
        {
            // Timer.
            var stopwatch = Stopwatch.StartNew();
            long frequencyMilliseconds = 1000 / frequency;

            while (true)
            {
                //if (Console.ReadKey().Key == ConsoleKey.Escape)
                //{
                //    break;
                //}

                var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                if (elapsedMilliseconds >= frequencyMilliseconds)
                {
                    Console.WriteLine("[{0}] Starting HandleInput() after {1} ms.", DateTime.Now.ToString("T", DateTimeFormatInfo.InvariantInfo), elapsedMilliseconds);

                    // Input handling here...

                    stopwatch.Restart();
                }
            }
        }

        private void Update()
        {
        }

        private void Render()
        {
        }
    }
}