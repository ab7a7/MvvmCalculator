using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class TestClass
    {
        [Fact]
        public void Pass()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
