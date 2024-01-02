using FlyWeightPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Implementation
{
    public class CharactorA : ICharacter
    {
        private char _actualCharactor = 'a';
        private string _fontFamily =string.Empty;
        private int _fontsize;
        public string Draw(string fontfamily, int fontsize)
        {
            _fontsize = fontsize;
            _fontFamily = fontfamily;
            return $"Drawing {_actualCharactor},{_fontFamily},{_fontsize}";
        }
    }
}
