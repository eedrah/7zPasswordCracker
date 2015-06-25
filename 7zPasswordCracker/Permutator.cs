using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zPasswordCracker {
    public class Permutator {
        public IEnumerable<string> Permutate(List<string> words)
        {
            int numberOfWords = words.Count;
            IEnumerable<List<int>> orderings = new OrdinalOrderer().GetOrderings(numberOfWords);
            var joiner = new Joiner();
            foreach (var order in orderings)
            {
                IEnumerable<string> candidateWords = order.Select(wordIndex => words[wordIndex]);
                foreach (string combination in joiner.Join(candidateWords))
                {
                    yield return combination;
                }
            }
        }
    }
}
