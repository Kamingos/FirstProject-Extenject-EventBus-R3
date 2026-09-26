using R3;
using System;
using UnityEngine;

namespace _Project.Logic.Move
{

    public interface IMoveComponentData
    {
        public ReactiveProperty<Vector3> Velocity { get; set; }
    }

    [Serializable]
    public struct MoveParameters
    {
        public float Speed;
    }

    public class MoveComponentData : IMoveComponentData
    {
        public ReactiveProperty<Vector3> Velocity { get; set; }

        public MoveComponentData()
        {
            Velocity = new ReactiveProperty<Vector3>();
        }
    }
}
