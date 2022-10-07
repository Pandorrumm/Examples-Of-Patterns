using UnityEngine;

namespace AbstractFactoryPattern
{
    public class RobotWorkerFactory : RobotsAbstractFactory
    {
        private GameObject standartRobotWorkerPrefab;
        private GameObject modernizedRobotWorkerPrefab;
        private Transform spawnPoint;
        private Transform targetPointMovement;

        public RobotWorkerFactory(Transform _spawnPoint, GameObject _standartRobot, GameObject _modernizedRobot, Transform _targetPointMovement)
        {
            spawnPoint = _spawnPoint;
            standartRobotWorkerPrefab = _standartRobot;
            modernizedRobotWorkerPrefab = _modernizedRobot;
            targetPointMovement = _targetPointMovement;
        }

        public override GameObject CreateRobotStandart()
        {
            var standartRobotWorker = Instantiate(standartRobotWorkerPrefab, spawnPoint.position, Quaternion.identity);
            standartRobotWorker.GetComponent<RobotMovement>().GetTargetPoint(targetPointMovement);
            return standartRobotWorker;
        }

        public override GameObject CreateRobotModernized()
        {
            var modernizedRobotWorker = Instantiate(modernizedRobotWorkerPrefab, spawnPoint.position, Quaternion.identity);
            modernizedRobotWorker.GetComponent<RobotMovement>().GetTargetPoint(targetPointMovement);
            return modernizedRobotWorker;
        }    
    }
}
