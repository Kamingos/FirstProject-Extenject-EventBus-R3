using _Project.Gameplay.PlayerNamespace;
using _Project.Logic.Move;
using UnityEngine;
using Zenject;
using _Project.Gameplay.EnemyNamespace;

namespace _Project.Bootstrap
{
    public class MainSceneSpawnersInstaller : MonoInstaller
    {
        [SerializeField] public GameObject playerPrefab;
        [SerializeField] public GameObject enemyPrefab;

        public override void InstallBindings()
        {
            Container.BindFactory<Player, Player.Factory>()
                .FromComponentInNewPrefab(playerPrefab);

            Container.BindFactory<Enemy, Enemy.Factory>()
                .FromComponentInNewPrefab(enemyPrefab);
        }
    }
}