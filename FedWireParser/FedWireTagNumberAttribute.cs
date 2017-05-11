using System;

namespace FedWireParser
{
    [AttributeUsage(AttributeTargets.Property)]

    public class FedWireTagNumberAttribute : Attribute
    {
        public int TagNumber;
        public int ElementNumber;

       
        public FedWireTagNumberAttribute(int tag, int element)
        {
            this.TagNumber = tag;
            this.ElementNumber = element;
        }
    }
}