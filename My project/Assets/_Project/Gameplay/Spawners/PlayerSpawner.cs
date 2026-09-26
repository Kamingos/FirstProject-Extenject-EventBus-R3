using System;
using UnityEngine;
using _Project.Gameplay.PlayerNamespace;
using Zenject;
using _Project.Gameplay.PlayerNamespace.RuntimeData;

namespace _Project.Gameplay.Spawners
{
    public class PlayerSpawner : MonoBehaviour
    {
        [SerializeField] private PlayerSettingsData playerSettingsData;

        private Player.Factory _playerFactory;
        private PlayerContainerComponentData _playerContainer;

        [Inject]
        public void Construct(Player.Factory playerFactory, PlayerContainerComponentData playerContainer)
        {
            _playerFactory = playerFactory;
            _playerContainer = playerContainer;
        }

        public void Start()
        {
            var player = _playerFactory.Create();

            player.transform.SetPositionAndRotation(playerSettingsData.Position, playerSettingsData.QuaternionRotation);

            _playerContainer.Player.Value = player;
        }
    }

    [Serializable]
    public struct PlayerSettingsData
    {
        [SerializeField] public Vector3 Position;
        [SerializeField] public Vector3 Rotation;

        public Quaternion QuaternionRotation => Quaternion.Euler(Rotation);
    }
}
