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
    public class SalaController : ControllerBase
    {
        private readonly IApplicationServiceSala _applicationServiceSala;


        public SalaController(IApplicationServiceSala ApplicationServiceSala)
        {
            _applicationServiceSala = ApplicationServiceSala;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceSala.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceSala.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] SalaDTO SalaDTO)
        {
            try
            {
                if (SalaDTO == null)
                    return NotFound();

                _applicationServiceSala.Add(SalaDTO);
                return Ok("Sala Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] SalaDTO SalaDTO)
        {
            try
            {
                if (SalaDTO == null)
                    return NotFound();

                _applicationServiceSala.Update(SalaDTO);
                return Ok("Sala Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] SalaDTO SalaDTO)
        {
            try
            {
                if (SalaDTO == null)
                    return NotFound();

                _applicationServiceSala.Remove(SalaDTO);
                return Ok("Sala Removida com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
