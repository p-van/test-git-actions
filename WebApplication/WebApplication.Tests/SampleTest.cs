using System;
using Xunit;

namespace WebApplication.Tests
{
    public class SampleTest
    {
        [Fact]
        public void DoTest()
        {
            var a = 1;
            var b = 1;
            
            Assert.Equal(a,b);
        }
    }
}