using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvent.API.Data;
using ProEvent.API.Models;

namespace ProEvent.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {


        public DataContext _context { get; }
        public EventosController(DataContext context)
        {
            _context = context;
            
        }

         [HttpGet]
        public IEnumerable<Evento> Get()
        { 
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        { 
            return _context.Eventos.Where(evento => evento.EventoID == id);
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
