using System;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace FunctionTests
{
    public class ComposingFunctionTests : TestBase
    {
        public ComposingFunctionTests(ITestOutputHelper innerOutputWriter) : base(innerOutputWriter)
        {
        }


        [Fact]
        public void SimpleFunctionalComposition()
        {
            //arrange
            int expected = 2*5 + 2;
            Func<int, int> add2 = x => x + 2;
            Func<int, int> mult2 = x => x*2;

            Func<int, int> add2Mult2 = x => add2(mult2(x));

            //act
            var result = add2Mult2(5);
            InnerOutputWriter.WriteLine("expected = {0} , result = {1}", expected, result);

            //assert
            result.Should().Be(expected);
        }

        [Fact]
        public void MonadComposition()
        {
            //arrange
            int expected = 2*5 + 2;
            Func<int, Identity<int>> add2 = x => new Identity<int>(x + 2);
            Func<int, Identity<int>> mult2 = x => new Identity<int>(x*2);

            Func<int, Identity<int>> add2Mult2 = x => mult2(x).Bind(add2);

            //act
            var result = add2Mult2(5).Value;
            InnerOutputWriter.WriteLine("expected = {0} , result = {1}", expected, result);

            //assert
            result.Should().Be(expected);
        }

        [Fact]
        public void MonadComposition2()
        {
            //var expected = "Hello World!, 7, 11/01/2010";
            //arrange
//            var result =
//    "Hello World!".ToIdentity().Bind(a =>
//7.ToIdentity().Bind(b =>
//(new DateTime(2010, 1, 11)).ToIdentity().Bind(c =>
//(a + ", " + b.ToString() + ", " + c.ToShortDateString())
//.ToIdentity())));

           //act
           // InnerOutputWriter.WriteLine("result = {1}", result);

            //assert
            //result.Should().Be(expected);
        }
    }

    public class Identity<T>
    {
        public Identity(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }
    }

    internal static class IdentityExtensions
    {
        public static Identity<B> Bind<A, B>(this Identity<A> a, Func<A, Identity<B>> func)
        {
            return func(a.Value);
        }

        public static Identity<T> ToIdentity<T>(this T value)
        {
            return new Identity<T>(value);
        }
    }
}