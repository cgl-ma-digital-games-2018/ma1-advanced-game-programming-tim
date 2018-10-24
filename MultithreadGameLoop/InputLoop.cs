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
        }
    }
}