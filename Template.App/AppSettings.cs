using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.App;

/// <summary>
/// The run time settings for the application.
/// The following values are loaded from the appsettings.json at startup.
/// </summary>
public class AppSettings
{
    public string ServiceUri { get; init; } = string.Empty;

    public string SecretKeyOne { get; init; } = string.Empty;

    public string SecretKeyTwo { get; init; } = string.Empty;

}