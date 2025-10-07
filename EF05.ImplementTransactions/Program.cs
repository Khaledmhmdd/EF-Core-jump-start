using System.Transactions;
using EF05.ImplementTransactions;

using (var context = new AppDbContext()) 
{
    using (var transaction = context.Database.BeginTransaction()) 
    {
        //trransfer 100 from wallet 3 to wallet 4
        var fromWallet = context.wallets.Single(x=>x.Id == 3);
        var toWallet = context.wallets.Single(x => x.Id == 4);

        //Operation #01 withdraw
        fromWallet.Balance -= 500;
        context.SaveChanges();

        //Operation #02 deposit
        toWallet.Balance += 500;
        context.SaveChanges();

        transaction.Commit();
    }
}
Console.ReadKey();