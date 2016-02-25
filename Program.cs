using System;
using System.Linq.Expressions;

namespace ExpressionHelp
{
    class Program
    {
        static void Main()
        {
            var simple = new Simple();
            var simpleFilter = new SimpleFilter();

            Expression<Func<Simple, bool>> result;
            try
            {
                result = simpleFilter.GeneratorEqualityTest(x => x.SimpleProperty, 1);
                Console.WriteLine("First case worked.");
            }
            catch (Exception exc)
            {
                Console.WriteLine("First case failed: " + exc.Message);
            }

            try
            {
                result = simpleFilter.GeneratorEqualityTest(x => x.Complex.ComplexProperty, 2);
                Console.WriteLine("Second case worked.");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Second case failed: " + exc.Message);
            }

            try
            {
                result = simpleFilter.GeneratorEqualityTest(x => x.Complex.MoreComplex.MoreComplexProperty, 3);
                Console.WriteLine("Third case worked.");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Third case failed: " + exc.Message);
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
