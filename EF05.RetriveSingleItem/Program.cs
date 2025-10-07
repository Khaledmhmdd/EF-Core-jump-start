
using EF05.RetriveSingleItem;




var ItemToRetriveFromConsole = int.Parse(Console.ReadLine());
var ItemToRetrive = 3;

using (var context = new AppDbContext() )
{

    var item = context.wallets.FirstOrDefault(x => x.Id == ItemToRetrive);

    Console.WriteLine(item);

}






