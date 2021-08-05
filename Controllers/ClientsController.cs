using System;
using System.Linq;
using TestApp.Context;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : Controller
    {
        private readonly AppTestContext DbContext;
        public ClientsController(AppTestContext dbContext) => DbContext = dbContext;
        // GET: api/<ClientsController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(DbContext.Clients.DefaultIfEmpty().ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            //ViewBag.Types = DbContext.Ids.Select(h => new { Value = h.Identification, Text = h.IdentificationName });
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}", Name = "GetClients")]
        public IActionResult Get(int id)
        {
            try
            {
                var client = DbContext.Clients.DefaultIfEmpty().FirstOrDefault(h => h.Identification == id);
                return Ok(client); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // POST api/<ClientsController>
        [HttpPost]
        public IActionResult Put([Bind] Clients Client)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new ArgumentException("Error");

                DbContext.Clients.Update(Client);
                DbContext.SaveChanges();
                return CreatedAtRoute("GetClients", new { id = Client.Identification }, Client);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
