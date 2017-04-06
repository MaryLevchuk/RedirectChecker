using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Redirects.Helpers
{
    public class SourceFile
    {
        public SourceFile(string filepath)
        {
            var lines = File.ReadLines(filepath);
            return lines;
        }
    }
}
