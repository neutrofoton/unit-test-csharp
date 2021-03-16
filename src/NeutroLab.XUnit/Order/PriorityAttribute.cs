using System;

namespace NeutroLab.XUnit.Order
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class PriorityAttribute : Attribute
    {
        public PriorityAttribute(int sequence)
        {
            Sequence = sequence;
        }

        public int Sequence { get; private set; }
    }
}
