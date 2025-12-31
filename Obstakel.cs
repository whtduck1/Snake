public class Obstakel
{
    public int Xpos { get; set; }
    public int Ypos { get; set; }

    public ConsoleColor schermKleur { get; set; }
    public string karacter { get; set; }
    public Obstakel(int x, int y, ConsoleColor kolor = ConsoleColor.Red, string znak = "█")
    {
        Xpos = x;
        Ypos = y;
        schermKleur = kolor;
        karacter = znak;
    }

    public void Draw()
    {
        Console.ForegroundColor = schermKleur;
        Console.SetCursorPosition(Xpos, Ypos);
        Console.Write(karacter);
        Console.ResetColor();
    }
}