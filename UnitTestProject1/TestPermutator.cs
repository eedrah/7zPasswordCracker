using System.Collections.Generic;
using Xunit;
using _7zPasswordCracker;

namespace Tests {
    public class TestPermutator {
        [Fact]
        public void Should_Return_The_Word_That_Was_Given() {
            var permutator = new Permutator();
            var words = new List<string> { "word" };

            IEnumerable<string> results = permutator.Permutate(words);

            Assert.Contains("word", results);
        }
    }
}
