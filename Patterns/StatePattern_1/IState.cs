using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_1
{
    public interface IState
    {
        void Enter();
        void Tick();  //Update()    
        void FixedTick();  //FixedUpdate()
        void Exit();
    }
}
