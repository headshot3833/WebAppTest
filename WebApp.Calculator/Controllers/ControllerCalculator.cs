using Microsoft.AspNetCore.Mvc;
using WebApp.Aplication.Services;
using WebApp.ValueNumbers;

namespace WebApp.Calculator.Controllers
{
    [ApiController]
    public class ControllerCalculator : ControllerBase
    {
        private readonly PlusService _plusService;
        private readonly MinusService _minusService;
        private readonly MultiplicationService _multiplicationService;
        private readonly DivideService _divideService;
        public ControllerCalculator(PlusService plusService, DivideService divideService, MultiplicationService multiplicationService, MinusService minusService)
        {
            _plusService = plusService;
            _divideService = divideService;
            _multiplicationService = multiplicationService;
            _minusService = minusService;
        }
        [HttpPost("Plus")]
        public IActionResult Plus([FromBody] Numbers numbers)
        {
            try
            {
                _plusService.A = numbers.A;
                _plusService.B = numbers.B;

                double result = _plusService.IntPlus();
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
            _multiplicationService.A = numbers.A;
            _multiplicationService.B = numbers.B;

            double result = _multiplicationService.MultiplicationInt();
            return Ok(result);
        }
        [HttpPost("divide")]
        public IActionResult Divide([FromBody] Numbers numbers)
        {
            _divideService.A = numbers.A;
            _divideService.B = numbers.B;

            double result = _divideService.Divide();
            return Ok(result);
        }
        [HttpPost("Minus")]
        public IActionResult Minus([FromBody] Numbers numbers)
        {
            _minusService.A = numbers.A;
            _minusService.B = numbers.B;

            double result = _minusService.Minus();
            return Ok(result);
        }

    }
}
