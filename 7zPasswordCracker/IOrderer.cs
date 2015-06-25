using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zPasswordCracker {
    public interface IOrderer {
        IEnumerable<List<int>> GetOrderings(int length);
    }
}
