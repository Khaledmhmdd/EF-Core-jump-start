using EF05.RetriveData;

using (var context = new AppDbContext())
{
    //var wallets = context.wallets.ToList();
    foreach (var wallet in context.wallets)
    {
        Console.WriteLine($"{wallet}");
    }
}