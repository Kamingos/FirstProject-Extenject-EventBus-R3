using System;
using UnityEngine;
using _Project.Gameplay.PlayerNamespace;
using Zenject;

namespace _Project.Gameplay.Spawners
{
    public class PlayerSpawner : MonoBehaviour
    {
        [SerializeField] private PlayerSettingsData playerSettingsData;

        [Inject] private Player.Factory playerFactory;

        public void Start()
        {
            var player = playerFactory.Create();

            player.transform.SetPositionAndRotation(playerSettingsData.Position, playerSettingsData.QuaternionRotation);
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
