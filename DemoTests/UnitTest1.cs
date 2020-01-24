using Demo.Helpers;
using System;
using Xunit;

namespace DemoTests
{
    public class UnitTest1
    {
        [Fact]
        public void DisplayNameCheck()
        {
            Assert.True(Utils.DisplayName("test", "user") == "test, user");
        }
    }
}
