using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cr1tBot.Services.Settings
{
    public class SettingsService
    {
        private const string SETTINGS_PATH = "settings.json";
        public Models.Settings GetSettings()
        {
            Models.Settings ret = null;
            if (File.Exists(SETTINGS_PATH))
            {
                using (var streamReader = new StreamReader(SETTINGS_PATH))
                {
                    ret = JsonConvert.DeserializeObject<Models.Settings>(streamReader.ReadToEnd());
                }
            }

            return ret;
        }

        public void WriteSettings(Models.Settings settings)
        {
            using (var streamWriter = new StreamWriter(SETTINGS_PATH))
            {
                streamWriter.Write(JsonConvert.SerializeObject(settings));
            }
        }
    }
}
