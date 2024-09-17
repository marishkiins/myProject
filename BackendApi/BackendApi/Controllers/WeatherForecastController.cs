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
                return BadRequest("������ ��������.");
            }
            Summaries[index] = name;
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("������ ��������.");
            }
            Summaries.RemoveAt(index);
            return Ok();
        }

        // �������� ����� ��� ������ ������ ������������ �� ���������� �������. 
        [HttpGet("{index}")]
        public string GetByIndex(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return "������ ��������.";
            }
            return Summaries[index];
        }

        // �������� ����� ��� ��������� ���������� ������� �� ������������ �����. 
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

        // �������� ��� ������ ��������� ���� ������� (GetAll) �������������� �������� , ������� ����� ��������������� ������.

        [HttpGet("GetAll")]
        public IActionResult GetAll(int? sortStrategy)
        {
            // ���� �������� ��������� null - ������� ������ �����, ����� �� ����.
            if (sortStrategy == null)
            {
                return Ok(Summaries);
            }

            // ���� �������� ��������� 1 - ������� ��������������� ������ �� �����������.
            if (sortStrategy == 1)
            {
                Summaries.Sort();
                return Ok(Summaries);
            }
            // ���� �������� ��������� -1 - ������� ��������������� ������ �� ��������.
            if (sortStrategy == -1)
            {
                Summaries.Sort();
                Summaries.Reverse();
                return Ok(Summaries);
            }
            // ��� ���� ��������� ��������� ������� ������ (BadRequest) � ���������� ������������� �������� ��������� sortStrategy�

            return BadRequest("������������ �������� ��������� sortStrategy");
        }

    }
}
