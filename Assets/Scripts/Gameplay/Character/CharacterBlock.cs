using Gameplay.Character.Data;
using UnityEngine;
using Zenject;

namespace Gameplay.Character
{
    public class CharacterBlock
    {
        public CharacterBlock BackBlock { get; private set; }

        private readonly ColorConfiguration _colorConfiguration;

        private readonly SpawnConfiguration _spawnConfiguration;
        
        private readonly Character[] _characters;
        
        public int ColorId => _colorConfiguration.colorId;

        [Inject]
        private readonly Character.Factory _characterFactory;

        private readonly Transform _charactersParentTransform;

        public CharacterBlock(Transform charactersParentTransform, SpawnConfiguration spawnConfiguration,
            ColorConfiguration colorConfiguration, CharacterBlock backBlock)
        {
            BackBlock = backBlock;
            _colorConfiguration = colorConfiguration;
            _spawnConfiguration = spawnConfiguration;
            _charactersParentTransform = charactersParentTransform;
            
            SpawnCharacters();
        }

        private void SpawnCharacters()
        {
            int characterCount = _spawnConfiguration.count;

            Vector3 spawnPosition = _charactersParentTransform.position;
            
            for (int i = 0; i < characterCount; i++)
            {
                _characterFactory.Create(_charactersParentTransform, spawnPosition, _colorConfiguration.material);

                spawnPosition += _spawnConfiguration.characterGap;
            }
        }

        public void MoveBlocks()
        {
            
        }

        public class Factory : PlaceholderFactory<Transform, SpawnConfiguration, ColorConfiguration, CharacterBlock, CharacterBlock>{}
    }
}