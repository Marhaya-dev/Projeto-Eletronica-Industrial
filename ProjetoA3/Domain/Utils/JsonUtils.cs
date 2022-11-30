using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjetoA3.Domain.Models;
using System.IO;
using System.Windows.Forms.Design;

namespace ProjetoA3.Domain.Utils
{
    public static class JsonUtils
    {
        private static readonly string FileName = "appsettings.json";
        private static readonly string SectionNameC1 = "DadosC1";

        public static void SaveC1(DadosC1 settings)
        {
            var appsettings = JObject.Parse(File.ReadAllText(FileName));

            var newSection = JObject.FromObject(settings);

            if (appsettings.ContainsKey(SectionNameC1))
            {
                appsettings.Remove(SectionNameC1);
            }

            appsettings.Add(SectionNameC1, newSection);

            var file = JsonConvert.SerializeObject(appsettings, Formatting.Indented);

            File.WriteAllText(FileName, file);
        }

        public static DadosC1 ReadC1()
        {
            var json = JObject.Parse(File.ReadAllText(FileName));

            if (json.ContainsKey(SectionNameC1))
            {
                return json[SectionNameC1].ToObject<DadosC1>();
            }

            return new DadosC1();
        }

        public static void Save(DadosCRetificadores settings, string sectionName)
        {
            var appsettings = JObject.Parse(File.ReadAllText(FileName));

            var newSection = JObject.FromObject(settings);

            if (appsettings.ContainsKey(sectionName))
            {
                appsettings.Remove(sectionName);
            }

            appsettings.Add(sectionName, newSection);

            var file = JsonConvert.SerializeObject(appsettings, Formatting.Indented);

            File.WriteAllText(FileName, file);
        }

        public static DadosCRetificadores Read(string sectionName)
        {
            var json = JObject.Parse(File.ReadAllText(FileName));

            if (json.ContainsKey(sectionName))
            {
                return json[sectionName].ToObject<DadosCRetificadores>();
            }

            return new DadosCRetificadores();
        }
    }
}
