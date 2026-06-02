using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Results;

namespace DevToolkit.Infrastructure.Configuration
{
    public class AppConfigProvider
    {
        public static Result<string> Get(string key)
        {
            try
            {
                return Result<string>.Success(ConfigurationManager.AppSettings[key]);
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Failed to get app setting for key: {key}", ex);
                return Result<string>.Failure($"Failed to get app setting for key: {key}");
            }
        }

        public static Result Set(string key, string value)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (config.AppSettings.Settings[key] == null)
                {
                    config.AppSettings.Settings.Add(key, value);
                    LogManager.LogInfo($"Adding new app setting for key: {key}");
                }
                else
                {
                    config.AppSettings.Settings[key].Value = value;
                    LogManager.LogInfo($"Updating app setting for key: {key}");
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                return Result.Success();
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Failed to set app setting for key: {key}", ex);
                return Result.Failure($"Failed to set app setting for key: {key}");
            }
        }

        public static Result Remove(string key)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[key] != null)
                {
                    config.AppSettings.Settings.Remove(key);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    LogManager.LogInfo($"Removed app setting for key: {key}");
                    return Result.Success();
                }
                else
                {
                    LogManager.LogWarning($"Attempted to remove non-existent app setting for key: " +
                        $"{key}");
                    return Result.Failure($"Failed to remove app setting for key: {key}");
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Failed to remove app setting for key: {key}", ex);
                return Result.Failure($"Failed to remove app setting for key: {key}");
            }
        }

        public static Result<Dictionary<string, string>> GetAll()
        {
            try
            {
                var settings = ConfigurationManager.AppSettings;
                var result = settings.AllKeys.ToDictionary(k => k, k => settings[k]);
                return Result<Dictionary<string, string>>.Success(result);
            }
            catch (Exception ex)
            {
                LogManager.LogError("Failed to get all app settings", ex);
                return Result<Dictionary<string, string>>.Failure("Failed to get all app settings");
            }
        }

        public static Result Clear()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Clear();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                LogManager.LogInfo("Cleared all app settings");
                return Result.Success();
            }
            catch (Exception ex)
            {
                LogManager.LogError("Failed to clear app settings", ex);
                return Result.Failure("Failed to clear app settings");
            }
        }

        public static Result<bool> ContainsKey(string key)
        {
            try
            {
                return Result<bool>.Success(ConfigurationManager.AppSettings[key] != null);
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Failed to check existence of app setting for key: {key}", ex);
                return Result<bool>.Failure($"Failed to check existence of app setting for key:" +
                    $" {key}");
            }
        }

        public static Result<int> Count()
        {
            try
            {
                return Result<int>.Success(ConfigurationManager.AppSettings.Count);
            }
            catch (Exception ex)
            {
                LogManager.LogError("Failed to count app settings", ex);
                return Result<int>.Failure("Failed to count app settings");
            }
        } 
    }
}
