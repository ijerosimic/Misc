using System;

public class Class1
{
	public Class1()
	{

        var pi = 3.1415926535897932384626433832795028841971693993751058209749445923;

        Console.WriteLine("Unesite broj decimala");
        var brojDecimala = Console.ReadLine();

        var piOdrezan = pi.ToString("#.4");

        Console.ReadLine(piOdrezan);

    }
}
