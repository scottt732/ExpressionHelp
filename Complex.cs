namespace ExpressionHelp
{
    public class Complex
    {
        public int ComplexProperty { get; set; }
        public MoreComplex MoreComplex { get; private set; }

        public Complex()
        {
            ComplexProperty = 2;
            MoreComplex = new MoreComplex();
        }
    }
}