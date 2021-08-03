using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CommandLine.Maracuja.Tests
{
    [Command("primary", "-p")]
    public class PrimaryCmd
    {
        [Command("primarysub", "-s")]
        public class PrimarySubCmd : ExecutableCommandBase
        {
            /// <summary>
            /// It's an integer parameter and must be positive and less than 20
            /// </summary>
            [Option("--intval", Obligatoriness.OptionalUseDefault)]
            public int MyIntProperty { get; set; } = 10;

            [Option("--stringval")]
            public string MyStringProperty { get; set; }

            public override bool Init()
            {
                if (MyIntProperty < 0 && MyIntProperty > 20)
                    return SetLastError("MyIntProperty must be within 0 and 20");

                Console.WriteLine("Welcome to PrimarySubCmd");
                return true;
            }
            public override int Execute()
            {

                return 0;
            }

        }

    }


}
