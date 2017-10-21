using UnityEngine;

namespace mj
{
    public class MainMenuState : ISceneState
    {
        public MainMenuState(SceneStateController controller) : base(controller)
        {
            this.StateName = "MainMenuState";
        }

        public override void StateBegin()
        {
            //获取开始按钮
            
        }

        public override void StateUpdate()
        {
            base.StateUpdate();
        }

        public override void StateEnd()
        {
            base.StateEnd();
        }
    }
}

