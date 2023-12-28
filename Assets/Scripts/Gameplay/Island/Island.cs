using Gameplay.Character;
using UnityEngine;

namespace Gameplay.Island
{
    public class Island : MonoBehaviour
    {
        [SerializeField] 
        private GameObject _completeFlagObject;

        private CharacterBlock _frontCharacterBlock;

        private bool _isCompleted;

        private int _islandSize;

        public void Construct(int islandSize)
        {
            _islandSize = islandSize;
        }

        private void CompleteIsland()
        {
            _isCompleted = true;
            
            PlayFlagAnimation();
        }

        public void CheckForComplete()
        {
            if (_isCompleted)
            {
                return;
            }

            CharacterBlock iterator = _frontCharacterBlock;
            
            for (int i = 0; i < _islandSize; i++)
            {
                if (_frontCharacterBlock == null)
                {
                    return;
                }
                
                iterator = iterator.BackBlock;
            }
            
            CompleteIsland();
        }

        private void PlayFlagAnimation()
        {
            
        }
    }
}