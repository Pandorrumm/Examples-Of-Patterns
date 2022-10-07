using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

namespace StrategyPattern_1
{
    public class Cat : AnimalBase
    {
        public Dictionary<string, Action> behaviors;

        [SerializeField] private GameObject moveTarget;
        [SerializeField] private Animator animator;
        [SerializeField] private TMP_Text text;

        private void Awake()
        {
            SetSpeak(new MauBehavior(text));
            SetMove(new MoveBehavior(transform, moveTarget, speed, text));
            SetEat(new EatBehavior(text));
            SetSleep(new SleepBehavior(text));
            SetCanNot(new CanNotBehavior(text));

            behaviors = new Dictionary<string, Action>()
            {
                { "speak", Speak },  // по ключу вызывается метод через Action
                { "move", Move },
                { "eat", Eat },
                { "sleep", Sleep },
                { "canNot", CanNot }
            };
        }

        private void OnMouseDown()
        {
            PanelController.instance.Reset();
            PanelController.instance.curAnimalObj = this;
            PanelController.instance.behaviours = behaviors;

            animator.CrossFade("ChoiceCat", 0.1f);
        }
    }
}
