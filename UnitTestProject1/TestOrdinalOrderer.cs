using System.Collections.Generic;
using System.Linq;
using Xunit;
using _7zPasswordCracker;

namespace Tests {
    public class TestOrdinalOrderer {
        [Fact]
        public void Should_Return_IEnumerables_Of_All_Numbers_From_0_To_The_Input() {
            IOrderer orderer = new OrdinalOrderer();
            int input = 3;

            List<List<int>> orderings = orderer.GetOrderings(input).ToList();

            for (int i = 1; i < 3; i++) {
                int number = i;
                Assert.Contains(orderings, ints => ints.SequenceEqual(new[]{number}));
            }
        }

        [Fact]
        public void Should_Contain_1_3_And_4_When_Given_5() {
            IOrderer orderer = new OrdinalOrderer();
            int input = 5;

            List<List<int>> orderings = orderer.GetOrderings(input).ToList();

            Assert.Contains(orderings, ints => ints.SequenceEqual(new[] { 1, 3, 4 }));
        }
    }
}
