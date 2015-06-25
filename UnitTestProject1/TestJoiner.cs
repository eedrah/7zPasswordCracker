using System.Collections.Generic;
using Xunit;
using _7zPasswordCracker;

namespace Tests {
    public class TestJoiner {
        [Fact]
        public void Should_Contain_TestWord_When_Given_Test_And_Word() {
            var joiner = new Joiner();
            var words = new List<string> { "test", "word" };

            var results = joiner.Join(words);

            Assert.Contains("testword", results);
        }

        [Fact]
        public void Should_Contain_Test_Word_When_Given_Test_And_Word() {
            var joiner = new Joiner();
            var words = new List<string> { "test", "word" };

            var results = joiner.Join(words);

            Assert.Contains("test word", results);
        }
    }
}
