
using LotteryFactory.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotteryFactory.Core.Entities
{
    [Table("ProductInLottery")]
    public class ProductInLottery
    {
        [Key]
        public int index { get; set; }
        static int id;
        public int ProductInLotteryId { get; }
        public int ProductId { get; set; }
        public int LotteryId { get; set; }
        public string WinnerId { get; set; }//?????//to add a field in user if he win or not?
        //public DateOnly ClaimDeadline { get; set; }
        //public PrizeDistribution PrizeDistribution { get; set; }

        //public ProductInLottery(int productId, int lotteryId, string winnerId, DateOnly claimDeadline, PrizeDistribution prizeDistribution)
        //{
        //    ProductInLotteryId = id++;
        //    ProductId = productId;
        //    LotteryId = lotteryId;
        //    WinnerId = winnerId;
        //    ClaimDeadline = claimDeadline;
        //    PrizeDistribution = prizeDistribution;
        //}
    }
}
