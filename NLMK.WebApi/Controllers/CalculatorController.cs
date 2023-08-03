using Microsoft.AspNetCore.Mvc;

namespace NLMK.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<double> GetAsync(int divident, int divider)
        {
            try
            {
                double result = (double)divident / divider;

                return Task.FromResult(Math.Round(result, 3));
            }
            catch(Exception ex)
            {
                _logger.LogError($"Делимое: {divident}. Делитель: {divider}. Ошибка: {ex}");
                throw;
            }
        }
    }
}