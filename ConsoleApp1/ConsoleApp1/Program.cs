int a = 1, b = 1, i, n, reqem3;
string daxiledilen;
daxiledilen = Console.ReadLine();
n = Convert.ToInt32(daxiledilen);
Console.WriteLine(a);
Console.WriteLine(b); 
for(i = 2; i <= n; i++)
{
    reqem3 = a + b;
    Console.WriteLine(reqem3);
    a = b;
    b = reqem3;


}