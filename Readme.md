This is a demo project for a problem I'm having trying to wrap my head around expressions.

The issue liies in Filter.GeneratorEqualityTest's overly-simplistic expressions for parameters & properties.

I'm hoping to change the code between the //Help comments without having to change the code outside of it 
as this is just a sliver of a much larger expression parsing library.  

The purpose of this is to generate 

    Expression<Func<TEntity, bool>>

For use in the .Where() clause of LINQ expressions, specifically so that Entity Framework can convert them
into SQL.