// See https://aka.ms/new-console-template for more information
using _31._08._2022;




Tootaja tootaja = new Tootaja("TTHK", "õpetaja", 2000, "Timofey", 2005, Isik.Sugu.isane, 1100, 20);
tootaja.print_Info();
Opilane opilane = new Opilane("TTHK", "TARpv21", "Programmerimine", "Artjom", 2005, Isik.Sugu.isane, 0, 0);
opilane.print_Info();
Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Tallinn",2,300,3.5,"tarkvara arendaja","THK","2",60,"TARpv21","Ludmila",1998,Isik.Sugu.emane,500,0);
kutsekooliopilane.print_Info();

List<Isik> people = new List<Isik>();

people.Add(tootaja);
people.Add(opilane);
people.Add(kutsekooliopilane);
Console.WriteLine("\n");
StreamWriter to_file = new StreamWriter(@"..\..\..\spisok.txt", false);
foreach (Isik x in people)
{
    x.print_Info();

    to_file.WriteLine(x.nimi + ", " + x.arvutaVanus() + ", " + x.isikSugu + ", " + x.synniaasta + ", " + x.palk + ", "+ x.tulumaks + ", "+ x.maksuvaba + ", "+ x.sissetulek + ";" );
}
to_file.Close();
List<Tootaja> tootajad = new List<Tootaja>();
StreamReader sr = new StreamReader(@"..\..\..\spisok.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    tootajad.Add(new Tootaja(rida[0], rida[1], int.Parse(rida[2]), rida[3], int.Parse(rida[4]), TextSugu(rida[5]), double.Parse(rida[6]), double.Parse(rida[7])));
}
sr.Close();
foreach (var item in tootajad)
{
    Console.WriteLine(item.nimi + " " + item.isikSugu);
}

Isik.Sugu TextSugu(string andmed)
{
    switch (andmed)
    {
        case "emane":
            return Isik.Sugu.emane;
        default:
            return Isik.Sugu.isane;
    }
}



