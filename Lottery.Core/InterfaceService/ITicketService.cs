using LotteryFactory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Core.InterfaceService
{
    public interface ITicketService
    {
        public List<Ticket> GetTickets();
     
        public Ticket GetTicketById(int id);
 
        public Ticket AddTicket(Ticket ticket);


        public Ticket UpdateTicket(int id, Ticket ticket);
 
        public bool RemoveTicket(int id);



    }

}
