using R3;

namespace _Project.Gameplay.PlayerNamespace.RuntimeData
{
    public class PlayerContainerComponentData
    {
        public ReactiveProperty<Player> Player;

        public PlayerContainerComponentData()
        {
            Player = new()
            {
                Value = null
            };
        }
    }
}
