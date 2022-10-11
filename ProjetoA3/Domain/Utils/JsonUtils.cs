using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjetoA3.Domain.Settings;
using System.IO;
using System.Windows.Forms.Design;

namespace ProjetoA3.Domain.Utils
{
    public static class JsonUtils
    {
        private static readonly string FileName = "appsettings.json";
        private static readonly string SectionName = "Dados";

        public static void Save(Dados settings)
        {
            var appsettings = JObject.Parse(File.ReadAllText(FileName));

            var newSection = JObject.FromObject(settings);

            if (appsettings.ContainsKey(SectionName))
            {
                appsettings.Remove(SectionName);
            }

            appsettings.Add(SectionName, newSection);

            var file = JsonConvert.SerializeObject(appsettings, Formatting.Indented);

            File.WriteAllText(FileName, file);
        }

        public static Dados Read()
        {
            var json = JObject.Parse(File.ReadAllText(FileName));

            if (json.ContainsKey(SectionName))
            {
                return json[SectionName].ToObject<Dados>();
            }

            return new Dados();
        }
    }
}
