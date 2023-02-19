using Game.Core.Factory;
using System;
using UnityEngine;

namespace Game.Global
{
    public class RoadBuilderView : MonoBehaviour
    {
        public Action<int> IsRoadDifficultyChange;
        public void ChoosRoadDifficulty(int difficult)
        {
            IsRoadDifficultyChange(difficult);
        }
    }
}

