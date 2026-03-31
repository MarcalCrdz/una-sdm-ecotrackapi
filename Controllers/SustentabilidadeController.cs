using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace EcoTrackApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private static readonly string[] Dicas = new[]
        {
            "Reduza o consumo de plástico descartável.",
            "Opte por transporte público ou bicicleta sempre que possível.",
            "Economize energia desligando aparelhos eletrônicos quando não estiverem em uso.",
            "Plante árvores para ajudar a combater as mudanças climáticas.",
            "Compre produtos locais e sazonais para reduzir a pegada de carbono."
        };

        [HttpGet("dicas")]
        public string Get()
        {
            var random = new Random();
            return Dicas [random.Next(Dicas.Length)];
        }

    }
}