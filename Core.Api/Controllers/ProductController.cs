using Core.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Core.Api.Controllers
{
    public class ProductController : ControllerBase
    {

        /// <summary>
        ///     Anket Ekleme 
        /// </summary>
        /// <param name="dto"></param>
        /// <response code="201">Eklenen "dto" objesi</response>
        /// <response code="400">Eksik olan Fieldlar</response>
        [Authorize(Roles = "Anketor")]
        [HttpPost("PostSurvey")]
        [ProducesResponseType(typeof(ValidationProblemDetails), 400)]
        [ProducesResponseType(typeof(void), 201)]
        public async Task<ActionResult> PostSurvey()
        {


            return NoContent();
        }
    }
}
