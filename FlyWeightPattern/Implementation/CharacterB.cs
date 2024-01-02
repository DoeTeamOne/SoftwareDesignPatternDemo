using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyWeightPattern.Interface;

namespace FlyWeightPattern.Implementation
{
    public class CharacterB : ICharacter
    {
        private char _actualCharactor = 'b';
        private string _fontFamily = string.Empty;
        private int _fontsize;
        public string Draw(string fontfamily, int fontsize)
        {
            _fontsize = fontsize;
            _fontFamily = fontfamily;
            return $"Drawing {_actualCharactor},{_fontFamily},{fontsize}";
        }

    }
}
