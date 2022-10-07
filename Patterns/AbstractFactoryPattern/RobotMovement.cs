using UnityEngine;
using DG.Tweening;

namespace AbstractFactoryPattern
{
    public class RobotMovement : MonoBehaviour
    {
        [SerializeField] private float lifetime = 3f;
        [SerializeField] private float durationMovement = 4f;

        private Transform targetPointMovement;

        private void Start()
        {           
            DOTween.Sequence()
                     .AppendInterval(lifetime)
                     .AppendCallback(() => gameObject.SetActive(false));

            transform.DOMove(targetPointMovement.position, durationMovement); 
        }

        public void GetTargetPoint(Transform _targetPointMovement)
        {
            targetPointMovement = _targetPointMovement;
        }
    }
}