
Console.WriteLine("Hello enter your age :");
string age = Console.ReadLine();
string greeting  = $"Hello Mr.Eldor your age is {age}";
Console.WriteLine(greeting);

Console.WriteLine("Hello Enter another age :");
string age2 = Console.ReadLine();
int dif = Convert.ToInt32(age)-Convert.ToInt32(age2);
Console.WriteLine($"Difference: {dif}");
if (dif>0) Console.WriteLine("First persin older then Secend ");
else Console.WriteLine("Secend persin older then First ");


