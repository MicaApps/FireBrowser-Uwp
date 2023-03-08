﻿using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;

namespace FireBrowserInterop
{
    public static class SettingsHelper
    {
        private static readonly ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        public static string GetSetting(string Setting)
        {
            string SettingValue = localSettings.Values[Setting] as string;
            return SettingValue;
        }

        public static void SetSetting(string Setting, string SettingValue)
        {
            localSettings.Values[Setting] = SettingValue;
        }

    }
}
