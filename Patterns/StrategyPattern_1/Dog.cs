using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

namespace StrategyPattern_1
{
    public class Dog : AnimalBase
    {
        public Dictionary<string, Action> behaviors;

        [SerializeField] private GameObject moveTarget;
        [SerializeField] private Animator animator;
        [SerializeField] private TMP_Text text;

        private void Awake()
        {
            SetSpeak(new BawBehavior(text));
            SetMove(new MoveBehavior(transform, moveTarget, speed, text));
            SetEat(new EatBehavior(text));
            SetSleep(new SleepBehavior(text));
            SetSwim(new SwimBehavior(text));
            SetCanNot(new CanNotBehavior(text));

            behaviors = new Dictionary<string, Action>()
            {
                { "speak", Speak },
                { "move", Move },
                { "eat", Eat },
                { "sleep", Sleep },
                { "swim", Swim },
                { "canNot", CanNot }
            };
        }

        private void OnMouseDown()
        {
            PanelController.instance.Reset();
            PanelController.instance.curAnimalObj = this;
            PanelController.instance.behaviours = behaviors;

            animator.CrossFade("ChoiceDog", 0.1f);
        }
    }
}
