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
        public void Should_Return_Onethree_When_Given_One_Two_And_Three() {
            var permutator = new Permutator();
            var words = new List<string> { "one", "two", "three" };

            List<string> results = permutator.Permutate(words).ToList();

            Assert.Contains("onethree", results);
        }

        [Fact]
        public void Should_Return_One_Three_When_Given_One_Two_And_Three() {
            var permutator = new Permutator();
            var words = new List<string> { "one", "two", "three" };

            List<string> results = permutator.Permutate(words).ToList();

            Assert.Contains("one three", results);
        }
    }
}
