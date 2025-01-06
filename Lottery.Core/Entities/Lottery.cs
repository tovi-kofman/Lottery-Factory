using LotteryFactory.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotteryFactory.Core.Entities
{
    [Table("Lottery")]
    public class Lottery
    {

        //public int index { get; set; }
        [Key]
        public int LotteryId { get; set; }
        //public LotteryType? LotteryType { get; set; }
        //public double? TicketPrice { get; set; }
        //public DateOnly? StartDate { get; set; }
        //public DateOnly? EndDate { get; set; }
        //public double? JackpotAmount { get; set; }
        //public double? OddsOfWinning { get; set; }
        //public DateOnly? TicketSalesDeadline { get; set; }
        //public Frequency? DrawFrequency { get; set; }
        ////public List<TicketSalesChannel>? TicketSalesChannels { get; set; }
        //public TicketSalesChannel? TicketSalesChannel { get; set; }
        public int WinningsAmount { get; set; }
        //public List<Product> Products { get; set; }
        //public int ProductId { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<ProductInLottery> ProductInLotteries { get; set; }

        //public Lottery(LotteryType? lotteryType, double? ticketPrice, DateOnly? startDate, DateOnly? endDate, double? jackpotAmount, double? oddsOfWinning, DateOnly? ticketSalesDeadline, Frequency? drawFrequency, TicketSalesChannel? ticketSalesChannel, int? winningsAmount)
        //{
        //    LotteryId = id++;
        //    LotteryType = lotteryType;
        //    TicketPrice = ticketPrice;
        //    StartDate = startDate;
        //    EndDate = endDate;
        //    JackpotAmount = jackpotAmount;
        //    OddsOfWinning = oddsOfWinning;
        //    TicketSalesDeadline = ticketSalesDeadline;
        //    DrawFrequency = drawFrequency;
        //    TicketSalesChannel = ticketSalesChannel;
        //    WinningsAmount = winningsAmount;
        //}

        //public Lottery()
        //{
        //}
    }

}
