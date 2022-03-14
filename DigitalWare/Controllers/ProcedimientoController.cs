using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedimientoController : ControllerBase
    {
        private readonly IRepositoryQuery _Repository;
        public ProcedimientoController(IRepositoryQuery repository)
        {
            _Repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("AgregarVentas")]
        [HttpPost]
        public IActionResult AgregarVentas([FromBody] Ventas value)
        {
            try
            {
                var Repository = _Repository.InsertVenta(value);
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// COnsulta de procedimiento almacenado  
        /// </summary>
        /// <returns></returns>
        [Route("GetConsulta2")]
        [HttpGet]
        public IActionResult GetConsulta2()
        {
            try
            {
                var Repository = _Repository.GetConsulta2();
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// COnsulta de procedimiento almacenado  
        /// </summary>
        /// <returns></returns>
        [Route("GetConsulta3")]
        [HttpGet]
        public IActionResult GetConsulta3()
        {
            try
            {
                var Repository = _Repository.GetConsulta3();
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// COnsulta de procedimiento almacenado  
        /// </summary>
        /// <returns></returns>
        [Route("GetConsulta4")]
        [HttpGet]
        public IActionResult GetConsulta4()
        {
            try
            {
                var Repository = _Repository.GetConsulta4();
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// COnsulta de procedimiento almacenado  
        /// </summary>
        /// <returns></returns>
        [Route("GetConsulta5")]
        [HttpGet]
        public IActionResult GetConsulta5()
        {
            try
            {
                var Repository = _Repository.GetConsulta5();
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
