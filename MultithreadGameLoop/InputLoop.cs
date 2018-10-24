using System;

namespace MultithreadGameLoop
{
    internal class InputLoop : Loop
    {
        public override int UpdateFrequency { get; set; }

        public InputLoop(int updateFrequency) : base(updateFrequency)
        {
        }

        protected override void ExecuteLogic()
        {
            //  logic here...

            //Console.WriteLine("[{0}] Starting {1} after {2} ms.",
            //    ,
            //    ToString(),
            //    elapsedMilliseconds);
        }
    }
}