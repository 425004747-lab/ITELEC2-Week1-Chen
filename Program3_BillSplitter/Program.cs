
int totalBill = 250;
int friends = 4;

int share = totalBill / friends;
int leftover = totalBill % friends;

double exactShare = (double)totalBill / friends;

Console.WriteLine("****** BILL SPLITTER ******");
Console.WriteLine($"Total Bill: PHP {totalBill}");
Console.WriteLine($"Number of Friends: {friends}");
Console.WriteLine("\nEXACT SHARE");
Console.WriteLine($"Each friend pays: PHP {share}");
Console.WriteLine("\nREMAINING BALANCE");
Console.WriteLine($"Leftover amount: PHP {leftover}");

Console.WriteLine("\nExact Division:");
Console.WriteLine($"Each friend pays: PHP {exactShare}");
