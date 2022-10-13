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
        private static readonly string SectionNameP1 = "DadosP1";
        private static readonly string SectionNameP2 = "DadosP2";

        public static void SaveP1(DadosP1 settings)
        {
            var appsettings = JObject.Parse(File.ReadAllText(FileName));

            var newSection = JObject.FromObject(settings);

            if (appsettings.ContainsKey(SectionNameP1))
            {
                appsettings.Remove(SectionNameP1);
            }

            appsettings.Add(SectionNameP1, newSection);

            var file = JsonConvert.SerializeObject(appsettings, Formatting.Indented);

            File.WriteAllText(FileName, file);
        }

        public static DadosP1 ReadP1()
        {
            var json = JObject.Parse(File.ReadAllText(FileName));

            if (json.ContainsKey(SectionNameP1))
            {
                return json[SectionNameP1].ToObject<DadosP1>();
            }

            return new DadosP1();
        }

        public static void SaveP2(DadosP2 settings)
        {
            var appsettings = JObject.Parse(File.ReadAllText(FileName));

            var newSection = JObject.FromObject(settings);

            if (appsettings.ContainsKey(SectionNameP2))
            {
                appsettings.Remove(SectionNameP2);
            }

            appsettings.Add(SectionNameP2, newSection);

            var file = JsonConvert.SerializeObject(appsettings, Formatting.Indented);

            File.WriteAllText(FileName, file);
        }

        public static DadosP2 ReadP2()
        {
            var json = JObject.Parse(File.ReadAllText(FileName));

            if (json.ContainsKey(SectionNameP2))
            {
                return json[SectionNameP2].ToObject<DadosP2>();
            }

            return new DadosP2();
        }
    }
}
