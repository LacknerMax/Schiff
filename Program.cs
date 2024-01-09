using Schiff_uebung;

Container Schaf = new Container(2300, "Schaf");
Container Gmoar = new Container(2700, "Gmoar");
Container Lisi = new Container(2900, "Lisi");
Container Gugg = new Container(1900, "Gugg");


Schiff BlackPearl = new Schiff(50000, "BlackPearl");



BlackPearl.Add(Schaf);
BlackPearl.Add(Gmoar);
BlackPearl.Add(Lisi);
BlackPearl.Add(Gugg);

Console.WriteLine("Das Schiff {0} hat ein Gesamtgewicht von {1} kilogramm",BlackPearl.ShipName,BlackPearl.Gesamtgewicht());
