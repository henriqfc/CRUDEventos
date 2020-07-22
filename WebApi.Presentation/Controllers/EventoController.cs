using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.DTO;
using WebApi.Application.Interfaces;

namespace WebApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly IApplicationServiceEvento _applicationServiceEvento;


        public EventoController(IApplicationServiceEvento ApplicationServiceEvento)
        {
            _applicationServiceEvento = ApplicationServiceEvento;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceEvento.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceEvento.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] EventoDTO EventoDTO)
        {
            try
            {
                if (EventoDTO == null)
                    return NotFound();

                if (_applicationServiceEvento.ExisteEventoNoHorario(EventoDTO))
                {
                    return BadRequest("Sala já possui evento no horário desejado!");
                }
                _applicationServiceEvento.Add(EventoDTO);
                return Ok("Evento Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] EventoDTO EventoDTO)
        {
            try
            {
                if (EventoDTO == null)
                    return NotFound();
                if (_applicationServiceEvento.ExisteEventoNoHorario(EventoDTO))
                {
                    return BadRequest("Sala já possui evento no horário desejado!");
                }
                _applicationServiceEvento.Update(EventoDTO);
                return Ok("Evento Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var EventoDTO = _applicationServiceEvento.GetById(id);
                if (EventoDTO == null)
                    return NotFound();

                _applicationServiceEvento.Remove(EventoDTO);
                return Ok("Evento Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
