using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void Should_Return_All_Words_Given() {
            var permutator = new Permutator();
            var words = new List<string> { "some", "words", "given" };

            List<string> results = permutator.Permutate(words).ToList();

            foreach (string word in words) {
                Assert.Contains(word, results);
            }
        }

        [Fact]
        public void Should_Return_Concatination_Of_Two_Words() {
            var permutator = new Permutator();
            var words = new List<string> { "some", "words", "given" };

            List<string> results = permutator.Permutate(words).ToList();

            Assert.Contains("somegiven", results);
        }
    }
}
