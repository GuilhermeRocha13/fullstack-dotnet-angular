using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEvent.API.Models
{
    public class Evento
    {
        public int EventoID { get; set; }
        public string local{ get; set; }
        public string dataEvento{ get; set; }
        public string tema{ get; set; }
        public int qtPessoas{ get; set; }
        public int lote{ get; set; }
        public string imagemURL{ get; set; }
    }
}