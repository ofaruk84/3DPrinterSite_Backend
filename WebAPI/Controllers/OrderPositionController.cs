using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderPositionController : ControllerBase
    {
        IOrderPositionService _orderPositionService;

        public OrderPositionController(IOrderPositionService orderPositionService)
        {
            _orderPositionService = orderPositionService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result =_orderPositionService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyıd")]
        public IActionResult GetById(int id)
        {
            var result = _orderPositionService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyorderıd")]
        public IActionResult GetByOrderId(int id)
        {
            var result = _orderPositionService.GetAllByOrderId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(OrderPosition orderPosition)
        {
            var result = _orderPositionService.Delete(orderPosition);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(OrderPosition orderPosition)
        {
            var result = _orderPositionService.Add(orderPosition);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
