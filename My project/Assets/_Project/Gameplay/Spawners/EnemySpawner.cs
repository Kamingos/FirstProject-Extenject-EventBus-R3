using System;
using UnityEngine;
using Zenject;
using _Project.Gameplay.EnemyNamespace;

namespace _Project.Gameplay.Spawners
{
    public class EnemySpawner : MonoBehaviour
    {
        [Inject] private Enemy.Factory playerFactory;

        public void Start()
        {
            var enemy = playerFactory.Create();
        }
    }
}
