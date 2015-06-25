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
            return orderings
                .Select(order => order.Select(wordIndex => words[wordIndex]))
                .SelectMany(candidateWords => joiner.Join(candidateWords));
        }
    }
}
