using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooExtendMsBuild
{
    public class Foo
    {

        public const string FILE = @"Libs\cef.pak";

        public static void Delete()
        {

            var msg = File.ReadAllLines(FILE);

            File.Delete(FILE);
        }
    }
}
