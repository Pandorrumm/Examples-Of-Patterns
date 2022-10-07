using UnityEngine;
using UnityEngine.UI;

namespace AbstractFactoryPattern
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private Transform spawnPointWorker;
        [SerializeField] private Transform spawnPointWarrior;

        [Space]
        [SerializeField] private Transform targetPointWorker;
        [SerializeField] private Transform targetPointWarrior;

        [Space]
        [SerializeField] private GameObject standartRobotWorkerPrefab = null;
        [SerializeField] private GameObject modernizedRobotWorkerPrefab = null;

        [Space]
        [SerializeField] private GameObject standartRobotWarriorPrefab = null;
        [SerializeField] private GameObject modernizedRobotWarriorPrefab = null;

        [Space]
        [SerializeField] private Button createStandartWorker = null;
        [SerializeField] private Button createModernizedWorker = null;
        [SerializeField] private Button createStandartWarrior = null;
        [SerializeField] private Button createModernizedWarrior = null;

        private RobotsAbstractFactory robotsAbstractFactory;

        private void Start()
        {
            createStandartWorker.onClick.AddListener(CreateStandartWorkerRobot);
            createModernizedWorker.onClick.AddListener(CreateModernizedWorkerRobot);
            createStandartWarrior.onClick.AddListener(CreateStandartWarriorRobot);
            createModernizedWarrior.onClick.AddListener(CreateModernizedWarriorRobot);
        }

        private void CreateStandartWorkerRobot()
        {
            robotsAbstractFactory = new RobotWorkerFactory(spawnPointWorker, standartRobotWorkerPrefab,
                                                           modernizedRobotWorkerPrefab, targetPointWorker);
            robotsAbstractFactory.CreateRobotStandart();
        }

        private void CreateModernizedWorkerRobot()
        {
            robotsAbstractFactory = new RobotWorkerFactory(spawnPointWorker, standartRobotWorkerPrefab,
                                                           modernizedRobotWorkerPrefab, targetPointWorker);
            robotsAbstractFactory.CreateRobotModernized();
        }

        private void CreateStandartWarriorRobot()
        {
            robotsAbstractFactory = new RobotWarriorFactory(spawnPointWarrior, standartRobotWarriorPrefab,
                                                            modernizedRobotWarriorPrefab, targetPointWarrior);
            robotsAbstractFactory.CreateRobotStandart();
        }

        private void CreateModernizedWarriorRobot()
        {
            robotsAbstractFactory = new RobotWarriorFactory(spawnPointWarrior, standartRobotWarriorPrefab,
                                                            modernizedRobotWarriorPrefab, targetPointWarrior);
            robotsAbstractFactory.CreateRobotModernized();
        }
    }
}
