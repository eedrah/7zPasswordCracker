using System.Collections.Generic;
using System.Linq;
using Xunit;
using _7zPasswordCracker;

namespace Tests {
    public class TestOrderer {
        [Fact]
        public void Should_Return_IEnumerables_Of_All_Numbers_From_0_To_The_Input() {
            var orderer = new Orderer();
            int input = 3;

            List<IEnumerable<int>> orderings = orderer.GetOrderings(input).ToList();

            for (int i = 1; i < 3; i++)
            {
                int number = i;
                Assert.Contains(orderings, ints => ints.Single() == number);
            }
        }
    }
}
