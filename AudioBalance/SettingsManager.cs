using System.IO;
using System.Text.Json;

namespace AudioBalance
{
    public static class SettingsManager
    {
        private static string settingsPath = "settings.json";

        public static AppSettings Load()
        {
            if (!File.Exists(settingsPath))
                return new AppSettings();
            string json = File.ReadAllText(settingsPath);
            return JsonSerializer.Deserialize<AppSettings>(json);
        }

        public static void Save(AppSettings settings)
        {
            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(settingsPath, json);
        }
    }
}
