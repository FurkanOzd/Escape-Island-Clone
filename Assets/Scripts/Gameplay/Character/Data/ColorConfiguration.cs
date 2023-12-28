using UnityEngine;

namespace Gameplay.Character.Data
{
    [CreateAssetMenu(fileName = "ColorConfiguration", menuName = "ScriptableObjects/ColorConfiguration", order = 1)]
    public class ColorConfiguration : ScriptableObject
    {
        public int colorId;

        public Material material;
    }
}