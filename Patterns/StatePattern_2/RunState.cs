using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_2
{
    public class RunState : State
    {
        private Player player;

        public RunState(Player _player)
        {
            player = _player;
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("IN STATE - RUN");
            player.anim.CrossFade("Run", 0.1f);
            player.stateText.text = "State Run";
        }

        public override void Exit()
        {
            base.Exit();
            Debug.Log("OUT STATE - RUN");
        }

        public override void Update()
        {
            base.Update();
            Debug.Log("RUNNING NOW");
        }
    }
}
