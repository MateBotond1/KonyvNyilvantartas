using KonyvNyilvantartas;

List<Konyv> Lista = new List<Konyv>();

for (int i = 0; i < 3; i++)
{
    Konyv aktualis = new Konyv();
    Console.WriteLine($"{i + 1}. könyv adatai:");
    Console.Write("\tCím:");
    aktualis.Cim = Console.ReadLine();
    Console.Write("\tSzerző:");
    aktualis.Szerzo = Console.ReadLine();
    Console.Write("\tOldalszám::");
    aktualis.Oldalszam = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Lista.Add( aktualis );
}