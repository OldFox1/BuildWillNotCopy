using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooWithPostEvent;

namespace BarWithPreEvent
{
    class Bar
    {
        static void Main(string[] args)
        {

            var msg = File.ReadAllLines(Foo.FILE);

            File.Delete(Foo.FILE);

        }
    }
}
