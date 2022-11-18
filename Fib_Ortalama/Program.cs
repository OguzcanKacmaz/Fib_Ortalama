Console.Write("Ortalamasını İstediğiniz Fibonacci Dizisinin Eleman Sayısını Giriniz : ");
int elemanSayisi=Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int yedek ;
Console.Write(a+"-");
Console.Write(b+"-");
for (int i = 0; i < elemanSayisi-2; i++)
{
    yedek = a+b;
    a = b;
    b=yedek;
    Console.Write(yedek+"-");
}
Console.ReadKey();