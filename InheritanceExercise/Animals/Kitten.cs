using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string gender = "Female";
        public Kitten(string name, int age) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("Kitten");
            st.AppendLine($"{Name} {Age} {Gender}");
            st.Append(ProduceSound());

            return st.ToString();
        }
    }
}
