using UnityEngine;

namespace StatePattern_1
{
    public class SearchCatSM : StateMachine
    {
        public SearchCatIdleState IdleState { get; private set; }
        public SearchCatSearchState SearchState { get; private set; }
        public SearchCatFoundState FoundState { get; private set; }

        [Header("Required References")]
        [SerializeField] private TargetAssigner targetAssigner = null;
        [SerializeField] private Rigidbody _rigidbody = null;

        [Header("Movement Settings")]
        [SerializeField] private float rotateSpeed = 5f;
        public float RotateSpeed => rotateSpeed;

        [SerializeField] private float moveSpeed = 5f;
        public float MoveSpeed => moveSpeed;

        [Header("Feedback")]
        [SerializeField] private MeshRenderer headCatMesh = null;

        public Vector3 TargetPosition { get; set; }

        private void Awake()
        {
            IdleState = new SearchCatIdleState(this, headCatMesh.material, targetAssigner);
            SearchState = new SearchCatSearchState(this, headCatMesh.material, _rigidbody);
            FoundState = new SearchCatFoundState(this, headCatMesh.material);
        }

        private void OnEnable()
        {
            targetAssigner.NewTargetAcquired += OnNewTargetAcquired;
        }

        private void OnDisable()
        {
            targetAssigner.NewTargetAcquired -= OnNewTargetAcquired;
        }

        private void Start()
        {
            ChangeState(IdleState);
        }

        private void OnNewTargetAcquired(Vector3 _newTarget)
        {
            TargetPosition = _newTarget;
        }
    }
}