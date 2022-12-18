using CalculatorLibrary;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public float Add(float a, float b)
        {
            return CalculationFunctions.Add(a, b);
        }
        [HttpGet]
        public float sub(float a, float b)
        {
            return CalculationFunctions.Sub(a, b);
        }
        [HttpGet]
        public float Multi (float a, float b)
        {
            return CalculationFunctions.Multi(a, b);
        }
        [HttpGet]
        public float Divide(float a, float b)
        {
            return CalculationFunctions.divide(a, b);
        }

    }
}
