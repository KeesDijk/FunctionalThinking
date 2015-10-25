using FluentAssertions;
using FSharpDomain;
using Xunit;
using Xunit.Abstractions;

namespace FSharpDomainTests
{
    public class ImplementationTests : TestBase
    {
        public ImplementationTests(ITestOutputHelper outputWriter) : base(outputWriter)
        {
        }

        [Fact]
        public void FirstIntegrationTest()
        {
            //arrange
            string expected = "F#";
            SimpleClass sc = new SimpleClass();

            //act
            var result = sc.X;
            OutputWriter.WriteLine("result: {0}", result);
            //assert
            result.Should().Be(expected);
        }

        [Fact]
        public void SecondIntegrationTest()
        {
            //arrange
            //string expected = "F#";
            IInterface3 sc = Impl;
            
            //act
            var input = 10;
            var method1 = sc.Method1(input);
            OutputWriter.WriteLine("method1: {0}", method1);
            var method2 = sc.Method2(input);
            OutputWriter.WriteLine("method2: {0}", method2);
            var method3= sc.Method3(input);
            OutputWriter.WriteLine("method3: {0}", method3);

            //assert
            method1.Should().Be(20);
            method2.Should().Be(110);
            method3.Should().Be(1);
        }
    }
}
