using UnityEngine;

namespace AbstractFactoryPattern
{
    public class RobotWarriorFactory : RobotsAbstractFactory
    {
        private GameObject standartRobotWarriorPrefab;
        private GameObject modernizedRobotWarriorPrefab;
        private Transform spawnPoint;
        private Transform targetPointMovement;

        public RobotWarriorFactory(Transform _spawnPoint, GameObject _standartRobot, GameObject _modernizedRobot, Transform _targetPointMovement)
        {
            spawnPoint = _spawnPoint;
            standartRobotWarriorPrefab = _standartRobot;
            modernizedRobotWarriorPrefab = _modernizedRobot;
            targetPointMovement = _targetPointMovement;
        }

        public override GameObject CreateRobotStandart()
        {
            var standartRobotWarrior = Instantiate(standartRobotWarriorPrefab, spawnPoint.position, Quaternion.identity);
            standartRobotWarrior.GetComponent<RobotMovement>().GetTargetPoint(targetPointMovement);
            return standartRobotWarrior;
        }

        public override GameObject CreateRobotModernized()
        {
            var modernizedRobotWarrior = Instantiate(modernizedRobotWarriorPrefab, spawnPoint.position, Quaternion.identity);
            modernizedRobotWarrior.GetComponent<RobotMovement>().GetTargetPoint(targetPointMovement);
            return modernizedRobotWarrior;
        }
    }
}
