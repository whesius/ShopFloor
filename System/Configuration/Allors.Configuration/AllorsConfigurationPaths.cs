// <copyright file="AllorsConfigurationPaths.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Configuration;

/// <summary>
/// Provides path resolution for Allors configuration files.
/// </summary>
public static class AllorsConfigurationPaths
{
    private const string AllorsDirectoryName = "allors";
    private const string WindowsProgramDataPath = @"C:\ProgramData\Allors";

    /// <summary>
    /// Gets the system-wide configuration path for a domain.
    /// On Windows: C:\ProgramData\Allors\{domain}\
    /// On Linux/macOS: /etc/allors/{domain}/
    /// </summary>
    public static string GetSystemPath(string domain)
    {
        if (OperatingSystem.IsWindows())
        {
            return Path.Combine(WindowsProgramDataPath, domain);
        }

        return Path.Combine("/etc", AllorsDirectoryName, domain);
    }

    /// <summary>
    /// Gets the system-wide configuration path for a domain component.
    /// On Windows: C:\ProgramData\Allors\{domain}\{component}\
    /// On Linux/macOS: /etc/allors/{domain}/{component}/
    /// </summary>
    public static string GetSystemPath(string domain, string component)
    {
        if (OperatingSystem.IsWindows())
        {
            return Path.Combine(WindowsProgramDataPath, domain, component);
        }

        return Path.Combine("/etc", AllorsDirectoryName, domain, component);
    }

    /// <summary>
    /// Gets the user-local configuration path for a domain.
    /// On all platforms: ~/.allors/{domain}/
    /// </summary>
    public static string GetUserPath(string domain)
    {
        var homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return Path.Combine(homeDirectory, $".{AllorsDirectoryName}", domain);
    }

    /// <summary>
    /// Gets the user-local configuration path for a domain component.
    /// On all platforms: ~/.allors/{domain}/{component}/
    /// </summary>
    public static string GetUserPath(string domain, string component)
    {
        var homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return Path.Combine(homeDirectory, $".{AllorsDirectoryName}", domain, component);
    }
}
