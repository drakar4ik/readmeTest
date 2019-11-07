using System;
using TestGitHub;
using Xunit;

namespace TestGitHubTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var entity = new Entity();
            Assert.True(entity.ReturnTrue());
        }
    }
}
