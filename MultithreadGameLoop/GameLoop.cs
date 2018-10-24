using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace MultithreadGameLoop
{
    internal class GameLoop
    {
        #region Fields
        private readonly int _inputFrequency;
        private readonly int _updateFrequency;
        private readonly int _renderFrequency;

        //private readonly Stopwatch _gameStopwatch = new Stopwatch();
        #endregion

        public GameLoop(int inputFrequency, int updateFrequency, int renderFrequency)
        {
            _inputFrequency = inputFrequency;
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
            var inputLoop = new InputLoop();
            // TODO: Run() needs to take an object in order to work!?
            var inputThread = new Thread(inputLoop.Run);

            // 2. Update game logic.
            var updateLoop = new UpdateLoop();
            updateLoop.Run(_updateFrequency);

            // 3. Render.
            var renderLoop = new RenderLoop();
            renderLoop.Run(_renderFrequency);
        }
    }
}