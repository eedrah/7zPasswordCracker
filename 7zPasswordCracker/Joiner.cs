using System.Collections.Generic;
using System.Linq;

namespace _7zPasswordCracker {
    public class Joiner {
        public IEnumerable<string> Join(IEnumerable<string> words) {
            IList<string> values = words as IList<string> ?? words.ToList();
            yield return string.Join("", values);
            yield return string.Join(" ", values);
        }
    }
}
