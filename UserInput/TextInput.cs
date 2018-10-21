using System.Collections.Generic;

namespace UserInput
{
    public class TextInput
    {
        public List<char> input = new List<char>();

        public virtual void Add(char c)
        {
            input.Add(c);
        }

        public string GetValue()
        {
            var str = string.Join("", input);
            return str;
        }
    }
}
