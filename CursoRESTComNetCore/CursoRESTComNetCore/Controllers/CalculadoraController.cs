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
    public class CalculadoraController : ControllerBase
    {     

        private readonly ILogger<CalculadoraController> _logger;
        

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Soma(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = ConverterParaDecimal(primeiroNumero) + ConverterParaDecimal(segundoNumero);

                return Ok(sum.ToString());
            }
            return BadRequest("Valor invalido");
        }

        [HttpGet("sub/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Subtracao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sub = ConverterParaDecimal(primeiroNumero) - ConverterParaDecimal(segundoNumero);

                return Ok(sub.ToString());
            }
            return BadRequest("Valor invalido");
        }

        [HttpGet("mult/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Multiplicacao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var mult = ConverterParaDecimal(primeiroNumero) * ConverterParaDecimal(segundoNumero);

                return Ok(mult.ToString());
            }
            return BadRequest("Valor invalido");
        }

        [HttpGet("div/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Divisao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var div = ConverterParaDecimal(primeiroNumero) / ConverterParaDecimal(segundoNumero);

                return Ok(div.ToString());
            }
            return BadRequest("Valor invalido");
        }

        [HttpGet("media/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Media(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var media = (ConverterParaDecimal(primeiroNumero) + ConverterParaDecimal(segundoNumero))/2;

                return Ok(media.ToString());
            }
            return BadRequest("Valor invalido");
        }

        [HttpGet("raiz/{numero}")]
        public IActionResult Raiz(string numero)
        {
            if (IsNumeric(numero))
            {
                var raiz = Math.Sqrt((double)ConverterParaDecimal(numero));

                return Ok(raiz.ToString());
            }
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
