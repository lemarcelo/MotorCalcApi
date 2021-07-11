using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotorCalcApi.Models;
using MotorCalcApi.Data;

namespace MotorCalcApi.Models
{
    public class MedidasController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Medidas>>> Get([FromServicesAttribute] DataContext context)
        {
            var categories = await context.Medidas.ToListAsync();
            return categories;
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Medidas>> Post(
            [FromServices] DataContext context,
            [FromBody] Category model)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
}