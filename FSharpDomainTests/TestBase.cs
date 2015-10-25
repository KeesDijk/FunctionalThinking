using System;
using FSharpDomain;
using InfraStrcuture;
using Xunit.Abstractions;

namespace FSharpDomainTests
{
    public class TestBase
    {
        protected readonly ITestOutputHelper OutputWriter;
        protected IInterface3 Impl;

        protected TestBase(ITestOutputHelper outputWriter)
        {
            this.OutputWriter = outputWriter;
            RegisterDependencies();
        }

        private void RegisterDependencies()
        {

            Type t = typeof(IInterface3);
            GlobalIocContainer.Instance().RegisterUserSpecificITypesOf(t.Assembly);

            Impl = GlobalIocContainer.Instance().Resolve<IInterface3>();
        }
    }
}