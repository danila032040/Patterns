namespace Factory_Method.Models.Windows;

public class OneButtonWindow : IWindow
{
    private string _buttonText;


    public OneButtonWindow(string buttonText)
    {
        _buttonText = buttonText;
    }

    public void Show()
    {
        Console.WriteLine($"{_buttonText}ButtonsWindow showed");
    }

    public void Close()
    {
        Console.WriteLine($"{_buttonText}ButtonsWindow closed");
    }

}
