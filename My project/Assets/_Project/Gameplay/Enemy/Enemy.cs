using UnityEngine;
using Zenject;

namespace _Project.Gameplay.EnemyNamespace
{
    public class Enemy : MonoBehaviour
    {
        public class Factory : PlaceholderFactory<Enemy>
        {

        }
    }
}
