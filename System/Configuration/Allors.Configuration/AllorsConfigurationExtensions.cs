// <copyright file="AllorsConfigurationExtensions.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Configuration;

using Microsoft.Extensions.Configuration;

/// <summary>
/// Extensions for <see cref="IConfigurationBuilder"/> to add Allors configuration sources.
/// </summary>
public static class AllorsConfigurationExtensions
{
    private const string AppSettingsFileName = "appsettings.json";

    /// <summary>
    /// Adds Allors configuration sources with hierarchical precedence (lowest to highest):
    /// 1. Working directory appsettings.json (backward compatibility)
    /// 2. System-wide domain config (/etc/allors/{domain}/)
    /// 3. System-wide component config (/etc/allors/{domain}/{component}/)
    /// 4. User domain config (~/.allors/{domain}/)
    /// 5. User component config (~/.allors/{domain}/{component}/)
    /// 6. Environment variables
    /// </summary>
    /// <param name="builder">The configuration builder.</param>
    /// <param name="domain">The domain name (e.g., "core", "base", "apps").</param>
    /// <param name="component">The component name (e.g., "server", "commands").</param>
    /// <returns>The configuration builder for chaining.</returns>
    public static IConfigurationBuilder AddAllorsConfiguration(
        this IConfigurationBuilder builder,
        string domain,
        string component)
    {
        var systemDomainPath = AllorsConfigurationPaths.GetSystemPath(domain);
        var systemComponentPath = AllorsConfigurationPaths.GetSystemPath(domain, component);
        var userDomainPath = AllorsConfigurationPaths.GetUserPath(domain);
        var userComponentPath = AllorsConfigurationPaths.GetUserPath(domain, component);

        // Working directory (lowest priority - backward compatibility)
        builder.AddJsonFile(AppSettingsFileName, optional: true, reloadOnChange: false);

        // System-wide domain configuration (parent)
        builder.AddJsonFile(
            Path.Combine(systemDomainPath, AppSettingsFileName),
            optional: true,
            reloadOnChange: false);

        // System-wide component configuration (child overrides parent)
        builder.AddJsonFile(
            Path.Combine(systemComponentPath, AppSettingsFileName),
            optional: true,
            reloadOnChange: false);

        // User domain configuration (parent)
        builder.AddJsonFile(
            Path.Combine(userDomainPath, AppSettingsFileName),
            optional: true,
            reloadOnChange: false);

        // User component configuration (child overrides parent)
        builder.AddJsonFile(
            Path.Combine(userComponentPath, AppSettingsFileName),
            optional: true,
            reloadOnChange: false);

        // Environment variables (absolute highest priority)
        builder.AddEnvironmentVariables();

        return builder;
    }

    /// <summary>
    /// Adds platform-specific appsettings file based on the current operating system.
    /// Loads appsettings.windows.json, appsettings.macos.json, or appsettings.linux.json.
    /// </summary>
    /// <param name="builder">The configuration builder.</param>
    /// <returns>The configuration builder for chaining.</returns>
    public static IConfigurationBuilder AddCrossPlatform(this IConfigurationBuilder builder)
    {
        var platformSuffix = OperatingSystem.IsWindows() ? "windows" :
                             OperatingSystem.IsMacOS() ? "macos" :
                             OperatingSystem.IsLinux() ? "linux" : null;

        if (platformSuffix != null)
        {
            builder.AddJsonFile($"appsettings.{platformSuffix}.json", optional: true, reloadOnChange: false);
        }

        return builder;
    }
}
