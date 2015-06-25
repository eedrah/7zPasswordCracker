using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zPasswordCracker {
    public class Caser {
        public IEnumerable<string> GetCases(string word) {
            ISet<string> cases = new HashSet<string> { word };

            string lower = word.ToLower();
            cases.Add(lower);

            string title = lower[0].ToString().ToUpper() + lower.Substring(1);
            cases.Add(title);

            cases.Add(word.ToUpper());

            return cases;
        }

        public IEnumerable<IEnumerable<string>> GetCases(IEnumerable<string> words)
        {
            throw new NotImplementedException();
        }
    }
}
