using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EventoController : ControllerBase
    {
        private DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;   
        }

        [HttpGet]

        public IEnumerable<Evento> Get(){
            return _context.Eventos;
        }
    }
}