using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Platforms.Windows
{
    public class MujezinWinService : IServicesTest
    {
        public void Start()
        {
            Console.WriteLine("Upali servis");
        }

        public void Stop()
        {
            Console.WriteLine("Ugasi servis");
        }
    }
}
