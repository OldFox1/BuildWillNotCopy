using System.IO;
using FooExtendMsBuild;

namespace BarWithExtendMsBuild
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
