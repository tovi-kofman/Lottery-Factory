

using LotteryFactory.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotteryFactory.Core.Entities
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        public int index { get; set; }
        static int id;
        public int TicketId { get; }
        public int LotteryId{ get; set; }
        //public TicketStatus Status { get; set; }
        public int UserId { get; set; }
        //public DateOnly PurchaseDate { get; set; }
        //public DateOnly ExpiryDate { get; set; }
        public bool PrizeWon { get; set; }
        //public TicketValidationStatus TicketValidationStatus { get; set; }

        //public Ticket(int lotteryId, TicketStatus status, int userId, DateOnly purchaseDate, DateOnly expiryDate, bool prizeWon, TicketValidationStatus ticketValidationStatus)
        //{
        //    TicketId = id++;
        //    LotteryId = lotteryId;
        //    Status = status;
        //    UserId = userId;
        //    PurchaseDate = purchaseDate;
        //    ExpiryDate = expiryDate;
        //    PrizeWon = prizeWon;
        //    TicketValidationStatus = ticketValidationStatus;
        //}
    }
}
