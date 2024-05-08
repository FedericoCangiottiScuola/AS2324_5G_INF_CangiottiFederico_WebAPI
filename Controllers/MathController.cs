using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_CangiottiFederico_API.Controllers
{
    public class MathController : Controller
    {
        [HttpGet("MultiploIntero")]
        public JsonResult MultiploIntero(int firstNumber, int secondNumber)
        {
            string output = string.Empty;
            string status = "OK";
            string messagge = string.Empty;

            if (firstNumber % secondNumber == 0)
            {
                output = "true";
                messagge = "The first number is multiple of the second number";
            } else
            {
                output = "false";
                messagge = "The first number is not multiple of the second number";
            }

            return new JsonResult(new
            {
                output = output,
                status = status,
                messagge = messagge
            });
        }

        [HttpGet("Potenza")]
        public JsonResult Potenza(int b, int esponente)
        {
            int output = 1;
            string status = "OK";
            string messagge = string.Empty;

            for (int i = 0; i < esponente; i++)
            {
                output *= b;
            }

            return new JsonResult(new
            {
                output = output,
                status = status,
                messagge = messagge
            });
        }
        
        [HttpGet("Bisestile")]
        public JsonResult Bisestile(int anno)
        {
            bool output;
            string status = "OK";
            string messagge = string.Empty;

            if (anno % 4 == 0)
            {
                output = true;
            } else
            {
                output = false;
            }

            return new JsonResult(new
            {
                output = output,
                status = status,
                messagge = (output) ? "L'anno � bisestile" : "L'anno non � bisestile"
            });
        }

        [HttpGet("Ipotenusa")]
        public JsonResult Ipotenusa(double cateto1, double cateto2)
        {
            string output = string.Empty;
            string status = string.Empty;
            string messagge = string.Empty;

            double ipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            return new JsonResult(new
            {
                output = ipotenusa,
                status = "OK",
                messagge = ""
            });
        }
    }
}
