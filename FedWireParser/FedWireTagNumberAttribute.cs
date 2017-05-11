using System;

namespace FedWireParser
{
    [AttributeUsage(AttributeTargets.Field)]

    internal sealed class FedWireTagNumberAttribute : Attribute
    {
        private int tagNumber;
        private int elementNumber;

       
        public FedWireTagNumberAttribute(int tag, int element)
        {
            this.tagNumber = tag;
            this.elementNumber = element;
        }
    }
}