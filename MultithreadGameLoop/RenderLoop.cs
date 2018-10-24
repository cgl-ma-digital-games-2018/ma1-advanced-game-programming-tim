namespace MultithreadGameLoop
{
    internal class RenderLoop : Loop
    {
        public override int UpdateFrequency { get; set; }

        public RenderLoop(int updateFrequency) : base(updateFrequency)
        {
        }

        protected override void ExecuteLogic()
        {
            // logic here...
        }
    }
}