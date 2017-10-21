using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mj
{
    public class StateTest : MonoBehaviour
    {
        void Start()
        {
            Context C = new Context();
            ConcreteStateA a = new ConcreteStateA(C);
            C.SetState(a);
            C.Request(11);
            C.Request(21);
            C.Request(31);
        }
    }
}


