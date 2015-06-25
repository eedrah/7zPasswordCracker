using System.Collections.Generic;
using Xunit;
using _7zPasswordCracker;

namespace Tests {
    public class TestCaser {
        [Fact]
        public void Should_Return_Original_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains(word, results);
        }

        [Fact]
        public void Should_Return_Lower_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains("testing", results);
        }

        [Fact]
        public void Should_Return_Title_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains("Testing", results);
        }

        [Fact]
        public void Should_Return_Upper_Case_Of_Input_Word() {
            var caser = new Caser();
            var word = "teStIng";

            IEnumerable<string> results = caser.GetCases(word);

            Assert.Contains("TESTING", results);
        }
    }
}
