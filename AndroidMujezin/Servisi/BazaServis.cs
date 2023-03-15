using AndroidMujezin.Modeli;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AndroidMujezin.Servisi
{
    public class BazaServis
    {
        private JsonSerializerOptions _serializerOptions;
        private ConfigServis _configServis;


        public BazaServis(VaktijaApiServis vaktijaApiServis, ConfigServis configServis)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            _configServis = configServis;
        }

        public async Task<AudioModel> SaveAudio(AudioModel model)
        {
            string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, Path.GetFileName(model.Name));


            //using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(sourceFile);
            using Stream fileStream =  File.OpenRead(model.FullPath);
            using StreamReader reader = new StreamReader(fileStream);

            string content = await reader.ReadToEndAsync();

            // Transform file content to upper case text
            content = content.ToUpperInvariant();

            // Write the file content to the app data directory
            

            using FileStream outputStream = System.IO.File.OpenWrite(targetFile);
            using StreamWriter streamWriter = new StreamWriter(outputStream);

            await streamWriter.WriteAsync(content);



            model.FullPath = targetFile;
            return model;
            
        }
        public List<AudioModel> AudioBaza()
        {
            List<AudioModel> baza = new List<AudioModel>();

            FileSystem.OpenAppPackageFileAsync("amplePhone.mp3");

            baza.Add( new AudioModel() {  EmbededResoce=true, FullPath= "HazimLepirEzan.mp3" , IsUsed=true, Name= "Hazim Lepir Ezan" });
            baza.Add( new AudioModel() {  EmbededResoce=true,  FullPath= "HazimLepirEzan.mp3" , IsUsed=true, Name= "Hazim Lepir Sabahski Ezan" });

            string[] fileEntries = Directory.GetFiles(FileSystem.AppDataDirectory, "*.mp3");
            
            foreach (string fileEntry in fileEntries)
            {

                var audioModel = new AudioModel() { EmbededResoce = false, FullPath = fileEntry, IsUsed = false, Name = Path.GetFileName(fileEntry) };
                baza.Add( audioModel );

            }

            return baza;
        }
        
        private bool IsUsedInFiles(string path)
        {
            var files = new List<string>();
            var namazi = _configServis.GetNamazModel();
            if (!string.IsNullOrEmpty(namazi.Zora.FajlaZaEzan))
            {
                files.Add(namazi.Zora.FajlaZaEzan);
            }
            if (!string.IsNullOrEmpty(namazi.IzlazakSunca.FajlaZaEzan))
            {
                files.Add(namazi.IzlazakSunca.FajlaZaEzan);
            }
            if (!string.IsNullOrEmpty(namazi.Podne.FajlaZaEzan))
            {
                files.Add(namazi.Podne.FajlaZaEzan);
            }
            if (!string.IsNullOrEmpty(namazi.Dzuma.FajlaZaEzan))
            {
                files.Add(namazi.Dzuma.FajlaZaEzan);
            }
            if (!string.IsNullOrEmpty(namazi.Ikindija.FajlaZaEzan))
            {
                files.Add(namazi.Ikindija.FajlaZaEzan);
            }
            if (!string.IsNullOrEmpty(namazi.Aksam.FajlaZaEzan))
            {
                files.Add(namazi.Aksam.FajlaZaEzan);
            }
            if (!string.IsNullOrEmpty(namazi.Jacija.FajlaZaEzan))
            {
                files.Add(namazi.Jacija.FajlaZaEzan);
            }

            return files.Any(x => x.ToLower() == path.ToLower());
        }

        public PocoMsg SpasiBazuMjesec(VaktijaZaMjesec model,CancellationToken cancellationToken)
        {
            var fileName = FileName(model.id,model.godina,model.mjesec);
            if (System.IO.File.Exists(fileName))
            {
                try
                {
                    System.IO.File.Delete(fileName);
                }
                catch (Exception ex)
                {
                    return new PocoMsg() { Msg = $"Nisam uspijeo obrisati staru bazu sa greškom:{ex.Message}" };
                }
            }
            try
                {
                    string data = JsonSerializer.Serialize(model.dan,_serializerOptions);
                    System.IO.File.WriteAllText(fileName, data);
                    return new PocoMsg() { Msg="Spasili smo podateke",Valid=true };
                }
                catch (Exception ex)
                {
                    return new PocoMsg() { Msg = $"Greška u pisanju baze na disk ex:{ex.Message}" };
                }
        }
        public  List<Dan> UcitajBazuMjesec(int id, int godina , int mjesec)
        {
            var fileName = FileName(id, godina, mjesec);
            if (!System.IO.File.Exists(fileName))
                throw new Exception($"Nisam našao bazu na disku");

            string data = File.ReadAllText(fileName);

            return JsonSerializer.Deserialize<List<Dan>>(data, _serializerOptions);
        }

        public List<FajlaModel> BazeZaMjesto(MjestoModel model)
        {
            List<FajlaModel> fajlaModels = new List<FajlaModel>();
            var targetDirectory = FileSystem.AppDataDirectory;

            var fileEntries = Directory.GetFiles(targetDirectory,$"VaktijaId:{model.MjestoIx}_Godina:*_Mjesec:*.json");
            foreach ( var fileEntry in fileEntries)
            {
                fajlaModels.Add(new FajlaModel() {Path= fileEntry, Mjesto= model  });
            }
            return fajlaModels;
        } 
        public PocoMsg CheckBazu(int id, int godina, int mjesec)
        {
            try
            {

                var baza = UcitajBazuMjesec(id,godina,mjesec);

                if ((baza?.Count()??0) == 0)
                    return new PocoMsg() { Msg = "Nisam učitao bazu podata nemam zapisa" };

                var dani = baza.Count();
                
                return new PocoMsg() { Valid = true, Msg = $"Baza za " };
            }
            catch (Exception ex)
            {
                return new PocoMsg() { Msg = $"Nisam učitao bazu sa greškom {ex.Message}" };
            }
        }
        private string FileName(int id, int godina, int mjesec) =>  $"{FileSystem.AppDataDirectory}/VaktijaId:{id}_Godina:{godina}_Mjesec:{mjesec}.json";
            
    }
}
