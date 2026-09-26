using UnityEngine;
using Zenject;
using _Project.Gameplay.EnemyNamespace;
using System.Collections.Generic;

namespace _Project.Gameplay.Spawners
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private List<Vector3> positionsForSpawn;

        [Inject] private Enemy.Factory enemyFactory;

        public void Start()
        {
            foreach (var item in positionsForSpawn)
            {
                var enemy = enemyFactory.Create();

                enemy.transform.position = item;
            }
        }
    }
}
