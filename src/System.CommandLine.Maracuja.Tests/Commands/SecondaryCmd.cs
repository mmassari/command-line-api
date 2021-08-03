using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CommandLine.Maracuja.Tests
{
    [Command("secondary","-s")]
    public class SecondaryCmd
    {
        [Command("method1","-m")]
        public void Method1(
            [Option] string text, 
            [Option] bool flag=false, int number=0)
        {

        }
    }
}
