using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

namespace StrategyPattern_1
{
    public class Turtle : AnimalBase
    {
        public Dictionary<string, Action> behaviors;

        [SerializeField] private Animator animator;
        [SerializeField] private TMP_Text text;

        private void Awake()
        {
            SetEat(new EatBehavior(text));
            SetSleep(new SleepBehavior(text));
            SetCanNot(new CanNotBehavior(text));

            behaviors = new Dictionary<string, Action>()
            {
                { "eat", Eat },
                { "sleep", Sleep },
                { "canNot", CanNot }
            };
        }

        private void OnMouseDown()
        {
            PanelController.instance.curAnimalObj = this;
            PanelController.instance.behaviours = behaviors;

            animator.CrossFade("ChoiceTurtle", 0.1f);
        }
    }
}
