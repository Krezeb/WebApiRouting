using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiRouting.Controllers
{
    [Route("compute")]
    [ApiController]
    public class ComputationController : ControllerBase
    {
        [HttpGet ("message")]
        public string Message(string myMessage)
        {
            return $"Ditt meddelande är {myMessage}";
        }
        [HttpGet("upper/{input}")]
        public string Upper(string input)
        {
            string newOutput = input.ToUpper();
            return $"Ditt meddelande är {newOutput}";
        }

        [HttpGet("concat/{message1}")]
        public string Concat(string message1, string message2)
        {
            return $"Message 1: {message1}\nMessage 2: {message2}\nSammanslagning: {message1}{message2}";
        }

        [HttpGet("add")]
        public string Add(int num1, int num2)
        {
            int summa = num1 + num2;
            return $"{num1} + {num2} = {summa}";
            //return summa.ToString();
            //return Convert.ToString(num1 + num2);
        }

        [HttpGet("add2/{num1}/{num2}")]
        public string Add2(int num1, int num2)
        {
            int summa = num1 + num2;
            return $"{num1} + {num2} = {summa}";
            //return summa.ToString();
            //return Convert.ToString(num1+num2);
        }

        [HttpGet("multi")]
        public string MultiGreeter(int count, string message)
        {
            string totalMessage = "";
            for (int i = 0; i < count; i++)
            {
                totalMessage += message;
            }
            return totalMessage;
        }

        [HttpGet("multi2/{count}/{message}")]
        public string MultiGreeter2(int count, string message)
        {
            string totalMessage = "";
            for (int i = 0; i < count; i++)
            {
                totalMessage += message;
            }
            return totalMessage;
        }

        [HttpPost ("execute")]
        public int ComputeController([FromBody] ComputeUnit myInput)
        {
            return myInput.Compute();
        }

        [HttpPost("multiexecute")]
        public int MultiCompute(int count, [FromBody] ComputeUnit myInput)
        {
            return myInput.Compute()*count;
        }

        [HttpGet("create-addition")]
        public ComputeUnit CreateAdditionComputation(int value1, int value2 )
        {
            //ComputeUnit computeUnit = new ComputeUnit()
            //{
            //    Value1 = value1,
            //    Value2 = value2,
            //    Mode = "addition"
            //};
            //return computeUnit;

            return new ComputeUnit() //Super cool way to do the above!
            {
                Value1 = value1,
                Value2 = value2,
                Mode = "addition"
            };
        }
        [HttpPost("change-mode/{newMode}")]
        public ComputeUnit ChangeMode(string newMode, [FromBody]ComputeUnit bodyInput)
        {

            return new ComputeUnit()
            {
                Mode = newMode,
                Value1 = bodyInput.Value1,
                Value2 = bodyInput.Value2
            };
        }
    }
}
/* 
 * 2.6
 * Skapa en metod i ComputationController som heter ChangeMode. 
 * Lägg till en POST-route so att metoden svarar på URL:en /compute/change-mode. 
 * Metoden ska också ta in en route-parameter som heter newMode och är av typen string. 
 * Metoden ska också ta emot en ComputeUnit som request body. 
 * Metoden ska returnera en ComputeUnit.
 * 
 * Implementera metoden så att den sätter om Mode på den ComputeUnit- instans som 
 * skickas in till det mode vi får i newMode-parametern. 
 * Returnera sedan instansen av ComputeUnit.
 * 
 * Kör programmet och verifiera att du får en korrekt JSON tillbaka. T.ex. om du skickar in

POST /compute/change-mode/multiplication
{
  "Mode": "addition",
  "Value1": 10,
  "Value2": 21
}
borde du får tillbaka

{
  "Mode": "multiplication",
  "Value1": 10,
  "Value2": 21
}
 */