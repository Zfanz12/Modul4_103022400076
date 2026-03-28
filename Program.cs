// See https://aka.ms/new-console-template for more information
using Modul4_103022400076;

KodePaket kp = new KodePaket();

string[] daftarPaket = {"Basic",
                        "Standard",
                        "Premium",
                        "Unlimited",
                        "Gaming",
                        "Streaming",
                        "Family",
                        "Business",
                        "Student",
                        "Traveler"};
Console.WriteLine("--- Kode Paket ---");
foreach (String paket in daftarPaket)
{
    Console.WriteLine($"Nama Paket: {paket} -> kode: {kp.getKodePaket(paket)}");
}

Console.WriteLine("\n --- SImulasi mesin kopi --- ");
MesinKopi mesin = new MesinKopi();
Console.WriteLine($"State awal: {mesin.GetState()}");

mesin.TurnOn();
mesin.StartBrewing();
mesin.FinishBrewing();
mesin.StartMaintenance();
mesin.EndMaintenance();
mesin.TurnOff(); 

Console.WriteLine("\n--- Uji perubahan tidak Valid ---");
mesin.StartBrewing();
mesin.TurnOn();
mesin.TurnOff();

