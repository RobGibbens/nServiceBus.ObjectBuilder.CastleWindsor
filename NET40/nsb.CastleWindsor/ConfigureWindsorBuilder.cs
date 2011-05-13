﻿using NServiceBus.ObjectBuilder.CastleWindsor;
using NServiceBus.ObjectBuilder.Common.Config;
using Castle.Windsor;

namespace NServiceBus
{
  /// <summary>
  /// Contains extension methods to NServiceBus.Configure.
  /// </summary>
  public static class ConfigureWindsorBuilder
  {
    /// <summary>
    /// Use the Castle Windsor builder with the NoTrackingReleasePolicy.
    /// </summary>
    /// <param name="config"></param>
    /// <returns></returns>
    public static Configure CastleWindsorBuilder(this Configure config)
    {
      ConfigureCommon.With(config, new Windsor251ObjectBuilder());

      return config;
    }

    /// <summary>
    /// Use the Castle Windsor builder passing in a preconfigured container to be used by nServiceBus.
    /// </summary>
    /// <param name="config"></param>
    /// <param name="container"></param>
    /// <returns></returns>
    public static Configure CastleWindsorBuilder(this Configure config, IWindsorContainer container)
    {
      ConfigureCommon.With(config, new Windsor251ObjectBuilder(container));

      return config;
    }
  }
}