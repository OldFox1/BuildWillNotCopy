using System.IO;

namespace Foo
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
