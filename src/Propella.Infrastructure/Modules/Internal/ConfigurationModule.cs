using System;
using Autofac;
using Microsoft.Extensions.Configuration;
using Propella.Application.Configuration;

namespace Propella.Infrastructure.Modules.Internal
{
    public class ConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric((context, types, parameters) =>
            {
                var type = types[0];
                if (!type.IsAssignableTo<IHavePath>())
                    throw new InvalidOperationException(
                        $"Cannot resolve ISettings<{type.Name}> as type is not assignable to IHavePath");

                var path = (string)type.GetProperty(nameof(IHavePath.Path))?.GetValue(Activator.CreateInstance(type));
                var configuration = context.Resolve<IConfiguration>();
                var options = configuration.GetSection(path).Get(type);
                return Activator.CreateInstance(typeof(Settings<>).MakeGenericType(type), options);
            }).As(typeof(ISettings<>));
        }
    }
}