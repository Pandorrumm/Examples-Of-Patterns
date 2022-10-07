using UnityEngine;
using TMPro;

namespace StrategyPattern_1
{
    public class MoveBehavior : IMove
    {
        private TMP_Text text;
        private Transform transform;
        private GameObject target;
        private float speed;

        public MoveBehavior(Transform _transform, GameObject _target, float _speed, TMP_Text _text)
        {
            transform = _transform;
            target = _target;
            speed = _speed;
            text = _text;
        }

        public void Move()
        {           
            ShowText(text, "Я Умею Ходить!");

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
