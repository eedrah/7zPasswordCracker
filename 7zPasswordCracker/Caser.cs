using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zPasswordCracker {
    public class Caser {
        public IEnumerable<string> GetCases(string word)
        {
            yield return word;
        }
    }
}
