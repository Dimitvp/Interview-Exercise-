using System;

namespace UserInput
{
    public class UserInput
    {
        static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            TextInput textInput = new TextInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            textInput.Add('@');
            Console.WriteLine(input.GetValue());
        }
    }
}
