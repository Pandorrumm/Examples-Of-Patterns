using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

namespace StrategyPattern_1
{
    public class PanelController : MonoBehaviour
    {
        public static PanelController instance;
        public AnimalBase curAnimalObj;
        public Dictionary<string, Action> behaviours;

        [Header("Buttons")]
        [SerializeField] private Button moveButton = null;
        [SerializeField] private Button speakButton = null;
        [SerializeField] private Button eatButton = null;
        [SerializeField] private Button flyButton = null;
        [SerializeField] private Button sleepButton = null;
        [SerializeField] private Button swimButton = null;

        private bool move;
        private bool fly;
        private float _timer;

        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            moveButton.onClick.AddListener(MoveButton);
            speakButton.onClick.AddListener(SpeakButton);
            eatButton.onClick.AddListener(EatButton);
            flyButton.onClick.AddListener(FlyButton);
            sleepButton.onClick.AddListener(SleepButton);
            swimButton.onClick.AddListener(SwimButton);
        }

        private void Update()
        {
            if (_timer < 1)
            {
                _timer += Time.deltaTime;

                if (move)
                {
                    behaviours["move"].Invoke();
                }

                if (fly)
                {
                    behaviours["fly"].Invoke();
                }
            }
        }

        public void Reset()
        {
            move = false;
            fly = false;
            _timer = 0;
        }

        public void MoveButton()
        {
            Reset();

            try
            {
                if (behaviours.Keys.Contains("move"))
                {
                    move = true;
                }
                else
                {
                    behaviours["canNot"].Invoke();
                }
            }
            catch (Exception e)
            {

                Debug.LogError("Животное не выбрано!");
            }
        }

        public void SpeakButton()
        {
            Reset();

            try
            {
                if (behaviours.Keys.Contains("speak"))
                {
                    behaviours["speak"].Invoke();
                }
                else
                {
                    behaviours["canNot"].Invoke();
                }
            }
            catch (Exception e)
            {

                Debug.LogError("Животное не выбрано!");
            }
        }

        public void EatButton()
        {
            Reset();

            try
            {
                if (behaviours.Keys.Contains("eat"))
                {
                    behaviours["eat"].Invoke();
                }
                else
                {
                    behaviours["canNot"].Invoke();
                }
            }
            catch (Exception e)
            {

                Debug.LogError("Животное не выбрано!");
            }
        }

        public void FlyButton()
        {
            Reset();

            try
            {
                if (behaviours.Keys.Contains("fly"))
                {
                    fly = true;
                }
                else
                {
                    behaviours["canNot"].Invoke();
                }
            }
            catch (Exception e)
            {

                Debug.LogError("Животное не выбрано!");
            }
        }

        public void SleepButton()
        {
            Reset();

            try
            {
                if (behaviours.Keys.Contains("sleep"))
                {
                    behaviours["sleep"].Invoke();
                }
                else
                {
                    behaviours["canNot"].Invoke();
                }
            }
            catch (Exception e)
            {

                Debug.LogError("Животное не выбрано!");
            }
        }

        public void SwimButton()
        {
            Reset();

            try
            {
                if (behaviours.Keys.Contains("swim"))
                {
                    behaviours["swim"].Invoke();
                }
                else
                {
                    behaviours["canNot"].Invoke();
                }
            }
            catch (Exception e)
            {

                Debug.LogError("Животное не выбрано!");
            }
        }
    }
}
