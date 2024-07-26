Console.WriteLine("List öğesine tanımlama ve eklemeler:");
//Tanımlama 1
List<int> sayilar1 = new List<int>();

//Tanımlama 2
var sayilar2 = new List<int>();

var x = 55;

int[] Seri = new int[] { 150, 250, 350, 450 };

//Ekleme (değer)
sayilar1.Add(10);
sayilar1.Add(20);
sayilar1.Add(30);

//Ekleme (değişken)
sayilar1.Add(x);

//Ekleme (seri)
sayilar1.AddRange(Seri);

//Ekleme (seri)
sayilar1.AddRange(new int[] { 1500, 2500, 3500, 4500, 6500 });

foreach (var (value, index) in sayilar1.Select((value, index) => (value, index)))
{
    Console.WriteLine($"{index}. {value}");
}
Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine();


Console.WriteLine("List öğresine araya öğeler ekleme:");
//Ekleme (araya)
sayilar1.Insert(3, 150000); // 3. indise 150000 değeri eklenir

foreach (var (value, index) in sayilar1.Select((value, index) => (value, index)))
{
    Console.WriteLine($"{index}. {value}");
}
Console.WriteLine();
Console.WriteLine("------");
Console.WriteLine();


//Ekleme (araya Seri)
sayilar1.Insert(8, 1500000); // 8. indise 1500000 değeri eklenir

foreach (var (value, index) in sayilar1.Select((value, index) => (value, index)))
{
    Console.WriteLine($"{index}. {value}");
}
Console.WriteLine();
Console.WriteLine("-------");
Console.WriteLine();


//Ekleme (araya Seri)
sayilar1.InsertRange(6, new int[] { 15, 35, 55}); // 8. indise 1500000 değeri eklenir

foreach (var (value, index) in sayilar1.Select((value, index) => (value, index)))
{
    Console.WriteLine($"{index}. {value}");
}
Console.WriteLine();
Console.WriteLine("-------");
Console.WriteLine();

Console.WriteLine("List öğresinden öğe silme:");
//Silme (aradan)
sayilar1.Remove(1500000); // 1500000 değerine ait eleman silinir

foreach (var (value, index) in sayilar1.Select((value, index) => (value, index)))
{
    Console.WriteLine($"{index}. {value}");
}
Console.WriteLine();
Console.WriteLine("-------");
Console.WriteLine();

//Silme (aradan)
sayilar1.RemoveAt(sayilar1.IndexOf(150000)); // 1500000 değerine ait eleman silinir

foreach (var (value, index) in sayilar1.Select((value, index) => (value, index)))
{
    Console.WriteLine($"{index}. {value}");
}
Console.WriteLine();
Console.WriteLine("-------");
Console.WriteLine();


