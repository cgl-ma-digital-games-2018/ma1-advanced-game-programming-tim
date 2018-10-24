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

        private readonly Stopwatch _gameStopwatch = new Stopwatch();
        #endregion

        public GameLoop(int inputLoopFrequency, int updateLoopFrequency, int renderLoopFrequency)
        {
            _inputLoop = new InputLoop(inputLoopFrequency);
            _updateLoop = new UpdateLoop(updateLoopFrequency);
            _renderLoop = new RenderLoop(renderLoopFrequency);
        }

        public void Start()
        {
            _gameStopwatch.Restart();

            // 1. get user input.
            var inputThread = new Thread(new ThreadStart(_inputLoop.Run));
            inputThread.Start();

            // 2. Update game logic.
            var updateThread = new Thread(new ThreadStart(_updateLoop.Run));
            updateThread.Start();

            // 3. Render.
            var renderThread = new Thread(new ThreadStart(_renderLoop.Run));
            renderThread.Start();
        }
    }
}