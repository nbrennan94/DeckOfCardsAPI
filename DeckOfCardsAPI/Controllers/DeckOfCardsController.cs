using DeckOfCardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Flurl.Http;
using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Controllers
{
    public class DeckOfCardsController : Controller
    {

        public CardDeckApi cardDeck = new CardDeckApi();
        
        public IActionResult Index()
        {
            CardDeckApi cards = cardDeck.DrawCards();
            return View(cards);  
        }

        
    }
}
