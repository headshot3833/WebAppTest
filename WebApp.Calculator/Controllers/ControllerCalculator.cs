using Microsoft.AspNetCore.Mvc;
using WebApp.Aplication.Services;
using WebApp.AplicationCalculator.Services;
using WebApp.ValueNumbers;

namespace WebApp.Calculator.Controllers
{
    [ApiController]
    public class ControllerCalculator : ControllerBase
    {

        private readonly ServiceCalculator _serviceCalculator;
        public ControllerCalculator( ServiceCalculator serviceCalculator)
        {

            _serviceCalculator = serviceCalculator;
        }
        [HttpPost("Plus")]
        public IActionResult Plus([FromBody] Numbers numbers)
        {
            try
            {
                _serviceCalculator.A = numbers.A;
                _serviceCalculator.B = numbers.B;

                double result = _serviceCalculator.IntPlus();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPost("Multiplication")]
        public IActionResult Multi([FromBody] Numbers numbers)
        {
            _serviceCalculator.A = numbers.A;
            _serviceCalculator.B = numbers.B;

            double result = _serviceCalculator.MultiplicationInt();
            return Ok(result);
        }
        [HttpPost("divide")]
        public IActionResult Divide([FromBody] Numbers numbers)
        {
            _serviceCalculator.A = numbers.A;
            _serviceCalculator.B = numbers.B;

            double result = _serviceCalculator.Divide();
            return Ok(result);
        }
        [HttpPost("Minus")]
        public IActionResult Minus([FromBody] Numbers numbers)
        {
            _serviceCalculator.A = numbers.A;
            _serviceCalculator.B = numbers.B;

            double result = _serviceCalculator.Minus();
            return Ok(result);
        }

    }
}
