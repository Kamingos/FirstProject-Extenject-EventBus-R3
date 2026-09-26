using _Project.Logic.Move;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace _Project.Gameplay.Player
{
    public class PlayerInputSystem : MonoBehaviour
    {
        private IMoveComponentData _moveData;

        private InputAction _action;

        [Inject]
        public void Init(IMoveComponentData moveData)
        {
            _moveData = moveData;
        }

        public void Start()
        {
            _action = InputSystem.actions.FindAction("Player/Move");
            _action.Enable();
        }

        public void Update()
        {
            var value = _action.ReadValue<Vector2>();

            _moveData.Velocity.Value = new Vector3(value.x, 0f, value.y);
        }

        public void OnDisable()
        {
            _action.Disable();
        }
    }
}
