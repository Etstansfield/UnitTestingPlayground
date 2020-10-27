using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingPlayground.Test
{
    public class DummyAsyncTest
    {
        [Fact]
        public static async Task AsyncTimer_Success()
        {
            await DummyAsync.AsyncTimer();

            Assert.True(true);
        }

    }
}
