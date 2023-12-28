using UnityEngine;
using Zenject;

namespace Gameplay.Character.Factory
{
    public class CharacterFactory : IFactory<Transform, Vector3, Material, Character>
    {
        private readonly DiContainer _diContainer;

        public CharacterFactory(DiContainer diContainer)
        {
            _diContainer = diContainer;
        }

        public Character Create(Transform parentTransform, Vector3 position, Material material)
        {
            return CreateInternal(parentTransform, position, material);
        }

        private Character CreateInternal(Transform parentTransform, Vector3 position, Material material)
        {
            return null;
        }
    }
}