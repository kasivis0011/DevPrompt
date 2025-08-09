using DevPrompt.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AICodingHelperWeb.Controllers
{
    public class AssistantController : Controller
    {
        private readonly OllamaService _ollamaService;

        public AssistantController(OllamaService ollamaService)
        {
            _ollamaService = ollamaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ask(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                ViewBag.Response = "Please enter a question.";
                return View("Index");
            }

            var response = await _ollamaService.AskAsync(prompt);
            ViewBag.Response = response;
            ViewBag.Prompt = prompt;

            return View("Index");
        }
    }
}
