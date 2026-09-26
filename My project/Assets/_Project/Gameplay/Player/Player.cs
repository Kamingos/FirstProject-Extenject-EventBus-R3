using UnityEngine;
using Zenject;

namespace _Project.Gameplay.PlayerNamespace
{
    public class Player : MonoBehaviour
    {
        //[Inject]
        //public void Construct(Vector3 position, Quaternion rotation)
        //{
        //    gameObject.transform.position = position;
        //    gameObject.transform.rotation = rotation;
        //}

        public class Factory : PlaceholderFactory<Player>
        {

        }
    }
}
