// See https://aka.ms/new-console-template for more information
using _31._08._2022;
Tootaja tootaja = new Tootaja("TTHK", "õpetaja", 2000, "Timofey", 2005, Isik.Sugu.isane, 1100, 20);
tootaja.print_Info();
Opilane opilane = new Opilane("TTHK", "TARpv21", "Programmerimine", "Artjom", 2005, Isik.Sugu.isane, 0, 0);
opilane.print_Info();
Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Tallinn",2,300,3.5,"tarkvara arendaja","THK","2",60,"TARpv21","Ludmila",1998,Isik.Sugu.emane,500,0);
kutsekooliopilane.print_Info();

