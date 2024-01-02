using FlyWeightPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Interface
{
    public class CharactorFactory
    {
        private Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();
        public bool IsReused { get; private set; } = false;
        public ICharacter? GetCharacter(char charactorIdetifier)
        {
            if (_characters.ContainsKey(charactorIdetifier))
            {
                IsReused = true;
                return _characters[charactorIdetifier];
            }

            // if the charactor is not in the Dictionary  Create it Store it and Return it 
            switch (charactorIdetifier)
            {
                case 'a':
                    _characters[charactorIdetifier] = new CharactorA();
                    return _characters[charactorIdetifier];
                case 'b':
                    _characters[charactorIdetifier] = new CharacterB();
                    return _characters[charactorIdetifier];
            }
            return null;
        }

        public bool isCharactorReused()
        {
            return IsReused;
        }
    }
}
