using dominion_web.Models;
using FluentAssertions;
using Xunit;

namespace dominion_tests.Models
{
    public class RepositoryTests
    {
        [Fact]
        public void IsCSharpProjectTrue()
        {
            var testee = new Repository
            {
                Files = new[] {
                    "Something.cs",
                    "something.txt"
                }
            };

            testee.IsCsharpProject.Should().BeTrue();
        }

        [Fact]
        public void IsCSharpProjectFalse()
        {
            var testee = new Repository
            {
                Files = new[] {
                    "Something.cpp",
                    "something.txt"
                }
            };

            testee.IsCsharpProject.Should().BeFalse();
        }
    }
}