using UnityEngine;

namespace StrategyPattern_2
{
    public class MovableXY : IMovable
    {
        public void Move(Transform transform, float speed)
        {
            var input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
            transform.Translate(input);
        }
    }
}
