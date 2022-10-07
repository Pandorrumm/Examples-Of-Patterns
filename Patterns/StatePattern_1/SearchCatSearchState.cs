using UnityEngine;

namespace StatePattern_1
{
    public class SearchCatSearchState : IState
    {
        private SearchCatSM searchCatSM;
        private Rigidbody rb;

        private Material headCatMaterial;
        private Color startingHeadCatColor;
        private Color searchHeadCatColor = Color.blue;

        public SearchCatSearchState(SearchCatSM _searchCatSM, Material _headCatMaterial, Rigidbody _rigidbody)
        {
            searchCatSM = _searchCatSM;
            headCatMaterial = _headCatMaterial;
            rb = _rigidbody;           
        }

        public void Enter()
        {
            Debug.Log("STATE - SEARCH");

            startingHeadCatColor = headCatMaterial.color;
            headCatMaterial.color = searchHeadCatColor;
        }

        public void Exit()
        {
            headCatMaterial.color = startingHeadCatColor;
        }

        public void FixedTick()
        {
            float distanceFromTarget = Vector3.Distance(searchCatSM.TargetPosition, rb.position);

            if (distanceFromTarget < 1.5f)
            {               
                searchCatSM.ChangeState(searchCatSM.FoundState);
            }
            else
            {
                RotateTowardsTarget();
                MoveTowardsTarget();
            }
        }

        public void Tick()
        {

        }

        private void RotateTowardsTarget()
        {
            Quaternion lookRotation = Quaternion.LookRotation(searchCatSM.TargetPosition - rb.position);
            lookRotation = Quaternion.Slerp(rb.rotation, lookRotation, searchCatSM.RotateSpeed * Time.deltaTime);
            rb.MoveRotation(lookRotation);
        }

        private void MoveTowardsTarget()
        {
            Vector3 moveOffset = searchCatSM.transform.forward * searchCatSM.MoveSpeed;
            rb.MovePosition(rb.position + moveOffset);
        }
    }
}

