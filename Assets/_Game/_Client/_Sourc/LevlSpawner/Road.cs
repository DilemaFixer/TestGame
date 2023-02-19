using Game.Core.Factory;
using UnityEngine;

namespace Game.Global
{
    [CreateAssetMenu(fileName = "Road" , menuName = "ScriptableObject/Road")]
    public class Road : ScriptableObject
    {
        [SerializeField] private int _lenght;
        public int Lenght => _lenght;

        [SerializeField] private RoadDifficulty _difficulty;
        public RoadDifficulty Difficulty => _difficulty;

        [SerializeField] private Vector3 _startSpawnPoint;
        public Vector3 StartSpawnPoint => _startSpawnPoint;

        [SerializeField] private int _prefabLenghtAtZ;
        public int PrefabLenghtAtZ => _prefabLenghtAtZ;
    }
}

