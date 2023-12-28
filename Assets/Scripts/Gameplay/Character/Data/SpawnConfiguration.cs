using UnityEngine;

namespace Gameplay.Character.Data
{
    [CreateAssetMenu(fileName = "SpawnConfiguration", menuName = "ScriptableObjects/SpawnConfiguration", order = 2)]
    public class SpawnConfiguration : ScriptableObject
    {
        public int count;

        public Vector3 characterGap;
    }
}