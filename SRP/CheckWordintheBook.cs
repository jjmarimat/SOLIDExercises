﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class CheckWordintheBook
    {
        private string _mytext = "Always";

        public bool isWordInText(String word)
        {
            return _mytext.Contains(word);
        }
     
    }

}
}
