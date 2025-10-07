


using EF05.InsertData;

var walletToInsert = new Wallet {
    Holder = "Mariam",
    Balance = 1000.50m
};

using (var context = new AppDbContext())
{

    context.wallets.Add(walletToInsert);
    context.SaveChanges();


}






