using NepessegCLI;
using System.Text;

const string PATH = "D:\\PROJECTS\\CSHARP25011701\\NEPESSEG\\adatok-utf8.txt";
List<Orszag> orszagok = [];

using StreamReader sr = new(PATH, Encoding.UTF8);
_ = sr.ReadLine();
while(!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    string[] darabok = sor.Split(';');

    string orszagNev = darabok[0];
    int terulet = int.Parse(darabok[1]);

    //string nepesegAdat = darabok[2];
    //int nepessegSzam = 0;
    //if (nepesegAdat[^1] == 'g')
    //{
    //    nepessegSzam = int.Parse(nepesegAdat[0..^1]) * 10000;
    //}
    //else
    //{
    //    nepessegSzam = int.Parse(nepesegAdat);
    //}

    // változó = <feltétel>
    // ? <érték, ha a feltétel igaz>
    // : <érték, ha a feltétel hamis>

    //int nepesseg = int.Parse(darabok[2]);

    int nepesseg = darabok[2][^1] == 'g'
        ? int.Parse(darabok[2][..^1]) * 10000
        : int.Parse(darabok[2]);

    string fvaros = darabok[3];

    int fvNepesseg = int.Parse(darabok[4]) * 1000;

    Orszag orszag = new(orszagNev, terulet, nepesseg, fvaros, fvNepesseg);

    orszagok.Add(orszag);
}

Console.WriteLine("3. feladat");
Console.WriteLine($"a beolvasott orszagok szama: {orszagok.Count}");

Console.WriteLine("4. feladat");
var kina = orszagok.Single(o => o.Orszagnev == "Kína");
Console.WriteLine($"Kina nepsurusege: {kina.Nepsuruseg} fo/km^2");

Console.WriteLine("5. feladat");
var india = orszagok.Single(o => o.Orszagnev == "India");
int kulonbseg = kina.Nepesseg - india.Nepesseg;
Console.WriteLine($"Kinaban a lakossag {kulonbseg} fovel volt tobb");

var rendezett = orszagok.OrderByDescending(o => o.Nepesseg).ToList();

Console.WriteLine("6. feladat");
Console.WriteLine($"a harmadik legnepesebb orszag: " +
    $"{rendezett[2].Orszagnev}, " +
    $"lakossága {rendezett[2].Nepesseg} fo");

Console.WriteLine("8. feladat: a kovetkezo orszagok lakossaganak tobb, mint 30%-a a fovarosban lakik:");
var koncentraltLO = orszagok.Where(o => o.FVbeKoncentralt);
foreach (var o in koncentraltLO)
{
    Console.WriteLine($"\t{o.Orszagnev} ({o.Fovaros})");
}




