using System.Collections.Generic;
using System.Linq;
using Xunit;
using _7zPasswordCracker;

namespace Tests {
    public class TestCaser {
        [Fact]
        public void Should_Contain_Original_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains(word, results);
        }

        [Fact]
        public void Should_Contain_Lower_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains("testing", results);
        }

        [Fact]
        public void Should_Contain_Title_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains("Testing", results);
        }

        [Fact]
        public void Should_Contain_Upper_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains("TESTING", results);
        }

        [Fact]
        public void Should_Contain_Original_Cases_Of_Multiple_Words() {
            var caser = new Caser();
            var words = new List<string> { "teStIng", "WoRds" };

            IEnumerable<IEnumerable<string>> results = caser.GetCases(words);

            Assert.Contains(results, enumerable => enumerable.SequenceEqual(words));
        }
    }
}
