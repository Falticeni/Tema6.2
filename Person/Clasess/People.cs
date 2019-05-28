using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Clasess
{
    public class People
    {
        public string Name { get; set; }
        public int? Age { get; set; } = null;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}\n");
            if (Age != null)
                sb.Append($"Age: {Age}\n");

            else
                sb.Append($"Age: Fara Varsta\n");
            return sb.ToString();
        }

        public People(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
