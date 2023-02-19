using Game.Core.Factory;
using UnityEngine;

namespace Game.Global
{
    public class RoadBuilder : MonoBehaviour
    {
        [SerializeField] private RoadFactory _roadFactory;
        [SerializeField] private Road _�asyDifficultyRoad;
        [SerializeField] private Road _middleDifficultyRoad;
        [SerializeField] private Road _�omplicatedDifficultyRoad;
        private Road _currentRoad;

        private void Awake()
        {
            _currentRoad = _�asyDifficultyRoad;
            Build();
        }
        

        public void Build()
        {
            _roadFactory.Get(_currentRoad);
        }

        public void ChangeDifficult(int difficult)
        {
            switch (difficult)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}

