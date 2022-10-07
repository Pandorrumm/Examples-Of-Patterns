using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_2
{
    public class IdleState : State
    {
        private Player player;

        public IdleState(Player _player)
        {
            player = _player;
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("IN STATE - IDLE");
            player.anim.CrossFade("Idle", 0.1f);
            player.stateText.text = "State Idle";
        }

        public override void Exit()
        {
            base.Exit();
            Debug.Log("OUT STATE - IDLE");
        }
    }
}
