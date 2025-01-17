using NepessegCLI;
using System.Text;

const string PATH = "C:\\Users\\juhaszz\\source\\repos\\CSHARP25011701\\NEPESSEG\\adatok-utf8.txt";
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

}



