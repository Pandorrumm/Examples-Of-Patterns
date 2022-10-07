using UnityEngine;

namespace AbstractFactoryPattern
{
    public abstract class RobotsAbstractFactory : MonoBehaviour
    {
        public abstract GameObject CreateRobotStandart();
        public abstract GameObject CreateRobotModernized();
    }
}
