using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_BD_Multas
{
    public class PenalidadesAplicadas
    {
        [JsonProperty("razao_social")]
        public string Razao_Social { get; set; }

        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }

        [JsonProperty("nome_motorista")]
        public string Nome_Motorista { get; set; }

        [JsonProperty("cpf")]
        public string CPF { get; set; }

        [JsonProperty("vigencia_do_cadastro")]
        public DateTime Vigencia_Cadastro { get; set; }

        public override string ToString() => $"Razão Social: {Razao_Social}, CNPJ: {CNPJ}," +
            $" Motorista: {Nome_Motorista}, CPF: {CPF}, Vigência: {Vigencia_Cadastro:dd/MM/aaaa}";
    }
}
