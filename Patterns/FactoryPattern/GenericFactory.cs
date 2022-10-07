using UnityEngine;

namespace FactoryPattern
{
    public class GenericFactory<T> : MonoBehaviour where T: MonoBehaviour
    {
        [SerializeField] private T prefab;
        [SerializeField] private Transform pointToSpawn;
        [SerializeField] private float offset = 2.5f;

        private float n = 0;

        public T GetNewInstance()
        {
            Vector3 position = new Vector3(pointToSpawn.position.x, prefab.transform.position.y, pointToSpawn.position.z - n);
            n += offset;

            return Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
