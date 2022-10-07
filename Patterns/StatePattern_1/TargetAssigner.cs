using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StatePattern_1
{
    public class TargetAssigner : MonoBehaviour
    {
        public event Action<Vector3> NewTargetAcquired = delegate { };

        [SerializeField] private GameObject targetIndicatorPrefab = null;

        private GameObject targetIndicator;
        private Camera _camera = null;
        private RaycastHit hitInfo;

        private void Awake()
        {
            _camera = Camera.main;

            targetIndicator = Instantiate(targetIndicatorPrefab, hitInfo.point, Quaternion.identity);
            targetIndicator.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetNewMouseHit(_camera);
                SetNewTargetPoint(hitInfo.point);
            }
        }

        public void GetNewMouseHit(Camera _camera)
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                
            }
        }

        public void SetNewTargetPoint(Vector3 _position)
        {
            targetIndicator.SetActive(true);
            targetIndicator.transform.position = _position;

            NewTargetAcquired.Invoke(_position);
        }
    }
}
