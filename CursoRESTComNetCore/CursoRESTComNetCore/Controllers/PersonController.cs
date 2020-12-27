using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoRESTComNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {     

        private readonly ILogger<PersonController> _logger;
        

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Soma(string primeiroNumero, string segundoNumero)
        {
           
            return BadRequest("Valor invalido");
        }


        private decimal ConverterParaDecimal(string numero)
        {
            decimal decimalValor;
            if (decimal.TryParse(numero, out decimalValor))
            {
                return decimalValor;
            }
            return 0;
        }

        private bool IsNumeric(string strNumero)
        {
            double numero;
            bool isNumber = double.TryParse(strNumero, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out numero);
            return isNumber;
        }

    }
}
