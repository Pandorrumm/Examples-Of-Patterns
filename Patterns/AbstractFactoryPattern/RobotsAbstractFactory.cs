using UnityEngine;

namespace AbstractFactoryPattern
{
    public abstract class RobotsAbstractFactory
    {
        public abstract GameObject CreateRobotStandart();
        public abstract GameObject CreateRobotModernized();
    }
}
