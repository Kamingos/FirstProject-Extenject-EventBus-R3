using Zenject;
using _Project.Gameplay.PlayerNamespace.RuntimeData;

namespace _Project.Bootstrap
{
    public class MainSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerContainerComponentData>().FromNew().AsSingle().NonLazy();
        }
    }
}