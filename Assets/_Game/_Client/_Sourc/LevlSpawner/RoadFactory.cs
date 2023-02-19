using Game.Global;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core.Factory
{
    [CreateAssetMenu(fileName = "RoadFactory" , menuName = "ScriptableObject/Factory/RoadFactory")]
    public class RoadFactory : ScriptableObject
    {
        [SerializeField] private GameObject[] _åasyDifficultyRoads;
        [SerializeField] private GameObject[] _middleDifficultyRoads;
        [SerializeField] private GameObject[] _ñomplicatedDifficultyRoads;

        public List<GameObject> Get(Road Road)
        {
            switch (Road.Difficulty)
            {
#pragma warning disable CS0162
                case RoadDifficulty.Easy:
                    return CreateRoad(Road, _åasyDifficultyRoads);
                    break;
                case RoadDifficulty.Middle:
                    return CreateRoad(Road, _middleDifficultyRoads);
                    break;
                case RoadDifficulty.Complicated:
                    return CreateRoad(Road, _ñomplicatedDifficultyRoads);
                    break;
#pragma warning restore CS0162 
            }
            return null;
        }

        private List<GameObject> CreateRoad(Road Road, GameObject[] RoadParts)
        {
            List<GameObject> road = new List<GameObject>();
            Vector3 spawnPosotion = new Vector3(Road.StartSpawnPoint.x, Road.StartSpawnPoint.y, Road.StartSpawnPoint.z);
            for (int i = 0; i < Road.Lenght; i++)
            {
                road.Add(Spawn(RoadParts[Random.Range(0, RoadParts.Length)], spawnPosotion));
                spawnPosotion.z += Road.PrefabLenghtAtZ;
            }
            return road;
        }

        private GameObject Spawn(GameObject prefab, Vector3 spawnPosition)
        {
            return Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    public enum RoadDifficulty
    {
        Easy,
        Middle,
        Complicated
    }
}

