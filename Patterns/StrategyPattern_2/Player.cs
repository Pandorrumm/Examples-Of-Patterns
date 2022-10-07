using UnityEngine;

namespace StrategyPattern_2
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed = 2f;

        private IMovable movable;

        private void Start()
        {
            movable = new MovableXY(); 
        }
        private void Update()
        {
            movable.Move(transform, speed);

            if (Input.GetKeyDown(KeyCode.Z))
            {
                ChangeMovable(new MovableXY());
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                ChangeMovable(new MovableX());
            }
        }

        private void ChangeMovable(IMovable _movable)
        {
            this.movable = _movable;
        }
    }
}
