using Microsoft.AspNetCore.Mvc;
using QuoteGenerator.Models;


namespace QuoteGenerator.Controllers
{
    public class QuoteController : Controller
    {
        private static readonly List<Quote> Quotes = new List<Quote>
        {
            new Quote { Text = " 'The only way to do great work is to love what you do.'", Author = "Steve Jobs" },
            new Quote { Text = "'In three words I can sum up everything I've learned about life: it goes on.'", Author = "Robert Frost" },
            new Quote { Text = "'Success is not final, failure is not fatal: It is the courage to continue that counts.'", Author = "Winston Churchill" },
            new Quote { Text = "'Your time is limited, don't waste it living someone else's life.'", Author = "Steve Jobs" },
            new Quote { Text = "'The future belongs to those who believe in the beauty of their dreams.'", Author = "Eleanor Roosevelt" },
            new Quote { Text = "'Life is what happens when you're busy making other plans.'", Author = "John Lennon" },
            new Quote { Text = "'The only limit to our realization of tomorrow will be our doubts of today.'", Author = "Franklin D. Roosevelt" },
            new Quote { Text = "'Do not wait to strike till the iron is hot, but make it hot by striking.'", Author = "William Butler Yeats" },
            new Quote { Text = "'The best way to predict the future is to create it.'", Author = "Peter Drucker'" },
            new Quote { Text = "'It is not the strongest of the species that survive, nor the most intelligent, but the one most responsive to change.'", Author = "Charles Darwin" },
            new Quote { Text = "'The only thing standing between you and your goal is the story you keep telling yourself as to why you can't achieve it.'", Author = "Jordan Belfort" },
            new Quote { Text = "'Opportunities don't happen. You create them.'", Author = "Chris Grosser" },
            new Quote { Text = "'Don't count the days, make the days count.'", Author = "Muhammad Ali" },
            new Quote { Text = "'Life is really simple, but we insist on making it complicated.'", Author = "Confucius" },
            new Quote { Text = "'The purpose of our lives is to be happy.'", Author = "Dalai Lama" },
            new Quote { Text = "'The only limit to our realization of tomorrow will be our doubts of today.'", Author = "Franklin D. Roosevelt" },
            new Quote { Text = "'You are never too old to set another goal or to dream a new dream.'", Author = "C.S. Lewis" },
            new Quote { Text = "'Believe you can and you're halfway there.'", Author = "Theodore Roosevelt" },
            new Quote { Text = "'The best revenge is massive success.'", Author = "Frank Sinatra" },
            new Quote { Text = "'The only way to do great work is to love what you do.'", Author = "Steve Jobs" },
            new Quote { Text = "'In three words I can sum up everything I've learned about life: it goes on.'", Author = "Robert Frost" },
        };

        public ActionResult Index()
        {
            // Get a random quote
            Random random = new Random();
            Quote randomQuote = Quotes[random.Next(Quotes.Count)];

            return View(randomQuote);
        }
    }
}
