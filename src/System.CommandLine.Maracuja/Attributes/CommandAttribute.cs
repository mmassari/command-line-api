using System;
using System.Collections.Generic;
using System.Text;

namespace System.CommandLine.Maracuja
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class CommandAttribute : Attribute
    {
        public string Parameter { get; private set; }
        public string Alias { get; private set; }
        public CommandAttribute(string parameter, string alias = "")
        {
            Parameter = parameter;
            Alias = alias;
        }
    }
}
