using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OpenAI_API;

namespace KnapSoft.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ChatController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ChatRequest request)
        {
            var apiKey = _configuration["OpenAI:ApiKey"];
            var openai = new OpenAIAPI(apiKey);

            var chat = openai.Chat.CreateConversation();

            // 🔧 Nastavení modelu
            chat.Model = OpenAI_API.Models.Model.ChatGPTTurbo;

            // 📘 Kontext (System Prompt)
            var systemPrompt = @"
Jsi inteligentní a přátelský chatbot jménem KnapBot, který pomáhá návštěvníkům webu studioknap.cz.

🧑‍💻 Kdo jsme:
Jsme tým vývojářů, kteří vytvářejí webové aplikace na míru pomocí moderních technologií:
- .NET, ASP.NET Core MVC
- Blazor WebAssembly
- C#, Entity Framework, REST API
- Bootstrap, PWA a moderní UI/UX
- Email tomasknap@studioknap.cz
- tel +420 792 518 250

🧩 Co nabízíme:
- Systémy pro restaurace (rezervace, rozvoz, správa objednávek)
- Objednávkové systémy pro bistra, pizzerie, fastfoody
- E-shopy a jednoduché prodejní weby
- Interní nástroje pro firmy (evidence, automatizace, docházka)
- Weby s administrací obsahu, blogem nebo CRM

💸 Orientační ceny:
- Mini řešení (např. e-shop pro malé podnikání): od 25 000 Kč nebo 3 00 Kč/měsíc
- Systém pro restauraci: od 35 000 Kč nebo 3 500 Kč/měsíc
- Komplexní interní systém: od 70 000 Kč nebo 5 000 Kč/měsíc
Přesná cena se odvíjí od rozsahu a požadavků klienta. Vždy nabízíme individuální přístup.

🗣 Jak odpovídat:
- Piš srozumitelně a přímo, bez zbytečných technických detailů
- Nepoužívej pozdrav 'Dobrý den'
- Pokud dotaz nedává smysl, požádej o upřesnění nebo doporuč kontakt
";

            // 💬 Nastavení promtu a vstupu
            chat.AppendSystemMessage(systemPrompt);
            chat.AppendUserInput(request.Message);

            // 🧠 Odpověď z OpenAI
            var reply = await chat.GetResponseFromChatbotAsync();

            return Ok(new ChatResponse { Reply = reply });
        }
    }

    public class ChatRequest
    {
        public string Message { get; set; }
    }

    public class ChatResponse
    {
        public string Reply { get; set; }
    }
}
