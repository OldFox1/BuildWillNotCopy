using System.IO;

namespace Bar
{
    class Program
    {
        static void Main(string[] args)
        {

            var msg = File.ReadAllLines(Foo.Foo.FILE);

            File.Delete(Foo.Foo.FILE);

        }
    }
}
