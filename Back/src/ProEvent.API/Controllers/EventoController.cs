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

        [HttpGet]
        public Evento Get()
        { 
            return new Evento(){ //as propriedades do novo objeto é definido entre chaves
                EventoID = 1
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
