using UnityEngine;

namespace StrategyPattern_2
{
    public interface IMovable
    {
        void Move(Transform transform, float speed);
    }
}
