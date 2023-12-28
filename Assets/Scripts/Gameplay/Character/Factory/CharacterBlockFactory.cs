using Gameplay.Character.Data;
using UnityEngine;
using Zenject;

namespace Gameplay.Character.Factory
{
    public class CharacterBlockFactory : IFactory<Transform, SpawnConfiguration, ColorConfiguration, CharacterBlock, CharacterBlock>
    {
        public CharacterBlock Create(Transform parentTransform,
            SpawnConfiguration spawnConfiguration, ColorConfiguration colorConfiguration,
            CharacterBlock previousCharacterBlock)
        {
            return new CharacterBlock(parentTransform, spawnConfiguration, colorConfiguration, previousCharacterBlock);
        }
    }
}