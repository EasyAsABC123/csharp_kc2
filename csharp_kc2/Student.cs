using System;
namespace csharp_kc2
{
    public class Student : Person
    {
        public bool PassingClass { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nPassing: {this.PassingClass}";
        }
    }
}

