namespace ExpressionHelp
{
    public class Simple
    {
        public int SimpleProperty { get; set; }
        public Complex Complex { get; private set; }

        public Simple()
        {
            SimpleProperty = 1;
            Complex = new Complex();
        }

    }
}