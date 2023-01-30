using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Models
{
    public class CardDeckApi
    {
        
        public bool success { get; set; }   
        public string deck_id { get; set; }
        public List<CardDetailsApi> cards { get; set; }
        public int remaining { get; set; }

        public CardDeckApi DrawCards()
        {
            string url = $"https://deckofcardsapi.com/api/deck/y0begym40vkk/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            CardDeckApi result = JsonConvert.DeserializeObject<CardDeckApi>(JSON);
            return result;
        }
    }
}
