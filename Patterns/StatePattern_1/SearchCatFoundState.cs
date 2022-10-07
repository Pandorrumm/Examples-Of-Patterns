using UnityEngine;

namespace StatePattern_1
{
    public class SearchCatFoundState : IState
    {
        private SearchCatSM searchCatSM;

        private Material headCatMaterial;

        private Color startingHeadCatColor;
        private Color foundHeadCatColor = Color.green;


        private float foundDelayDuration = 1.5f;
        private float elapsedTime = 0;
        private bool timerActive = false;

        public SearchCatFoundState(SearchCatSM _searchCatSM, Material _headCatMaterial)
        {
            searchCatSM = _searchCatSM;
            headCatMaterial = _headCatMaterial;
        }

        public void Enter()
        {
            Debug.Log("STATE - Found");

            startingHeadCatColor = headCatMaterial.color;
            headCatMaterial.color = foundHeadCatColor;

            StartTimer();
        }

        public void Exit()
        {
            headCatMaterial.color = startingHeadCatColor;
        }

        public void FixedTick()
        {

        }

        public void Tick()
        {
            if (timerActive)
            {
                elapsedTime += Time.deltaTime;
            }

            if (elapsedTime > foundDelayDuration)
            {
                StopTimer();
                searchCatSM.ChangeState(searchCatSM.IdleState);
            }
        }

        private void StartTimer()
        {
            timerActive = true;
            elapsedTime = 0;
        }

        private void StopTimer()
        {
            timerActive = false;
        }
    }
}
