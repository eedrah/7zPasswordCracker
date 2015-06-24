using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zPasswordCracker {
    public class OrdinalOrderer : IOrderer {
        public IEnumerable<List<int>> GetOrderings(int length) {
            for (int i = 0; i < length; i++) {
                yield return new List<int> { i };
            }
        }
    }
}
