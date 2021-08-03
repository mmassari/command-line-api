using System;
using System.Collections.Generic;
using System.Text;

namespace System.CommandLine.Maracuja
{
    public enum Obligatoriness
    {
        OptionalAskInput,
        OptionalUseDefault,
        Mandatory
    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    public class OptionAttribute : Attribute
    {
        public string Parameter { get; private set; }
        public Obligatoriness Behavior { get; private set; }

        public OptionAttribute(string parameter="", Obligatoriness behavior = Obligatoriness.Mandatory)
        {
            Parameter = parameter;
            Behavior = behavior;
        }
    }
}
