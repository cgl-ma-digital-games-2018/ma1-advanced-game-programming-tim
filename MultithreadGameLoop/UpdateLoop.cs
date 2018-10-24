namespace MultithreadGameLoop
{
    internal class UpdateLoop : Loop
    {
        public override int UpdateFrequency { get; set; }

        public UpdateLoop(int updateFrequency) : base(updateFrequency)
        {
        }

        protected override void ExecuteLogic()
        {
            // update logic...
        }
    }
}