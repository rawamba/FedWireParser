using System;

namespace FedWireParser
{
    [AttributeUsage(AttributeTargets.Field)]

    internal sealed class FedWireTagNumberAttribute : Attribute
    {
        public readonly int tagNumber;

        public FedWireTagNumberAttribute(int number)
        {
            this.tagNumber = number;
        }

    }
}