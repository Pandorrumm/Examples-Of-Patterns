using UnityEngine;
using TMPro;

namespace StrategyPattern_1
{
    public class FlyBehavior : IFly
    {
        private Transform transform;
        private GameObject target;
        private float speed;
        private TMP_Text text;

        public FlyBehavior(Transform _transform, GameObject _target, float _speed, TMP_Text _text)
        {
            transform = _transform;
            target = _target;
            speed = _speed;
            text = _text;
        }

        public void Fly()
        {
            ShowText(text, "Я Умею Летать!");

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
