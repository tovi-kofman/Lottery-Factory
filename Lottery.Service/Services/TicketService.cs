using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Service.Services
{
    public class TicketService : ITicketService
    {
        readonly IRepository<Ticket> _ticketRepository;

        public TicketService(IRepository<Ticket> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Ticket AddTicket(Ticket ticket)
        {
           return _ticketRepository.Add(ticket);   
        }

        public Ticket GetTicketById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public List<Ticket> GetTickets()
        {
            return _ticketRepository.GetAll();
        }

        public bool RemoveTicket(int id)
        {
            return _ticketRepository.Delete(id);
        }

        public Ticket UpdateTicket(int id, Ticket ticket)
        {
            return _ticketRepository.Update(id, ticket);
        }
    }
}
