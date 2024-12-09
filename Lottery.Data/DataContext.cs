using LotteryFactory.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace LotteryFactory.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Lottery> Lotteries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInLottery> ProductsInLotteries { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            ////string path = Path.Combine(AppContext.TargetFrameworkName, "Data");
            //string path = @"E:\תכנות\דוטנט\שיעורי בית\Lottery\Lottery.Data\Data\Data.json";

            //string jsonString = File.ReadAllText(path);
            ////var AllUsers = JsonSerializer.Deserialize<DataUsers>(jsonString);// typeof(DataUsers)); ;
            ////db= JsonSerializer.Deserialize<List<T>>(jsonString);
            ////db = System.Text.Json.JsonSerializer.Deserialize<List<T>>(jsonString);
            //db = JsonSerializer.Deserialize<List<T>>(jsonString);
           
            //List<T>l = JsonConvert.DeserializeObject<List<T>>(jsonString);
        }
        //public bool SaveData<T>(List<T> data)
        //{
        //    try
        //    {
        //        string path = @"E:\תכנות\דוטנט\שיעורי בית\Lottery\Lottery.Data\Data\Data.json";
        //        List<T> dataToSave = data;
        //        var jsonString =JsonSerializer.Serialize<List<T>>(dataToSave);
        //        if (File.Exists(path))
        //        {
        //            File.Delete(path);
        //        }
        //        File.WriteAllText(path, jsonString);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
