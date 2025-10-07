
using EF05.DeleteData;

using (var context = new AppDbContext()) 
{
    var walletToDelete = context.wallets.FirstOrDefault(x=>x.Id == 1);
    context.wallets.Remove(walletToDelete);
    context.SaveChanges();
}
Console.ReadKey();