using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotteryFactory.Core.Entities
{
    [Table("Product")]
    public class Product
    {

        //public int index { get; set; }
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Marketer { get; set; }
        //public List<Lottery> lotteries { get; set; }
        public List<ProductInLottery> ProductInLotteries { get; set; }
        //public Product(string name, string description, string picture, string marketer)
        //{
        //    ProductId = id++;
        //    Name = name;
        //    Description = description;
        //    Picture = picture;
        //    Marketer = marketer;
        //}
    }
}
