using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.SharedProgress.Configuration;

/// <summary>
/// Configuration du plugin SharedProgress.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initialise une nouvelle instance avec des valeurs par défaut.
    /// </summary>
    public PluginConfiguration()
    {
        EnableSync = true;
    }

    /// <summary>
    /// Active ou désactive la synchronisation de progression.
    /// </summary>
    public bool EnableSync { get; set; }
}
