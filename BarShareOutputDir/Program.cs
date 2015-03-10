using System.IO;
using FooWithDifferentOutputDir;

namespace BarShareOutputDir
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
