using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace MultithreadGameLoop
{
    internal class GameLoop
    {
        #region Fields
        private readonly InputLoop _inputLoop;
        private readonly UpdateLoop _updateLoop;
        private readonly RenderLoop _renderLoop;

        //private readonly Stopwatch _gameStopwatch = new Stopwatch();
        #endregion

        public GameLoop(int inputFrequency, int updateFrequency, int renderFrequency)
        {
            _inputLoop = new InputLoop(inputFrequency);
            _updateLoop = new UpdateLoop(updateFrequency);
            _renderLoop = new RenderLoop(renderFrequency);
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
            // TODO: Run() needs to take an object in order to work!?
            var inputThread = new Thread(inputLoop.Run);

            // 2. Update game logic.
            updateLoop.Run(_updateFrequency);

            // 3. Render.
            renderLoop.Run(_renderFrequency);
        }
    }
}