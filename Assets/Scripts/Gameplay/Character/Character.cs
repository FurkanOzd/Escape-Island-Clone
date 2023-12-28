using UnityEngine;
using Zenject;

namespace Gameplay.Character
{
    public class Character : MonoBehaviour
    {
        [SerializeField] 
        private MeshRenderer _meshRenderer;
        
        public void Construct(Vector3 spawnPosition, Material material)
        {
            _meshRenderer.material = material;
            transform.position = spawnPosition;
        }
        
        public class Factory : PlaceholderFactory<Transform, Vector3, Material, Character>{}
    }
}