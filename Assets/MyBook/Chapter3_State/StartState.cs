namespace mj
{
    public class StartState : ISceneState
    {
        public StartState(SceneStateController Controller) : base(Controller)
        {
            this.StateName = "StartState";
        }
  
    }
}

