namespace UserInput
{
    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            int num;
            var isDigit = int.TryParse(c.ToString(), out num);
            if (isDigit)
            {
                input.Add(c);
            }
        }
    }
}
