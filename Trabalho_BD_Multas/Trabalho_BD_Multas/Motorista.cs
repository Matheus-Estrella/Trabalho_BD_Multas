using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_BD_Multas
{
    public class Motorista
    {
        [JsonProperty("penalidades_aplicadas")]
        public List<PenalidadesAplicadas> X { get; set; }
    }
}
