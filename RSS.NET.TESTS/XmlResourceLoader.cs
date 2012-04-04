using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RSS.NET.TESTS
{
    public static class XmlResourceLoader
    {
        public static Stream Load(string name)
        {
            var asm = Assembly.GetAssembly(typeof(XmlResourceLoader));
            var resource = asm.GetManifestResourceNames().FirstOrDefault(
                x => x.EndsWith(name, StringComparison.OrdinalIgnoreCase));
            return asm.GetManifestResourceStream(resource);

        }
    }
}
