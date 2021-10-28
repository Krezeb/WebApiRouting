using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRouting.Controllers
{
    [Route("dog")]
    [ApiController]
    public class DogController : ControllerBase
    {
        [HttpPost ("pet")]
        public IActionResult Pet([FromBody]Dog newDog)
        {
            if (newDog.HappinessLevel == "Happy")
            {
                newDog.HappinessLevel = "Very Happy";
                return Ok(newDog);
            }
            return BadRequest($"HappinessLevel \"{newDog.HappinessLevel}\" not recognised.");
        }

        [HttpPost("kick")]
        public IActionResult Kick([FromBody] Dog newDog)
        {
            return BadRequest();
        }

        [HttpPost("find-sock")]
        public IActionResult FindSock([FromBody] Dog newDog)
        {
            if (newDog.HappinessLevel == "Very Happy")
            {
                return NotFound($"Not Found...");
            }
                return Ok($"Sock Found!");
        }

    }
}
/*
 * 3.3
 * Skapa en metod i DogController som heter FindSock. 
 * Lägg till en POST- route som svara på URL:en /dog/find-sock. 
 * Metoden ska ta emot en Dog som request body och returnera en IActionResult.
 * 
 * Implementera metoden så att om Dog-instansen som skickades in har ett 
 * HappinessLevel på "very happy" ska metoden returnera statuskod 404. 
 * OM HappinessLevel är något annat ska metoden returnera strängen "Sock found". 
 * Kom ihåg att vi inte kan returnera en string direkt när vi använder IActionResult.
 * 
 * Kör programmet och verifiera att du får en korrekt JSON tillbaka. T.ex. om du skickar in

POST /dog/find-sock
{
  "Name": "Fido",
  "HappinessLevel": "very happy",
}

borde du får tillbaka

Status code: 404
*/