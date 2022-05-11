using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                local = "recife",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemUrl = "imagem.png "
                },      
                new Evento(){
                EventoId = 2,
                Tema = "Angular 11 e suas novidades",
                local = "Sao Paulo",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString("yyyy/mm/dd"),
                ImagemUrl = "imagem1.png "
                },                
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
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id); 
        }
        [HttpPost]
        public string Post()
        { 
            return "value";
        }
    }
}
