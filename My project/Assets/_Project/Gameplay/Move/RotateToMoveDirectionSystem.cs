using _Project.Logic.Move;
using R3;
using UnityEngine;
using Zenject;

namespace _Project.Gameplay.Move
{
    [RequireComponent(typeof(Rigidbody))]
    public class RotateToMoveDirectionSystem : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        [Inject] private IMoveComponentData _moveComponentData;

        private CompositeDisposable _disposables;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();

            _disposables = new();

            _moveComponentData.Velocity.AsObservable()
                .Subscribe(x => transform.rotation = Quaternion.LookRotation(x))
                .AddTo(_disposables);
        }

        private void OnDisable()
        {
            _disposables.Clear();
        }
    }
}
