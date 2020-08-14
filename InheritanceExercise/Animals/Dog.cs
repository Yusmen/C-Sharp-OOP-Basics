using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog:Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("Dog");
            st.AppendLine($"{Name} {Age} {Gender}");
            st.Append(ProduceSound());

            return st.ToString();

        }
    }
}
