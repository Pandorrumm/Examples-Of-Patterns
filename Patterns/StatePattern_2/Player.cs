using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace StatePattern_2
{
    public class Player : MonoBehaviour
    {
       // [SerializeField] private TextMeshProUGUI stateText;
        public TextMeshProUGUI stateText;

        public Animator anim;
       
        private StateMachine stateMachine;

        private RunState runState;
        private IdleState idleState;
        private JumpState jumpState;

        private void Start()
        {
            stateMachine = new StateMachine();

            runState = new RunState(this);
            idleState = new IdleState(this);
            jumpState = new JumpState(this);

            stateMachine.Initialize(idleState);
        }

        private void Update()
        {
            stateMachine.CurrentState.Update();

            if (Input.GetKeyDown(KeyCode.R))
            {
                stateMachine.ChangeState(runState);
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                stateMachine.ChangeState(idleState);
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                stateMachine.ChangeState(jumpState);
            }
        }
    }
}
