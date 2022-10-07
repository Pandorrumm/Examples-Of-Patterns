using UnityEngine;

namespace StrategyPattern_1
{
    public abstract class AnimalBase : MonoBehaviour
    {
        protected float speed = 0.5f;
        protected float timer = 4;

        protected IMove moveBehavior;
        protected ISpeak speakBehavior;
        protected ISleep sleepBehavior;
        protected IEat eatBehavior;
        protected IFly flyBehavior;
        protected ISwim swimBehavior;
        protected ICanNot canNotBehavior;

        #region Interface Init

        public void SetMove(IMove _moveBehavior)
        {
            moveBehavior = _moveBehavior;
        }

        public void SetSpeak(ISpeak _speakBehavior)
        {
            speakBehavior = _speakBehavior;
        }

        public void SetSleep(ISleep _spleepBehavior)
        {
            sleepBehavior = _spleepBehavior;
        }

        public void SetEat(IEat _eatBehavior)
        {
            eatBehavior = _eatBehavior;
        }

        public void SetFly(IFly _flyBehavior)
        {
            flyBehavior = _flyBehavior;
        }

        public void SetSwim(ISwim _swimBehavior)
        {
            swimBehavior = _swimBehavior;
        }

        public void SetCanNot(ICanNot _canNotBehavior)
        {
            canNotBehavior = _canNotBehavior;
        }

        #endregion

        #region BaseMethods

        protected void Move()
        {
            moveBehavior.Move();
        }

        protected void Sleep()
        {
            sleepBehavior.Sleep();
        }

        protected void Speak()
        {
            speakBehavior.Speak();
        }

        protected void Eat()
        {
            eatBehavior.Eat();
        }

        protected void Fly()
        {
            flyBehavior.Fly();
        }

        protected void Swim()
        {
            swimBehavior.Swim();
        }

        protected void CanNot()
        {
            canNotBehavior.CanNot();
        }

        #endregion
    }
}
