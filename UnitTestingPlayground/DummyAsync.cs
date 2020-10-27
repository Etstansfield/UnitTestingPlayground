using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPlayground
{
    public class DummyAsync
    {

        public static async Task AsyncTimer()
        {
            await Task.Delay(1000);
        }

    }
}
