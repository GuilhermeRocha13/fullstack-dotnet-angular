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

        public IEnumerable<Evento> _evento = new Evento[] { //as propriedades do novo objeto é definido entre chaves
                new Evento() {
                    EventoID = 1,
                    local = "BELO HORIZON", 
                    dataEvento = DateTime.Now.AddDays(1).ToString(),
                    qtPessoas = 50,
                    lote = 3
                },
                new Evento() {
                    EventoID = 2,
                    local = "PARANÃ", 
                    dataEvento = DateTime.Now.AddDays(2).ToString(),
                    qtPessoas = 30,
                    lote = 3
                }
            };
        public EventoController()
        {

        }

         [HttpGet]
        public IEnumerable<Evento> Get()
        { 
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        { 
            return _evento.Where(evento => evento.EventoID == id);
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
