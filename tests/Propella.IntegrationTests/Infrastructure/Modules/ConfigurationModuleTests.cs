using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Core;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Propella.Domain.Configuration;
using Propella.Infrastructure.Modules.Internal;

namespace Propella.IntegrationTests.Infrastructure.Modules
{
    public class ConfigurationModuleTests
    {
        private class MyGoodSettings : IHavePath
        {
            public string Path => "MySettings";

            public string Arg1 { get; set; }
            public string Arg2 { get; set; }
        }
        
        private class MyBadSettings
        {
            public string Path => "MySettings";

            public string Arg1 { get; set; }
            public string Arg2 { get; set; }
        }

        private IContainer Container { get; set; }
        
        [SetUp]
        public void Setup()
        {
            var builder = new ContainerBuilder();
            builder.Register(context => new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>
                {
                    { "MySettings:Arg1", "Val1" },
                    { "MySettings:Arg2", "Val2" },
                }).Build()).AsImplementedInterfaces();
            builder.RegisterModule<ConfigurationModule>();
            
            Container = builder.Build();
        }
        
        [Test]
        public void Should_Return_Settings()
        {
            // Act
            var settings = Container.Resolve<ISettings<MyGoodSettings>>();

            // Assert
            settings.Value.Arg1.Should().Be("Val1");
            settings.Value.Arg2.Should().Be("Val2");
        }
        
        [Test]
        public void Should_Throw_Because_Settings_Does_Not_Implement_IHavePath()
        {
            // Act
            Func<ISettings<MyBadSettings>> settingsFn = () => Container.Resolve<ISettings<MyBadSettings>>();

            // Assert
            settingsFn.Should()
                .Throw<DependencyResolutionException>()
                .WithInnerException<InvalidOperationException>()
                .WithMessage("Cannot resolve ISettings<MyBadSettings> as type is not assignable to IHavePath");
        }
    }
}