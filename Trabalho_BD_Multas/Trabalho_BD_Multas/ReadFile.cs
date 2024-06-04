using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_BD_Multas
{
    public class ReadFile
    {
        public static List<PenalidadesAplicadas> GetData()
        {
            string path = @"C:\Users\Matheus\Desktop\TRABALHOS\Trabalho_BD_Multas";
            string file = "\\motoristas_habilitados.json";

            StreamReader sr = new StreamReader(path + file);
            string string_jason = sr.ReadToEnd();

            var lst = JsonConvert.DeserializeObject<Motorista>(string_jason, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            if (lst != null) return lst.X;
            return null;
        }
    }
}
