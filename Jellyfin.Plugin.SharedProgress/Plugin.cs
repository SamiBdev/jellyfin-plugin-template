using System;
using Jellyfin.Plugin.SharedProgress.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Controller.Library;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.SharedProgress;

public class Plugin : BasePlugin<PluginConfiguration>
{
    public static Plugin Instance { get; private set; } = null!;

    public Plugin(
        IApplicationPaths applicationPaths,
        IXmlSerializer xmlSerializer,
        ILoggerFactory loggerFactory,
        IUserDataManager userDataManager)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;

        // Instanciation manuelle ici (plus de DI)
        _ = new UserDataLogger(userDataManager, loggerFactory);
    }


    public override string Name => "SharedProgress";

    public override Guid Id => Guid.Parse("eb5d7894-8eef-4b36-aa6f-5d124e828ce1");

    public override string Description => "Synchronise la progression entre utilisateurs.";
}
