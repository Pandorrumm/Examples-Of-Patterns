using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_1
{
    public class StateMachine : MonoBehaviour
    {
        public IState CurrentState { get; private set; }
        public IState previousState;

        private bool inTransition = false;

        public void ChangeState(IState _newState)
        {
            if (CurrentState == _newState || inTransition)
            {
                return;
            }

            ChangeStateRoutine(_newState);
        }

        public void RevertState()
        {
            if (previousState != null)
            {
                ChangeState(previousState);
            }
        }

        private void ChangeStateRoutine(IState _newState)
        {
            inTransition = true;

            if (CurrentState != null)
            {
                CurrentState.Exit();
            }

            if (previousState != null)
            {
                previousState = CurrentState;
            }

            CurrentState = _newState;

            if (CurrentState != null)
            {
                CurrentState.Enter();
            }

            inTransition = false;
        }

        private void Update()
        {
            if (CurrentState != null || !inTransition)
            {
                CurrentState.Tick();
            }
        }

        private void FixedUpdate()
        {
            if (CurrentState != null || !inTransition)
            {
                CurrentState.FixedTick();
            }
        }
    }
}
