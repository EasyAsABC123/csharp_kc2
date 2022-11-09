using System;
namespace csharp_kc2
{
    public class Person
    {
        public string HairColor { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                var now = DateTime.Now;
                int age = now.Year - this.Birthday.Year;

                if (now.Month < this.Birthday.Month || (now.Month == this.Birthday.Month && now.Day < this.Birthday.Day))
                    age--;

                return age;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\nHeight: {this.Height}";
        }
    }
}

