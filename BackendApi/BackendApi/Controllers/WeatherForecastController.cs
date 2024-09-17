using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new()
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<string> Get()
        {
            return Summaries;
        }

        [HttpPost]
        public IActionResult Add(string name)
        {
            Summaries.Add(name);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(int index, string name)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Индекс неверный.");
            }
            Summaries[index] = name;
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Индекс неверный.");
            }
            Summaries.RemoveAt(index);
            return Ok();
        }

        // Добавьте метод для вывода одного наименования по указанному индексу. 
        [HttpGet("{index}")]
        public string GetByIndex(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return "Индекс неверный.";
            }
            return Summaries[index];
        }

        // Добавьте метод для получения количества записей по указываемому имени. 
        [HttpGet("find-by-name")]
        public int GetByName(string name)
        {
            int id=-1;
            do
            {
                id++;

                if (id == Summaries.Count)
                {
                    return -1;
                }
            } while (Summaries[id] != name);
            return id;
        }

        // Добавьте для метода получения всех записей (GetAll) необязательный параметр , который вернёт отсортированный список.

        [HttpGet("GetAll")]
        public IActionResult GetAll(int? sortStrategy)
        {
            // Если значение параметра null - верните список таким, какой он есть.
            if (sortStrategy == null)
            {
                return Ok(Summaries);
            }

            // Если значение параметра 1 - верните отсортированный список по возрастанию.
            if (sortStrategy == 1)
            {
                Summaries.Sort();
                return Ok(Summaries);
            }
            // Если значение параметра -1 - верните отсортированный список по убыванию.
            if (sortStrategy == -1)
            {
                Summaries.Sort();
                Summaries.Reverse();
                return Ok(Summaries);
            }
            // При всех остальных значениях вернуть ошибку (BadRequest) с сообщением “Некорректное значение параметра sortStrategy”

            return BadRequest("Некорректное значение параметра sortStrategy");
        }

    }
}
