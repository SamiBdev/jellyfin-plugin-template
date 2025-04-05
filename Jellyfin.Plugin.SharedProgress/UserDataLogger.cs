using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Library;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.SharedProgress;

public class UserDataLogger
{
    public UserDataLogger(IUserDataManager userDataManager, ILoggerFactory loggerFactory)
    {
        var logger = loggerFactory.CreateLogger("SharedProgress");

        userDataManager.UserDataSaved += (sender, e) =>
        {
            if (e.Item is Episode ep && e.UserData.Played)
            {
                logger.LogInformation($"[SharedProgress] User {e.UserId} a vu : {ep.SeriesName} - {ep.Name}");
            }
        };

        logger.LogInformation("[SharedProgress] Logger initialisé !");
    }
}
