using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zPasswordCracker {
    public class Caser {
        public List<string> GetCases(string word) {
            ISet<string> cases = new HashSet<string> { word };

            string lower = word.ToLower();
            cases.Add(lower);

            string title = lower[0].ToString().ToUpper() + lower.Substring(1);
            cases.Add(title);

            cases.Add(word.ToUpper());

            return cases.ToList();
        }

        public IEnumerable<List<string>> GetCases(List<string> words) {
            string lastWord = words.Last();
            List<string> firstWords = words.Take(words.Count - 1).ToList();
            if (firstWords.Count > 0) {
                List<List<string>> firstWordsCases = GetCases(firstWords).ToList();
                foreach (List<string> firstWordsCase in firstWordsCases) {
                    foreach (string casedWord in GetCases(lastWord)) {
                        firstWordsCase.Add(casedWord);
                        yield return firstWordsCase;
                    }
                }
            } else {
                foreach (string lastWordCase in GetCases(lastWord))
                {
                    yield return new List<string>{lastWordCase};
                }
            }
        }
    }
}
