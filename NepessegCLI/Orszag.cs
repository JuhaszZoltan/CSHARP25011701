﻿namespace NepessegCLI;

class Orszag
{
    public string Orszagnev { get; private set; }
    public int Terulet { get; private set; }
    public int Nepesseg { get; private set; }
    public string Fovaros { get; private set; }
    public int FovarosNepesseg { get; private set; }

    public int Nepsuruseg => (int)Math.Round(Nepesseg / (float)Terulet);

    public Orszag(string orszagnev, int terulet, int nepesseg, string fovaros, int fovarosNepesseg)
    {
        Orszagnev = orszagnev;
        Terulet = terulet;
        Nepesseg = nepesseg;
        Fovaros = fovaros;
        FovarosNepesseg = fovarosNepesseg;
    }

    public override string ToString()
    {
        return "";
    }
}
