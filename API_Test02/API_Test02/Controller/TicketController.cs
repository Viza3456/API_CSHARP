using System;
using System.Linq;
using System.Threading.Tasks;
using CoreAPI.Model;
using DataStore.EF;
//using API_Test02.Model;
//using API_Test02.UpdateValidation;
using Microsoft.AspNetCore.Mvc;

namespace API_Test02.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly BugeContext context;

        public TicketController(BugeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = this.context.Tickets.ToList();
            return Ok(data);
        }

        [HttpGet("{TicketId}")]
        public IActionResult Get(int TicketId)
        {
            var data = this.context.Tickets.Find((TicketId));
            return Ok(data);
        }
        [HttpPut("{TicketId}")]
        public IActionResult UpdateTicket(int TicketId,[FromBody] Ticket ticket)
        {
            var data = this.context.Tickets.Find(TicketId);
            if (data != null)
            {
                data.demo = ticket.demo;
                data.dsc = ticket.dsc;
                data.owner = ticket.owner;
                data.text = ticket.text;
                data.DueDate = ticket.DueDate;
                data.ReportDate = ticket.DueDate;
                this.context.SaveChanges();
                return Ok(data);
            }
            else
            {
                return Ok("Update in Valid");
            }
            //
        }
        [HttpPost]
        public async Task<IActionResult> PostT([FromBody] Ticket ticket)
        {
            this.context.Tickets.Add(ticket);
            await this.context.SaveChangesAsync();
            return Ok(ticket);
        }
        [HttpDelete("{TicketId}")]
        public IActionResult Delete(int TicketId)
        {
            var data = this.context.Tickets.Find(TicketId);
            this.context.Tickets.Remove(data);
            this.context.SaveChanges();
            return Ok(data);
        }
        //[HttpPost]
        //[Route("/api/v2/ticket")]
        //[V2ValidationTicket]
        //public IActionResult PostV2([FromBody] Ticket ticket)
        //{
        //    return Ok(ticket);
        //}
        //[HttpPut]
        //[Route("api/tickets")]
        //public IActionResult Put()
        //{
        //    return Ok("Update Result");
        //}
        //[HttpDelete]
        //[Route("api/tickets/{id}")]
        //public IActionResult Delete(int Id)
        //{
        //    return Ok($"Tickets is Delete Result By: {Id}");
        //}

        [HttpGet]
        [Route("/api/project/{Pid}/tickets")]
        public IActionResult GetById(int Pid, int Tid)
        {
            return Ok($"Project is #:{Pid} And Tickets is #{Tid}");
        }

        //[HttpGet]
        //[Route("/api/project/{pid}/tickets")]
        //public IActionResult GetById([FromQuery] Ticket ticket)
        //{
        //    if (ticket == null)
        //    {
        //        return BadRequest("Invalid");
        //    }
        //    return Ok($"Project is #:{ticket.pid} And Tickets is #{ticket.tid} And Text : {ticket.text} And Description : {ticket.dsc}");
        //}
    }
}
