using UnityEngine;

namespace StatePattern_1
{
    public class SearchCatIdleState : IState
    {
        private SearchCatSM searchCatSM;
        private TargetAssigner targetAssigner;

        private Material headCatMaterial;
        private Color startingHeadCatColor;
        private Color idleHeadCatColor;

        public SearchCatIdleState(SearchCatSM _searchCatSM, Material _headCatMaterial, TargetAssigner _targetAssigner)
        {
            searchCatSM = _searchCatSM;
            targetAssigner = _targetAssigner;
            headCatMaterial = _headCatMaterial;
        }

        public void Enter()
        {
            Debug.Log("STATE - IDLE");

            startingHeadCatColor = idleHeadCatColor;
            headCatMaterial.color = idleHeadCatColor;

            targetAssigner.NewTargetAcquired += OnNewTargetAcquired;
        }

        public void Exit()
        {
            headCatMaterial.color = startingHeadCatColor;
            targetAssigner.NewTargetAcquired -= OnNewTargetAcquired;
        }

        public void FixedTick()
        {

        }

        public void Tick()
        {

        }

        private void OnNewTargetAcquired(Vector3 _newPosition)
        {
            searchCatSM.ChangeState(searchCatSM.SearchState);
        }
    }
}
