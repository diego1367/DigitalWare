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
    public class OpheliaController : ControllerBase
    {
        private readonly IRepository _Repository;
        public OpheliaController(IRepository repository)
        {
            _Repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("GetProductos")]
        [HttpGet]
        public IActionResult GetProductos()
        {
            try
            {
                var Repository = _Repository.GetProductos();
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("GetClientes")]
        [HttpGet]
        public IActionResult GetClientes()
        {
            try
            {
                var Repository = _Repository.GetClientes();
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetProducto{id}")]
        [HttpGet]
        public IActionResult GetProducto(int id)
        {
            try
            {
                var Repository = _Repository.GetProducto(id);
                return Ok(Repository);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// consulta por id de cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetCliente{id}")]
        [HttpGet]
        public IActionResult GetCliente(int id)
        {
            try
            {
                var Repository = _Repository.GetCliente(id);
                return Ok(Repository);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NuevoProducto"></param>
        /// <returns></returns>
        [Route("AgregarProducto")]
        [HttpPost]
        public IActionResult AgregarProducto([FromBody] Productos NuevoProducto)
        {
            try
            {
                var Repository = _Repository.AddProducto(NuevoProducto);
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NuevoCliente"></param>
        /// <returns></returns>
        [Route("AgregarCliente")]
        [HttpPost]
        public IActionResult AgregarCliente([FromBody] Clientes NuevoCliente)
        {
            try
            {
                var Repository = _Repository.AddCliente(NuevoCliente);
                return Ok(Repository);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("EliminarProducto{id}")]
        [HttpDelete]
        public IActionResult EliminarProducto(int id)
        {
            try
            {
                var Repository = _Repository.DeleteProducto(id);
                return Ok(Repository);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("EliminarCliente{id}")]
        [HttpDelete]
        public IActionResult EliminarCliente(int id)
        {
            try
            {
                var Repository = _Repository.DeleteCliente(id);
                return Ok(Repository);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("ActualizarProducto")]
        [HttpPut]
        public IActionResult ActualizarProducto([FromBody] Productos ModificacionProducto)
        {
            try
            {
                var Repository = _Repository.UpdateProducto(ModificacionProducto);
                return Ok(Repository);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
