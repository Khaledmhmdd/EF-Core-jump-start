using EF05.QueryData;


using (var context = new AppDbContext())
{
    //retrive all wallets from database that balance more than 15000
    var res = context.wallets
        .Where(w => w.Balance > 13000)
        .OrderByDescending(w => w.Balance)
        .ToList();
    foreach (var wallet in res)
    {
        Console.WriteLine(wallet);
    }

}