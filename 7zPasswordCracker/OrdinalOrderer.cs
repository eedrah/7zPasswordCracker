using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zPasswordCracker {
    public class OrdinalOrderer : IOrderer {
        public IEnumerable<List<int>> GetOrderings(int length) {
            for (int i = 0; i < Math.Pow(2, length); i++) {
                var ordering = new List<int>();
                var bits = new BitArray(new int[] { i });
                for (int j = 0; j < length; j++) {
                    if (bits[j]) {
                        ordering.Add(j);
                    }
                }
                yield return ordering;
            }
        }
    }
}
