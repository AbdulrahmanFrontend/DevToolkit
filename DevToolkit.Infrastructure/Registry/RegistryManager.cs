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
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryConfiguration.Hive,
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    { 
                        LogManager.LogWarning($"Failed to open base registry key:" +
                            $" {RegistryConfiguration.Hive}");
                        return Result.Failure($"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}");
                    }

                    using (RegistryKey appKey = baseKey.CreateSubKey(RegistryConfiguration.BasePath, 
                        RegistryKeyPermissionCheck.ReadWriteSubTree))
                    {
                        if (appKey == null)
                        {
                            LogManager.LogWarning($"Failed to create subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                            return Result.Failure($"Failed to create subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                        }

                        appKey.SetValue(key, value);

                        LogManager.LogInfo($"Successfully saved registry value for key: {key}");

                        return Result.Success();
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.LogError($"Failed to save registry value for key: {key}", e);
                return Result.Failure($"Failed to save registry value for key: {key}");
            }
        }

        public static Result<T> GetValue<T>(string key, T defaultValue = default)
        {
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryConfiguration.Hive,
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    {
                        LogManager.LogWarning($"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}");
                        return Result<T>.Failure($"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}");
                    }

                    using (RegistryKey appKey = baseKey.OpenSubKey(RegistryConfiguration.BasePath))
                    {
                        if (appKey == null)
                        {
                            LogManager.LogWarning($"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                            return Result<T>.Failure($"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                        }

                        object value = appKey.GetValue(key, defaultValue);

                        if (value == null)
                        { 
                            LogManager.LogWarning($"Registry value for key: {key} " +
                                $"not found, returning default value.");
                            return Result<T>.Failure($"Registry value for key: {key}" +
                                $" not found, returning default value.");
                        }

                        return Result<T>.Success((T)Convert.ChangeType(value, typeof(T)));
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.LogError($"Failed to get registry value for key: {key}", e);
                return Result<T>.Failure($"Failed to get registry value for key: {key}");
            }
        }

        public static Result DeleteValue(string key)
        {
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryConfiguration.Hive,
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    {
                        LogManager.LogWarning($"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}");
                        return Result.Failure($"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}");
                    }

                    using (RegistryKey appKey = baseKey.OpenSubKey(RegistryConfiguration.BasePath,
                        true))
                    {
                        if (appKey == null)
                        {
                            LogManager.LogWarning($"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                            return Result.Failure($"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                        }

                        if (appKey.GetValue(key) != null)
                        { 
                            LogManager.LogInfo($"Deleting registry value for key: {key}");
                            appKey.DeleteValue(key);
                        }

                        return Result.Success();
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.LogError($"Failed to delete registry value for key: {key}", e);
                return Result.Failure($"Failed to delete registry value for key: {key}");
            }
        }

        public static Result<bool> KeyExists(string key)
        {
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryConfiguration.Hive,
                    RegistryView.Default))
                {
                    if (baseKey == null)
                    {
                        LogManager.LogWarning($"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}");
                        return Result<bool>.Failure($"Failed to open base registry key: " +
                            $"{RegistryConfiguration.Hive}");
                    }

                    using (RegistryKey appKey = baseKey.OpenSubKey(RegistryConfiguration.BasePath))
                    {
                        if (appKey == null)
                        {
                            LogManager.LogWarning($"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                            return Result<bool>.Failure($"Failed to open subkey: " +
                                $"{RegistryConfiguration.BasePath}");
                        }

                        return Result<bool>.Success(appKey.GetValue(key) != null);
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.LogError($"Failed to check registry key existence for key: {key}", e);
                return Result<bool>.Failure($"Failed to check registry key existence for key: " +
                    $"{key}");
            }
        }
    }
}
