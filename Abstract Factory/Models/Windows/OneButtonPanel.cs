namespace Abstract_Factory.Models.Windows;

public abstract class OneButtonPanel : IPanel
{
    private string _buttonText;


    public OneButtonPanel(string buttonText)
    {
        _buttonText = buttonText;
    }

    public virtual void Show()
    {
        Console.WriteLine($"{_buttonText}ButtonWindow showed");
    }

    public virtual void Close()
    {
        Console.WriteLine($"{_buttonText}ButtonWindow closed");
    }

}
