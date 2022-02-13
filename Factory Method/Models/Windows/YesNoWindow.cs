namespace Factory_Method.Models.Windows;

public class YesNoWindow : IWindow
{
    public void Show()
    {
        Console.WriteLine("YesNoWindow showed");
    }
    public void Close()
    {
        Console.WriteLine("YesNoWindow closed");
    }
}
