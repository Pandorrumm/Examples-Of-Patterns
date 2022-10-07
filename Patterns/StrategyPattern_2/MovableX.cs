using UnityEngine;

namespace StrategyPattern_2
{
    public class MovableX : IMovable
    {
        public void Move(Transform transform, float speed)
        {
            var input = new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speed * Time.deltaTime;
            transform.Translate(input);
        }
    }
}
