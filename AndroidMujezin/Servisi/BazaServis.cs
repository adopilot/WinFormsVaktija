using AndroidMujezin.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AndroidMujezin.Servisi
{
    public class BazaServis
    {
        JsonSerializerOptions _serializerOptions;
        
        
        public BazaServis(VaktijaApiServis vaktijaApiServis)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        
        }


        public PocoMsg SpasiBazuMjesec(VaktijaZaMjesec model)
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
