using _Project.Gameplay.PlayerNamespace.RuntimeData;
using _Project.Logic.Move;
using UnityEngine;
using Zenject;

namespace _Project.Gameplay.EnemyNamespace
{
    public class EnemyChasePlayerSystem : MonoBehaviour
    {
        private PlayerContainerComponentData _playerContainer;
        private IMoveComponentData _moveComponentData;

        [Inject]
        public void Construct(PlayerContainerComponentData playerContainer, IMoveComponentData moveComponentData)
        {
            _playerContainer = playerContainer;
            _moveComponentData = moveComponentData;
        }

        public void Update()
        {
            var vec = _playerContainer.Player.Value.transform.position - transform.position;

            _moveComponentData.Velocity.Value = Vector3.Normalize(vec);
        }
    }
}
