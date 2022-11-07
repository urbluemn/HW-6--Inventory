using InventoryCS;

var createinv = new CreateInventory();
Inventory inv = createinv.InitInventory();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("View the whole list of products:");
Console.ResetColor();
Console.WriteLine();

inv.ViewProducts();

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Sort products by type: Food, Machinery, Chemicals");
Console.ResetColor();
Console.WriteLine();
//string str = Console.ReadLine();

inv.SortByType("Food");
Console.WriteLine();

inv.SortByType("Machinery");
Console.WriteLine();

inv.SortByType("Chemicals");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Counting inventory price sum:");
Console.ResetColor();
Console.WriteLine();
inv.CountInvSum();