namespace mj
{
    public class ISceneState
    {
        //控制者
        protected SceneStateController m_SceneStateController = null;

        //状态名称
        private string m_StateName = "ISceneState";

        //建造者
        public ISceneState(SceneStateController controller)
        {
            m_SceneStateController = controller;
        }

        public string StateName
        {
            get { return m_StateName; }
            set { m_StateName = value; }
        }

        //开始
          public virtual void StateBegin()
        {

        }

        //结束
        public virtual void StateEnd()
        {

        }

        //更新
        public virtual void StateUpdate()
        {

        }

        public override string ToString()
        {
            return string.Format("ISceneState: StateName={0}", StateName);
        }
    }

}
