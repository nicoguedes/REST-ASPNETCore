using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/calculator/S/S
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(decimal firstNumber, decimal secondNumber)
        {
            return Ok(firstNumber + secondNumber);
        }
    }
}
