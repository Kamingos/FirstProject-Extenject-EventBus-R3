using _Project.Logic.Move;
using System;
using UnityEngine;
using Zenject;

namespace _Project.Gameplay.EnemyNamespace.Installer
{
    public class EnemyInstaller : MonoInstaller
    {
        [SerializeField] private MoveParameters MoveParameters;

        public override void InstallBindings()
        {
            Container.Bind<IMoveComponentData>().To<MoveComponentData>().AsSingle();
            Container.Bind<MoveParameters>().FromInstance(MoveParameters).AsSingle();

            Container.Bind<RigidBodyMoveComponentSystem>().FromComponentOnRoot().AsSingle().NonLazy();

            Container.Bind<EnemyChasePlayerSystem>().FromNewComponentOnRoot().AsSingle().NonLazy();
        }
    }
}