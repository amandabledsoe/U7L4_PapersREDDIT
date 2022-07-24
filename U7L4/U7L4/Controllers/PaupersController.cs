using Microsoft.AspNetCore.Mvc;
using U7L4.Models;

namespace U7L4.Controllers
{
    public class PaupersController : Controller
    {
        private readonly ILogger<PaupersController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public PaupersController(ILogger<PaupersController> logger, IHttpClientFactory newHttpClientFactory)
        {
            _httpClientFactory = newHttpClientFactory;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //1. First, create an HTTP Client via the Client Factory to enable the ability send and receive a response to the API:
            HttpClient httpClient = _httpClientFactory.CreateClient();

            //2. Second, find the URL to call the API, and set it as a constant for use later.
            const string redditApiUrl = "https://www.reddit.com/r/aww/.json";

            //3. See if you have to send the API anything. Nothing required in this case.

            //4. Create a Model that models the returned response from the API. 
            //See 'RedditSimpleResponse.cs'

            //5. Call the API using the GetFromJasonAsync method attached to the HTTP Client. 
            //Dont forget to add GetAwaiter() and GetResult()
            var apiResponse = httpClient.GetFromJsonAsync<RedditSimpleResponse>(redditApiUrl).GetAwaiter().GetResult();

            //6. Create a new instance of the API Response Model and store the API response you get into that instance.
            var redditPostsToDisplay = apiResponse;

            //Finally, pass the API Response Model instance to the view so we can see what what are working with!
            return View(redditPostsToDisplay);
        }
    }
}
