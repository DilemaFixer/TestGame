using Game.Global;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core.Factory
{
    [CreateAssetMenu]
    public abstract class RoadFactory : ScriptableObject
    {
        [SerializeField] private float _roadLenght;
        [SerializeField] private Transform _startPosition;
        [SerializeField] private GameObject[] _�asyDifficultyRoads; 
        [SerializeField] private GameObject[] _middleDifficultyRoads;
        [SerializeField] private GameObject[] _�omplicatedDifficultyRoads;
    
        public GameObject Get(Road Road)
        {
            switch (Road._difficulty)
            {
#pragma warning disable CS0162
                case RoadDifficulty.Easy:     
                    return Get(_�asyDifficultyRoads[Random.Range(0, _�asyDifficultyRoads.Length)]);
                    break;
                case RoadDifficulty.Middle:
                    return Get(_middleDifficultyRoads[Random.Range(0, _middleDifficultyRoads.Length)]);
                    break;
                case RoadDifficulty.Complicated:
                    return Get(_�omplicatedDifficultyRoads[Random.Range(0, _�omplicatedDifficultyRoads.Length)]);
                    break;
#pragma warning restore CS0162 
            }
            return null;
        }

        private List<GameObject> CreateRoad(Road Road, GameObject[] RoadParts)
        {
            List<GameObject> road = new List<GameObject>();
            Vector3 spawnPosotion = new Vector3(_startPosition.position.x, _startPosition.position.y, _startPosition.position.z);
            for (int i = 0; i < Road._lenght; i++)
            {
                Spawn(RoadParts[Random.Range(0, RoadParts.Length)], spawnPosotion);
                spawnPosotion.z += _roadLenght;
            }
        }

        private GameObject Spawn(GameObject prefab , Vector3 spawnPosition)
        {
            return Instantiate(prefab , spawnPosition , Quaternion.identity);          
        }
    }

    public enum RoadDifficulty
    {
        Easy,
        Middle,
        Complicated
    }
}

