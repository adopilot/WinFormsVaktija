using AndroidMujezin.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AndroidMujezin.Servisi
{
    public class NamazConfigPreferences
    {
        

        public static NamazConfigModel GetNamazConfig()
        {
            var json = Preferences.Get("namaz_config", string.Empty);
            if (string.IsNullOrEmpty(json))
            {
                return new NamazConfigModel();
            }
            return JsonSerializer.Deserialize<NamazConfigModel>(json);
        }

        public static void SaveNamazConfig(NamazConfigModel namazConfig)
        {

            var json = JsonSerializer.Serialize<NamazConfigModel>(namazConfig?? new NamazConfigModel());
            Preferences.Set("namaz_config", json);
        }

        public static void SaveNamazConfigProperty<T>(NamazEnum namaz, string propertyName, T value)
        {
            var namazConfig = GetNamazConfig();
            var namazModel = namazConfig.GetType().GetProperty(namaz.ToString()).GetValue(namazConfig) as NamazModel;
            namazModel.GetType().GetProperty(propertyName).SetValue(namazModel, value);
            SaveNamazConfig(namazConfig);
        }
    }
}

