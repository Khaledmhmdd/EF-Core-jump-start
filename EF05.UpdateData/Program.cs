               
using EF05.UpdateData;



using (var context = new AppDbContext()) 
{
    var walletToUpdete = context.wallets.Single(x => x.Id == 10);

    walletToUpdete.Balance += 2000;
    context.SaveChanges();

}
















