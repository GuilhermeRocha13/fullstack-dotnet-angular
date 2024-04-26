using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvent.API.Models;

namespace ProEvent.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {

        }

        [HttpGet("{evento}")]
        public Evento Get(string evento)
        { 
            return new Evento(){ //as propriedades do novo objeto é definido entre chaves
                EventoID = 1,
                local = "BH",
                dataEvento = DateTime.Now.AddDays(1).ToString(),
                qtPessoas = 50,
                lote = "3"
            };
        }


        [HttpPost]

        public string Post(){
            return "post";
        }
        
        [HttpPut("{id}")]

        public string Post(int id){
            return "post" + id;
        }
    }
}
