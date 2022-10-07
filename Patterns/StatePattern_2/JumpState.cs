using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_2
{
    public class JumpState : State
    {
        private Player player;

        public JumpState(Player _player)
        {
            player = _player;
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("IN STATE - JUMP");
            player.anim.CrossFade("Jump", 0.1f);
            player.stateText.text = "State Jump";
        }

        public override void Exit()
        {
            base.Exit();
            Debug.Log("OUT STATE - JUMP");
        }
    }
}
