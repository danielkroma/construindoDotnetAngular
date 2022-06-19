using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento()
                {
                    EventoId = 1,
                    local = "Aqui em casa",
                    DataEvento = DateTime.Now.ToString(),
                    Tema = "testes",
                    Lote = "1º lote",
                    QtdPessoas = 500,
                    ImagemURL = "foto.png"
                },
                new Evento()
                {
                    EventoId = 2,
                    local = "Ver netflix",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "testes",
                    Lote = "2º lote",
                    QtdPessoas = 350,
                    ImagemURL = "foto1.png"
                }
            };
        public EventoController() { }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id );
        }

        [HttpPost]
        public String Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
