using R3;
using System;
using UnityEngine;
using Zenject;

namespace _Project.Logic.Move
{
    [RequireComponent(typeof(Rigidbody))]
    public class RigidBodyMoveComponentSystem : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        private IMoveComponentData _moveComponentData;
        private MoveParameters _moveParameters;

        [Inject]
        public void Init(IMoveComponentData moveComponentData, MoveParameters moveParameters)
        {
            _moveComponentData = moveComponentData;

            _moveParameters = moveParameters;
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            var velocity = _moveComponentData.Velocity.Value * _moveParameters.Speed;

            velocity = new Vector3(velocity.x, _rigidbody.linearVelocity.y, velocity.z);

            _rigidbody.linearVelocity = velocity;
        }
    }
}