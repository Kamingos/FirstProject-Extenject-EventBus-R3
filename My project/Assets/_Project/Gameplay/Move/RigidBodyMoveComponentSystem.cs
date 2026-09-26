using R3;
using System;
using UnityEngine;
using Zenject;

namespace _Project.Logic.Move
{
    public class RigidBodyMoveComponentSystem : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;

        private IMoveComponentData _moveComponentData;
        private MoveParameters _moveParameters;

        [Inject]
        public void Init(IMoveComponentData moveComponentData, MoveParameters moveParameters)
        {
            _moveComponentData = moveComponentData;

            _moveParameters = moveParameters;
        }

        public void FixedUpdate()
        {
            var velocity = _moveComponentData.Velocity.Value * _moveParameters.Speed;

            _rigidbody.linearVelocity = velocity;
        }
    }
}