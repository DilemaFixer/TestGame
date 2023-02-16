using Game.Core.Factory;
using UnityEngine;

namespace Game.Global
{
    public class RoadBuilder : MonoBehaviour
    {
        [Header("Road Settings")]
        [SerializeField] private int _roadLenght;
        [Space]
        [SerializeField] private RoadFactory _roadFactory;

        public void Build(RoadDifficulty roadDifficulty)
        {
            for (int i = 0; i < _roadLenght; i++)
                _roadFactory.Spawn(roadDifficulty);
        }
    }
}

