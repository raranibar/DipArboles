using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles.Model
{
    [DataTable("Ficha")]
    public class Ficha
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("NombreCientifico")]
        public string NombreCientifico { get; set; }
        [JsonProperty("Familia")]
        public string Familia { get; set; }
        [JsonProperty("NombreComun")]
        public string NombreComun { get; set; }
        [JsonProperty("Origen")]
        public string Origen { get; set; }
        [JsonProperty("Etimologia")]
        public string Etimologia { get; set; }
        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }
        [JsonProperty("CultivoUso")]
        public string CultivoUso  { get; set; }
        [JsonProperty("Imagen")]
        public string Imagen { get; set; }
    }
}
