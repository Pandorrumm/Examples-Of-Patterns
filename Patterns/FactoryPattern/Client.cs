using UnityEngine;
using UnityEngine.UI;

namespace FactoryPattern
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private WorkerFactory workerFactory;
        [SerializeField] private WarriorFactory warriorFactory;

        [Space]
        [SerializeField] private Button createWorkerButton = null;
        [SerializeField] private Button createWarriorButton = null;

        private void Start()
        {
            createWorkerButton.onClick.AddListener(CreateWorker);
            createWarriorButton.onClick.AddListener(CreateWarrior);
        }

        private void CreateWorker()
        {
            workerFactory.GetNewInstance();
        }

        private void CreateWarrior()
        {
            warriorFactory.GetNewInstance();
        }
    }
}
