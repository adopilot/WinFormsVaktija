using AndroidMujezin.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AndroidMujezin.Servisi
{
    public class ConfigServis
    {

        JsonSerializerOptions _serializerOptions;
        public ConfigServis()
        {
            _serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true

            };
        }

        public Modeli.MjestoModel GetMjestoModel()
        {
            var model = new Modeli.MjestoModel();

            model.MjestoNaziv = Preferences.Get("MjestoNaziv", "Banovići");
            model.MjestoIx = Preferences.Get("MjestoIx", 0);
            return model;


        }

        public PocoMsg SetMjestoModel(Modeli.MjestoModel model)
        {

            try
            {
                Preferences.Set("MjestoIx", model?.MjestoIx ?? 0);

                Preferences.Set("MjestoNaziv", model?.MjestoNaziv ?? "Banovići");

                return new PocoMsg() { Msg = "Postavke uspiješno spašene", Valid = true };
            }
            catch (Exception ex)
            {
                return new PocoMsg() { Msg = $"Greška kod spašavanja postavki ex: {ex.Message}" };

            }
        }
        public PocoMsg SetNamazModel (Modeli.NamazConfigModel model){
            try
            {
                string Zora = JsonSerializer.Serialize((model?.Zora ?? new NamazModel() { Namaz = NamazEnum.Zora }), options: _serializerOptions);
                Preferences.Set("Zora", Zora);

                string IzlazakSunca = JsonSerializer.Serialize((model?.IzlazakSunca ?? new NamazModel() { Namaz = NamazEnum.IzlazakSunca }), options: _serializerOptions);
                Preferences.Set("IzlazakSunca", IzlazakSunca);

                string Podne = JsonSerializer.Serialize((model?.Podne ?? new NamazModel() { Namaz = NamazEnum.Podne }), options: _serializerOptions);
                Preferences.Set("Podne", Podne);

                string Ikindija = JsonSerializer.Serialize((model?.Ikindija ?? new NamazModel() { Namaz = NamazEnum.Ikindija }), options: _serializerOptions);
                Preferences.Set("Ikindija", Ikindija);

                string Aksam = JsonSerializer.Serialize((model?.Aksam ?? new NamazModel() { Namaz = NamazEnum.Aksam }), options: _serializerOptions);
                Preferences.Set("Aksam", Aksam);

                string Jacija = JsonSerializer.Serialize((model?.Jacija ?? new NamazModel() { Namaz = NamazEnum.Jacija }), options: _serializerOptions);
                Preferences.Set("Jacija", Jacija);

                string Dzuma = JsonSerializer.Serialize((model?.Dzuma ?? new NamazModel() { Namaz = NamazEnum.Dzuma }), options: _serializerOptions);
                Preferences.Set("Dzuma", Dzuma);

                return new PocoMsg() { Valid = true, Msg = "Spasili smo kofiguraciju namaza" };
            }
            catch (Exception ex)
            {
                return new PocoMsg() { Msg = $"Greška kod zapisa konfiguracije ex: {ex.Message}" };
            }
        }
        public NamazConfigModel GetNamazModel()
        {
            NamazConfigModel model = new NamazConfigModel();

            string Zora = Preferences.Get("Zora", string.Empty); 
            if (!string.IsNullOrEmpty(Zora))
             model.Zora = JsonSerializer.Deserialize<NamazModel>(Zora, options: _serializerOptions);
            

            string IzlazakSunca = Preferences.Get("IzlazakSunca", string.Empty); 
            if (!string.IsNullOrEmpty(IzlazakSunca))
             model.IzlazakSunca= JsonSerializer.Deserialize<NamazModel>(IzlazakSunca, options: _serializerOptions);
            

            string Podne = Preferences.Get("Podne", string.Empty); 
            if (!string.IsNullOrEmpty(Podne))
            model.Podne = JsonSerializer.Deserialize<NamazModel>(Podne, options: _serializerOptions);
            

            string Ikindija = Preferences.Get("Ikindija", string.Empty);
            if (!string.IsNullOrEmpty(Ikindija)) 
            model.Ikindija = JsonSerializer.Deserialize<NamazModel>(Ikindija, options: _serializerOptions);
            

            string Aksam = Preferences.Get("Aksam", string.Empty); 
            if (!string.IsNullOrEmpty(Aksam))
                model.Aksam = JsonSerializer.Deserialize<NamazModel>(Aksam, options: _serializerOptions);
            

            string Jacija = Preferences.Get("Jacija", string.Empty);
            if (!string.IsNullOrEmpty(Jacija))  
            model.Jacija = JsonSerializer.Deserialize<NamazModel>(Jacija, options: _serializerOptions);
            
            string Dzuma = Preferences.Get("Dzuma", string.Empty);
            if (!string.IsNullOrEmpty(Dzuma))   
            model.Dzuma = JsonSerializer.Deserialize<NamazModel>(Dzuma, options: _serializerOptions);
            


            return model;

        }
      
    }
}
