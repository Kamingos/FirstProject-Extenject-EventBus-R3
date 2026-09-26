using Zenject;
using R3;
using MessagePipe;

namespace _Project.Bootstrap
{
   public class ProjectInstaller : MonoInstaller
   {
       public override void InstallBindings()
       {
            var messageBus = Container.BindMessagePipe();
       }
   }
}
