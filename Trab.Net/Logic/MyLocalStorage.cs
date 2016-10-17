using System.Collections.Generic;

namespace Trab.Net.Logic
{
    public class MyLocalStorage
    {
        public static void SaveToLocalStorage(string key, object value)
        {
            var settings = Windows.Storage.ApplicationData.Current.LocalSettings;

            if (settings.Values.ContainsKey(key))
            {
                settings.Values[key] = value;
            }
            else
            {
                var obj = new KeyValuePair<string, object>(key, value);
                settings.Values.Add(obj);
            }
        }

        public static object GetFromLocalStorage(string key)
        {
            var settings = Windows.Storage.ApplicationData.Current.LocalSettings;

            var value = settings.Values[key];

            return value;
        }

        public static void RemoveFromLocalStorage(string key)
        {
            var settings = Windows.Storage.ApplicationData.Current.LocalSettings;

            settings.Values.Remove(key);
        }
    }
}
