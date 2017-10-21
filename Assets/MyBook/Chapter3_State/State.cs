using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mj
{
    public class Context
    {
        private State m_State = null;

        public void SetState(State state)
        {
            m_State = state;
        }

        public void Request(int value)
        {
            m_State.Handle(value);
        }
    }

    public abstract class State
    {
        protected Context m_Context = null;

        public State(Context context)
        {
            m_Context = context;
        }

        public abstract void Handle(int value);
    }

    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context context) : base(context)
        {

        }

        public override void Handle(int value)
        {
            Debug.Log("ConcreteStateA.Handle(), value="+value);

            if(value > 10)
            {
                Debug.Log("ConcreteStateA.Handle(), Change To StateB");
                m_Context.SetState(new ConcreteStateB(m_Context));
            }
        }
    }

    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context context) : base(context)
        {
        }

        public override void Handle(int value)
        {
            Debug.Log("ConcreteStateB.Handle(), value=" + value);

            if (value > 20)
            {
                Debug.Log("ConcreteStateB.Handle(), Change To StateC");
                m_Context.SetState(new ConcreteStateC(m_Context));
            }
        }
    }

    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context context) : base(context)
        {
        }

        public override void Handle(int value)
        {
            Debug.Log("ConcreteStateC.Handle(), value=" + value);

            if (value > 30)
            {
                Debug.Log("ConcreteStateC.Handle(), Change To StateA");
                m_Context.SetState(new ConcreteStateA(m_Context));
            }
        }
    }
}


