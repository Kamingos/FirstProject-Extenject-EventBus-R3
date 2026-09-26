using _Project.Logic.Move;
using System;
using UnityEngine;
using Zenject;

namespace _Project.Gameplay.Player.Installer
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private MoveParameters MoveParameters;

        public override void InstallBindings()
        {
            Container.Bind<IMoveComponentData>().To<MoveComponentData>().AsSingle();
            Container.Bind<MoveParameters>().FromInstance(MoveParameters).AsSingle();

            Container.Bind<PlayerInputSystem>().FromNewComponentOnRoot().AsSingle().NonLazy();

            Container.Bind<RigidBodyMoveComponentSystem>().FromComponentOnRoot().AsSingle().NonLazy();
        }
    }
}