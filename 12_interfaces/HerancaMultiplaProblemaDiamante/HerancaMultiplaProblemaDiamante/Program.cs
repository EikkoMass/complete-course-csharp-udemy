using HerancaMultiplaProblemaDiamante.Devices;

namespace HerancaMultiplaProblemaDiamante;

public class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer() { SerialNumber = 1080 };
        p.ProcessDoc("My Letter");
        p.Print("My Letter");
        
        Scanner s = new Scanner() { SerialNumber = 2003 };
        s.ProcessDoc("My Email");
        Console.WriteLine(s.Scan());
        
        ComboDevice cd = new ComboDevice() { SerialNumber = 3921 };
        cd.ProcessDoc("My Dissertation");
        cd.Print("My Dissertation");
        Console.WriteLine(cd.Scan());
    }
}