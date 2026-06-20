using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Results;
using DevToolkit.Logging.Managers;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace DevToolkit.Infrastructure.Registry
{
    public class RegistryManager
    {
        public static Result SaveValue(string key, object value)
        {
            string errorMessage = string.Empty;
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(
                    RegistryConfiguration.Hive, 
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    {
                        errorMessage = $"Failed to open base registry key:" +
                            $" {RegistryConfiguration.Hive}.";
                        LogManager.LogWarning(errorMessage);
                        return Result.Failure(errorMessage);
                    }

                    using (RegistryKey appKey = baseKey.CreateSubKey(
                        RegistryConfiguration.BasePath, 
                        RegistryKeyPermissionCheck.ReadWriteSubTree))
                    {
                        if (appKey == null)
                        {
                            errorMessage = $"Failed to create subkey: " +
                                $"{RegistryConfiguration.BasePath}.";
                            LogManager.LogWarning(errorMessage);
                            return Result.Failure(errorMessage);
                        }

                        appKey.SetValue(key, value);

                        LogManager.LogInfo(
                            $"Successfully saved registry value for key: {key}.");

                        return Result.Success();
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = $"Failed to save registry value for key: {key}.";
                LogManager.LogError(errorMessage, e);
                return Result.Failure(errorMessage);
            }
        }

        public static Result<T> GetValue<T>(string key, T defaultValue = default)
        {
            string errorMessage = string.Empty;
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(
                    RegistryConfiguration.Hive,
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    {
                        errorMessage = $"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}.";
                        LogManager.LogWarning(errorMessage);
                        return Result<T>.Failure(errorMessage);
                    }

                    using (RegistryKey appKey = baseKey.OpenSubKey(
                        RegistryConfiguration.BasePath))
                    {
                        if (appKey == null)
                        {
                            errorMessage = $"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}.";
                            LogManager.LogWarning(errorMessage);
                            return Result<T>.Failure(errorMessage);
                        }

                        object value = appKey.GetValue(key, defaultValue);

                        if (value == null)
                        {
                            errorMessage = $"Registry value for key: {key} " +
                                $"not found, returning default value.";
                            LogManager.LogWarning(errorMessage);
                            return Result<T>.Success(defaultValue);
                        }

                        return Result<T>.Success((T)Convert.ChangeType(
                            value, 
                            typeof(T)));
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = $"Failed to get registry value for key: {key}.";
                LogManager.LogError(errorMessage, e);
                return Result<T>.Failure(errorMessage);
            }
        }

        public static Result DeleteValue(string key)
        {
            string errorMessage = string.Empty;
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(
                    RegistryConfiguration.Hive,
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    {
                        errorMessage = $"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}.";
                        LogManager.LogWarning(errorMessage);
                        return Result.Failure(errorMessage);
                    }

                    using (RegistryKey appKey = baseKey.OpenSubKey(
                        RegistryConfiguration.BasePath,
                        true))
                    {
                        if (appKey == null)
                        {
                            errorMessage = $"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}.";
                            LogManager.LogWarning(errorMessage);
                            return Result.Failure(errorMessage);
                        }

                        if (appKey.GetValue(key) != null)
                        { 
                            LogManager.LogInfo(
                                $"Deleting registry value for key: {key}.");
                            appKey.DeleteValue(key);
                        }

                        return Result.Success();
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = $"Failed to delete registry value for key: {key}.";
                LogManager.LogError(errorMessage, e);
                return Result.Failure(errorMessage);
            }
        }

        public static Result<bool> KeyExists(string key)
        {
            string errorMessage = string.Empty;
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(
                    RegistryConfiguration.Hive,
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    {
                        errorMessage = $"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}.";
                        LogManager.LogWarning(errorMessage);
                        return Result<bool>.Failure(errorMessage);
                    }

                    using (RegistryKey appKey = baseKey.OpenSubKey(
                        RegistryConfiguration.BasePath))
                    {
                        if (appKey == null)
                        {
                            errorMessage = $"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}.";
                            LogManager.LogWarning(errorMessage);
                            return Result<bool>.Failure(errorMessage);
                        }

                        return Result<bool>.Success(appKey.GetValue(key) != null);
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = 
                    $"Failed to check registry key existence for key: {key}.";
                LogManager.LogError(errorMessage, e);
                return Result<bool>.Failure(errorMessage);
            }
        }
    }
}
