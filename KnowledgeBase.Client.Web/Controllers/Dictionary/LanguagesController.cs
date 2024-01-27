using KnowledgeBase.Client.Web.Models.Base;
using KnowledgeBase.Client.Web.Models.Dictionary;
using KnowledgeBase.Client.Web.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KnowledgeBase.Client.Web.Controllers.Dictionary
{
    public class LanguagesController : Controller
    {
        private readonly ILanguageService _languageService;
        public LanguagesController(ILanguageService languageService) => _languageService = languageService;

        [Authorize]
        public async Task<IActionResult> Index()
        {
            List<LanguageDTO>? languages = new();

            ResponseDTO? response = await _languageService.ReadLanguagesAsync();

            if (response != null && response.IsSuccess)
            {
                languages = JsonConvert.DeserializeObject<List<LanguageDTO>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(@"~/Views/Dictionary/Languages/Index.cshtml", languages);
        }
    }
}